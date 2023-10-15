# _Eau Claire's Salon Web Application_

#### By _**Jordan**_

#### _A web application that helps Eau Claire's Salon manage its stylists and their clients._

## Technologies Used

* _.NET 5.0_
* _ASP.NET Core MVC_
* _Entity Framework Core_
* _Bootstrap_
* _C#_
* _HTML_
* _CSS_

## Description

_Eau Claire's Salon is a web application designed for Claire, the owner, to manage her stylists and their clients. The application provides features to add new stylists, view their details, and associate clients with specific stylists. Each stylist has a unique specialty and each client can only be associated with one stylist._

## Setup/Installation Requirements

* _Ensure .NET SDK and runtime are installed on your machine._
* _Clone this repository to your local machine._
* _Navigate to the HairSalon.Solution directory in your terminal._

<details>
<summary> Recreate the database using the jordan_kennedy.sql file: </summary>


  1. Open your preferred SQL platform (e.g., MySQL Workbench, SQL Server Management Studio).
  2. Create a new database named eauclaire.
  3. Import the jordan_kennedy.sql file into this database to set up the tables and initial data.
  4. Create an appsettings.json file in the HairSalon.Solution/HairSalon directory with the following content (adjust the connection string as needed based on your SQL setup):

### .JSON

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=eauclaire;uid=YOUR_USERNAME;pwd=YOUR_PASSWORD;"
  }
}
```

  5. Replace YOUR_USERNAME and YOUR_PASSWORD with your SQL server's username and password.
  </details>
<br>

* _Run the command `dotnet restore` to install necessary packages._
* _Run the command `dotnet build` to compile the application._
* _Run `dotnet run` to start the server and application._
* _Visit `localhost:5000` in your browser to access the Eau Claire's Salon Web Application._
* _Follow on-screen prompts to manage stylists and their clients._

## User Stories

* _As the salon owner, I can see a list of all stylists._
* _I can select a stylist, see their details, and view a list of all clients that belong to that stylist._
* _I can add new stylists to the system when they are hired._
* _I can add new clients to a specific stylist, ensuring that a client can't be added without an associated stylist._

## Known Bugs

* _No known bugs at the moment._
* _Feel free to report any found issues or bugs._

## License

_Feel free to reach out if you have any concerns, feedback, or wish to make contributions to the code._

Copyright (c) 2023 [Jordan]
