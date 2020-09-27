# C# Object-Orientated Programming

Entity Framework Solution Setup From Existing Database.
- The goal of this assignment is to be familiarized with the fundementals of importing a databse to C# using Entity Framework.
- The scenario for this assignment is to build an exising database using MySQL and MariaDB and then building C# sever later. 

## Installation

```bash
$ git clone https://github.com/jia-von/entity-framework-solution-setup-from-existing-database.git
$ cd entity-framework-solution-setup-from-existing-database-jia-von
$ cd ExistingDBPractice
$ start devenv ExistingDBPractice.sln
````
- Use the NuGet Package Manager to install Entity Framework [ASP.NET Core](https://docs.microsoft.com/en-us/ef/core/get-started/?tabs=netcore-cli).
- Second package to install is [Pomelo Entity Framework Core](https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql) provider. 

```bash
PM> dotnet add package Microsoft.EntityFrameworkCore.Design
PM> dotnet add package Pomelo.EntityFrameworkCore.MySQL
```

## Usage/Approach

- The database was populated in [PHPMyAdmin](https://www.phpmyadmin.net/) using a SQL script. The database is named `existing_db_practice`.
- The database contains two tables `Person` and `PhoneNumber`.
- A `PersonContext.cs` model was created and configured to target models `Person.cs` and `PhoneNumber.cs` and the relational database. 
- A simple program was written to take the first name from the user and then to pring the full name of the user from the database. 
