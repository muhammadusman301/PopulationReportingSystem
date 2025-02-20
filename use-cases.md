# Use Cases for Population Reporting System

## Use Case 1: Generate Population Report for Countries

### Preconditions
- The user must be logged into the application.
- The database of countries and their population data must be available.

### Trigger
- The user selects the option to generate a population report for countries.

### Main Flow
1. The user selects the "Generate Population Report for Countries" option.
2. The system queries the database to retrieve country names and their population.
3. The system sorts the countries based on population in descending order.
4. The system generates a report displaying the list of countries with their population.

### Expected Outcome
- The system successfully generates and displays a population report for countries, sorted by population size.

### Exceptions
- If the database is unavailable, an error message is shown.

---

## Use Case 2: Generate Top N Populated Cities

### Preconditions
- The user must be logged into the application.
- The database must have valid city population data.
- The user should be able to specify the number N (Top N cities).

### Trigger
- The user selects the "Generate Top N Populated Cities" option and enters the desired value for N.

### Main Flow
1. The user selects the "Generate Top N Populated Cities" option.
2. The system prompts the user to input the number N (top N cities).
3. The user enters a number, such as 5.
4. The system queries the database to retrieve city names and populations.
5. The system sorts the cities based on population in descending order and retrieves the top N cities.
6. The system displays the top N populated cities in a report format.

### Expected Outcome
- The system displays a list of the top N populated cities.

### Exceptions
- If the user enters an invalid number (non-numeric or zero), the system prompts for valid input.
- If there is an issue retrieving the data, an error message is shown.

---

## Use Case 3: User Login and Authentication

### Preconditions
- The user must have a registered account in the system.
- The user must be on the login page of the application.

### Trigger
- The user navigates to the login page and enters login credentials.

### Main Flow
1. The user navigates to the login page.
2. The system prompts the user to enter a username and password.
3. The user enters valid credentials.
4. The system checks the entered credentials against the database.
5. The system authenticates the user if the credentials match.
6. The user is redirected to the dashboard or home page.

### Expected Outcome
- The user is logged in successfully and redirected to the home page.

### Exceptions
- If the credentials are invalid, the system prompts the user to retry with a message like "Invalid username or password."
- If there is a system error, the user is informed to try again later.

---

## Use Case 4: Admin Modify Country Population Data

### Preconditions
- The user must be logged in as an admin.
- The admin has access to the population management system.

### Trigger
- The admin selects the option to modify a country's population data.

### Main Flow
1. The admin logs in to the system.
2. The admin selects the "Modify Country Population" option.
3. The system prompts the admin to enter the country name.
4. The admin selects the country to modify.
5. The system displays the current population data for that country.
6. The admin modifies the population data and submits the change.
7. The system updates the population data in the database and confirms the update.

### Expected Outcome
- The system successfully updates the population data for the selected country and displays the updated information.

### Exceptions
- If the country name is not found, the system shows an error.
- If the input is invalid (e.g., negative population), the system prompts the admin to enter valid data.

