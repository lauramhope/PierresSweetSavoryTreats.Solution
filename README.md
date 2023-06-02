# Recipe Box App

#### _Web app using C#, EF Core, SQL, and Identity to create and display Pierre's treats_

#### By **Laura Hope**

## Technologies Used

* _Git_
* _C#/.NET version 6.0.402_
* _MySQL Workbench_
* _Enity Framework Core version 6.0.0_
* _ASP.NET Core Identity version 6.0.0_
* _HTML & CSS_
* _Bootstrap version 5.2.3_


## Description
_This is an MVC web application that allows users to store and view information about Pierre's treats. Any user can register for an account and login through ASP.NET Core Identity to create a list of flavors as well as add or update the list of treats. The user can view treats based on what flavors are used or vice versa. If a user attempts to edit or delete a treat or flavor without authentication, they will be redirected to the account registration page._

## Setup/Installation Requirements

* _Clone this repository to your desktop._
* _Open your shell (e.g., Terminal or GitBash) and navigate to this project's production directory at ```./PierresSweetSavoryTreats.Solution/PierresTreats/```._

#### To Configure and Access the Database:
* _Within the production directory "PierresTreats", create a new file called ```appsettings.json```._
* _Within ```appsettings.json```, put the following code, replacing the "uid" and "pwd" values (in the brackets below) with your own username and password for MySQL. Also replace the "database" value with your desired database name._
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE_NAME];uid=[USERNAME];pwd=[PASSWORD];"
  }
}
```
* _Run the terminal command ```dotnet ef database update``` to create the initial MySQL database._

#### To Run the App in the browser:
* _Navigate to this project's production directory named "PierresTreats"._
* _Run ```dotnet watch run``` in the command line to start the application in development mode with a watcher. This will open the webpage in your browser._
* _To exit out of the application, you can use the keyboard command "CTRL+C" on Mac and Windows._
* _Optionally, you can run ```dotnet build``` within the production directory to compile this app without running it._

## Known Bugs

* _No Known Issues as of 6/2/23_

## License

_MIT License_

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

_Copyright (c) 2023 Laura Hope_

_If you run into any issues or have questions, ideas or concerns, please reach out via email: lauramhope.dpt@gmail.com.  Contributions to the code are highly encouraged._