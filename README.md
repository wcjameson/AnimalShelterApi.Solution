# AnimalShelterApi

#### An API to keep track of dogs and cats in a shelter

#### By William Jameson

## Technologies Used

* _C#_
* _ASP.NET Core_
* _MySQL_
* _Entity Framework_
* _Swagger_

## Description

_An API that provides a way to keep track of dogs or cats(or any animal) in an animal shelter, by allowing for adding, updating and removing different entries for the animals in the shelter.  It uses RESTful principles, as well as Swagger documentation.

## Setup/Installation Requirements

#### To Install MySQL & MySQL Workbench

* _go to https://dev.mysql.com/downloads/ and install **MySQL Community Server** and **MySQL Workbench** for your operating system_
* _follow the instructions at [learnhowtoprogram](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql) for proper installation_

#### To Set Up Project With Dependencies

* _clone repository from https://github.com/wcjameson/AnimalShelterApi.Solution.git
* _navigate to the project directory in your terminal/command line_
* _navigate to the directory AnimalShelterApi and enter ```dotnet restore``` to install project dependencies_

#### To Create appsettings.json

* _navigate to the directory AnimalShelterApi and create the file ```appsettings.json```_
* _add the following code:_
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR_DATABASE];uid=[YOUR_USER_ID];pwd=[YOUR_PASSWORD];"
  }
}
```
* _replace the applicable sections with your database name, your user ID, and your password_

#### To Create Database using Migrations

* _navigate to the project directory in your terminal/command line_
* _navigate to the directory AnimalShelterApi and enter ```dotnet ef database update``` to create a new local database for the project_
* _the database will take the name specified in your ```appsettings.json``` file and can be viewed using MySQL_

#### To Run the Web Application

* _navigate to the directory AnimalShelterApi and enter ```dotnet run``` for a snapshot server or ```dotnet watch run``` for a live updating server for the application_
* _access the server in your browser by entering ```localhost:5000``` into your navigation bar_

## API Documentation
Explore the API endpoints in Postman or a browser.

### Using Swagger Documentation
To explore the AnimalShelterApi with NSwag, launch the project using ```dotnet run``` with the Terminal or Powershell, and input the following URL into your browser: ```http://localhost:5000/swagger```


## Animals (Endpoints)

Access information about the animals in the shelter.

#### HTTP Request
```
GET /api/animals
POST /api/animals
GET /api/animals/{id}
PUT /api/animals/{id}
DELETE /api/animals/{id}
```
#### Path Parameters

| Parameters     | Type   | Default | Required | Description               |
| -------------  | ------ | ------- | -------- | ------------------------- |
| name           | string | none    | false    | Return matches by name    |
| species        | string | none    | false    | Return matches by species |

#### Example Query
`https://localhost:5000/api/animals/?name=robert&species=dog`

#### Sample JSON Response
`
{
  "Id": 1,
  "Name": "Robert",
  "Species": "Dog"
}
`

## Known Bugs

* _None_

## License

_MIT License_

Copyright (c) _2022_ _William Jameson_ 

## Contact Information
williamjameson90@gmail.com