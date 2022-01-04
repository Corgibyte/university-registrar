# _University Registrar System_        

#### By **Hannah Young**
#### By **Christina Welch**

#### encouragement from **Kim Brannian**

![illustration of college degree](./registrar/wwwroot/img/degree.jpg)

#### _A program that tracks Students and Courses for a mock university_

## Technologies Used

* C#
* .net
* ASP.NET Core
* Razor
* CSS
* HTML
* Entity Framework
* SQL

## Description

_A project made during week 4 of Epicodus school that tracks students, courses, and departments for a university. It uses an SQL database to store all of the data._

## Setup/Installation Requirements

* Clone this repository to your Desktop.
* Open university-registrar/registrar in VScode or a code editor of your choice.
* create a new file and name it appsettings.json
* in this file add the following:

```
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=registrar;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
}
```

Note: make sure to replace [YOUR-PASSWORD-HERE] with your password for SQL Workbench.
* type dotnet ef database update into the terminal then type dotnet run

## Known Bugs

you can fill out forms with blank inputs

## License

MIT License

Copyright (c) [2022] [Hannah Young] [Christina Welch]
