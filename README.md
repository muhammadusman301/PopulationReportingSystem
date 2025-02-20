# Population Reporting System

## Overview
The **Population Reporting System** is a C# based application that allows users to access and report on population data from a world database. The system retrieves and displays population statistics, including countries, cities, and capital cities, sorted by population. The system also includes functionality for generating specific reports based on user requests.

## Project Details

### Project Objective
To design and implement a system using **C#** and **MySQL** to generate reports about world population data, such as:
- Countries, cities, and capital cities organized by population.
- Top N populated countries, cities, and capital cities (user-defined N).
- Population breakdown by continent, region, country, and city.
- Language speaker statistics for major languages like Chinese, English, and Spanish.

### System Requirements
1. **Report Generation**:
    - Generate reports of countries, cities, and capitals sorted by population.
    - Generate top N reports for countries, cities, and capitals, where N is provided by the user.
    - Provide population breakdowns for various levels such as continent, region, country, and city.

2. **Language Speaker Statistics**:
    - Report on the population of people who speak the following languages:
        - Chinese
        - English
        - Hindi
        - Spanish
        - Arabic

3. **Data Access**:
    - Access population data for the world, continents, regions, countries, districts, and cities.
    - Population data for people living in cities and those not living in cities.

4. **Report Columns**:
    - **Country Report**: Code, Name, Continent, Region, Population, Capital.
    - **City Report**: Name, Country, District, Population.
    - **Capital City Report**: Name, Country, Population.
    - **Population Report**: Continent/Region/Country name, Total population, Population living in cities, Population not living in cities.

### System Implementation

This system has been built using **C#** as the primary programming language, with **MySQL** as the database backend. The database is used to store the world population data, and the C# application queries this data to generate reports.

### Key Features:
- **Query-based Reports**: Users can request population reports sorted by population, and also request the top N populated countries or cities.
- **User Input for N**: Users can define how many top results they want to view in reports.
- **City/Population Breakdown**: Provides insights into population statistics across various regions and countries.

### Installation and Setup

1. Clone this repository to your local machine using:
    ```bash
    git clone https://github.com/username/PopulationReportingSystem.git
    ```

2. Open the project in **Visual Studio** or your preferred C# IDE.

3. Make sure you have **MySQL** installed and set up the provided world database. The schema and structure are provided as part of the project.

4. Build and run the application from your IDE or the command line.

### Usage
- After running the application, the user will be presented with a menu to choose between generating different reports.
- Reports can be viewed by selecting the desired option. Options include:
    - All countries, cities, and capitals sorted by population.
    - The top N populated countries, cities, and capitals, where N is defined by the user.
  
### GitHub Actions and CI/CD
- GitHub Actions workflows have been implemented to automate the build process and run tests on each commit.
- The workflows ensure that code is automatically built and tested before merging into the main branch.

### Contribution Guidelines
- Fork the repository to contribute.
- Create a feature branch for new features or fixes (`feature/your-feature-name` or `bugfix/your-bugfix-name`).
- Open a pull request with a description of the changes and why they are being made.

### Code of Conduct
We expect all contributors to follow our Code of Conduct in order to foster a positive and inclusive environment for all team members.

---

## Project Contributors
- **Product Owner**: Responsible for defining the system requirements and prioritizing tasks.
- **Scrum Master**: Facilitates the Scrum process, removes obstacles, and helps keep the team on track.
- **Development Team**: Works on the implementation of features and reports according to the requirements defined by the Product Owner.

---

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

