In this project, I implemented crud operation on employee. In this project I use c# for api and controllers.
In this user can create,edit ,delete the user. Also user can search the employee according to filters.
In this implemented all filter like - firstname, middlename, surname, start date, end date, country, city, address line.

This project contain, 
controllers -> where code of all action performed by api is implemented.
Models -> where code of Employee modal(schema) is implemented.
View -> where code frontend or ui of is implemented.
DBfirst contain version of .net and other dependencies require for this project.
appsetting.json contain information regarding database connection.

How to Run-->
1. first clone the repositry.
2. Then download dependencies. see in DBfirst.
3. also download sql server and ssms for connection of database.
4. Go to ssms connect with sql server and then make table in database according to model or schema present in models/employee.cs .
5. replace "Server=DESKTOP-EL3SELA\\SQLEXPRESS;Database=Demo1;Trusted_Connection=True;" with you sql server and database. This line present in appsetting.json.
6. after downloading all dependencies and connect with database.Run the command in terminal.
7. Command is --> dotnet run
