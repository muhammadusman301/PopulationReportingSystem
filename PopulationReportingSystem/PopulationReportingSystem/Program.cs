using System;
using MySql.Data.MySqlClient;

namespace PopulationReportingSystem
{
    class Program
    {
        // Connection string for MySQL Database
        static string connectionString = "Server=127.0.0.1;Database=world;Uid=root;Pwd=;";
        static MySqlConnection conn = new MySqlConnection(connectionString);

        static void Main(string[] args)
        {
            while (true)
            {
                // Main menu for the user
                Console.Clear();
                Console.WriteLine("===============================================");
                Console.WriteLine("Population Reporting System - Menu");
                Console.WriteLine("===============================================");
                Console.WriteLine("WELCOME TO REPORT GENERATION");
                Console.WriteLine("===============================================");
                Console.Write("Please Press Enter to Continue (12 to Quit): ");

                string mainMenuOption = Console.ReadLine();

                if (mainMenuOption == "12")
                {
                    break; // Exit the loop and end the program
                }

                // Ask whether to see ALL or enter a NUMBER (top N results)
                string allOrNumber = GetAllOrNumber();
                if (allOrNumber == "BACK")
                    continue; // If user wants to go back to the main menu, continue

                string limitClause = "";
                if (allOrNumber == "NUMBER")
                {
                    Console.Write("Enter the number N (top N results): ");
                    int N = Convert.ToInt32(Console.ReadLine()); // Get the value for N
                    limitClause = "LIMIT " + N; // Append LIMIT N to the query
                }

                // Display the report menu options
                string option = "";
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("===============================================");
                    Console.WriteLine("1. All countries in the world by population");
                    Console.WriteLine("2. All countries in a continent by population");
                    Console.WriteLine("3. All countries in a region by population");
                    Console.WriteLine("4. All cities in the world by population");
                    Console.WriteLine("5. All cities in a continent by population");
                    Console.WriteLine("6. All cities in a region by population");
                    Console.WriteLine("7. All cities in a country by population");
                    Console.WriteLine("8. All cities in a district by population");
                    Console.WriteLine("9. All capital cities in the world by population");
                    Console.WriteLine("10. All capital cities in a continent by population");
                    Console.WriteLine("11. All capital cities in a region by population");
                    Console.WriteLine("===============================================");
                    Console.Write("Enter an option (1-11) or '12' to quit: ");

                    option = Console.ReadLine();
                    if (option == "12")
                    {
                        break; // Quit from report menu and return to the main menu
                    }

                    string query = "";
                    switch (option)
                    {
                        case "1":
                            query = "SELECT Name, Population FROM country ORDER BY Population DESC " + limitClause;
                            break;
                        case "2":
                            query = "SELECT Name, Population FROM country WHERE Continent = 'Asia' ORDER BY Population DESC " + limitClause;
                            break;
                        case "3":
                            query = "SELECT Name, Population FROM country WHERE Region = 'Southern and Central Asia' ORDER BY Population DESC " + limitClause;
                            break;
                        case "4":
                            query = "SELECT Name, Population FROM city ORDER BY Population DESC " + limitClause;
                            break;
                        case "5":
                            query = "SELECT c.Name, c.Population FROM city c JOIN country co ON c.CountryCode = co.Code WHERE co.Continent = 'Asia' ORDER BY c.Population DESC " + limitClause;
                            break;
                        case "6":
                            query = "SELECT c.Name, c.Population FROM city c JOIN country co ON c.CountryCode = co.Code WHERE co.Region = 'Southern and Central Asia' ORDER BY c.Population DESC " + limitClause;
                            break;
                        case "7":
                            query = "SELECT c.Name, c.Population FROM city c JOIN country co ON c.CountryCode = co.Code WHERE co.Name = 'Afghanistan' ORDER BY c.Population DESC " + limitClause;
                            break;
                        case "8":
                            query = "SELECT Name, Population FROM city WHERE District = 'Zuid-Holland' ORDER BY Population DESC " + limitClause;
                            break;
                        case "9":
                            query = "SELECT c.Name, c.Population FROM city c JOIN country co ON c.CountryCode = co.Code WHERE c.ID = co.Capital ORDER BY c.Population DESC " + limitClause;
                            break;
                        case "10":
                            query = "SELECT c.Name, c.Population FROM city c JOIN country co ON c.CountryCode = co.Code WHERE c.ID = co.Capital AND co.Continent = 'Asia' ORDER BY c.Population DESC " + limitClause;
                            break;
                        case "11":
                            query = "SELECT c.Name, c.Population FROM city c JOIN country co ON c.CountryCode = co.Code WHERE c.ID = co.Capital AND co.Region = 'Southern and Central Asia' ORDER BY c.Population DESC " + limitClause;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            continue;
                    }

                    // Display the report based on the query
                    DisplayReport(query);
                    Console.WriteLine("Press Enter to return to the report menu.");
                    Console.ReadLine(); // Wait for the user to press Enter before returning to the report menu
                }
            }
        }

        // Method to execute the query and display results
        private static void DisplayReport(string query)
        {
            try
            {
                // Open MySQL connection
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                // Loop through and display results
                Console.WriteLine("===============================================");
                Console.WriteLine("Report Generated:");
                Console.WriteLine("===============================================");
                while (reader.Read())
                {
                    // Using string concatenation instead of string interpolation for .NET Framework 4.0
                    Console.WriteLine(reader["Name"] + " - " + reader["Population"]);
                }
                Console.WriteLine("===============================================");

                // Close the reader and connection after use
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Method to ask the user whether they want ALL or Number input for limit
        private static string GetAllOrNumber()
        {
            while (true)
            {
                Console.Write("Do you want to see ALL results or specify a number (ALL/NUMBER)? Enter 'BACK' to return to the main menu: ");
                string allOrNumber = Console.ReadLine().ToUpper();

                if (allOrNumber == "ALL" || allOrNumber == "NUMBER")
                {
                    return allOrNumber; // Return user choice for ALL or NUMBER
                }
                else if (allOrNumber == "BACK")
                {
                    return "BACK"; // Allow the user to go back to the main menu
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'ALL', 'NUMBER', or 'BACK'.");
                }
            }
        }
    }
}
