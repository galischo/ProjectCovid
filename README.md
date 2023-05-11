# ProjectCovid
ProjectCovid
This is a project developed in ASP.NET Core Web Application using the 4-layer Entity Framework
method and Swagger for API documentation.
The project is actually a system for managing the Corona database for a health fund.
The project was built with:
Visual Studio 2022
NET Core
Sql Server
To run the project, follow these steps:
   Clone the repository to your local machine.
   Open the solution file (.sln) in Visual Studio.
   Configure the database connection string in the appsettings.json file with your SQL Server details.
   Open the Package Manager Console and run the following command to create the database:Update-Database
   Run the application.
The project follows the 4-layer Entity Framework method, which separates the application into the following layers:
-ENTITY 
There we defined the database schema using the following classes:
Patient
Corona
In the PATIENT department, we kept all the details of the insured in the HMO
And in the Corona department, we kept the vaccination data there for the insured
-Dto layer
This layer is Object Transfer Data which reflects the entities in the layer
The Entity authentication interactions are these classes in the Dto layer which are:
PatientDto
CoronaDto
These classes will be used to transfer data between the layers.
-Dal layer
This is a data access layer:
And it implements the data access logic to interact with the database.
Includes functions to perform CRUD operations on tables,
such as withdrawing users and patients or introducing a new vaccine and so on.
-Bll layer
Business logic layer.
Implementation of business logic that operates on the data extracted from the Dal layer
Performing verifications, calculations and any complex operation related to the business rules of
the system.
-Controller layer
This is the controller layer (API)
In this layer the HTTP requests are made, it maps the requests
to the functions within the appropriate BLL and returning a response to the client.
HTTP requests:
Patient:
- GET 
  returns a list of all patients.
- GET {id}
  returns a specific patient by ID.
- POST 
  creates a new patient.
Corona:
- GET 
  returns vaccination details.
- GET {id}
   returns vaccination details for a specific patient- POST /api/covid
 - POST {id}
   creates a new vaccine for a specific patient
  also I created validations and maintaining all the conditions
