# Student-Registration-System-.NET-MVC-Web-Application-with-Data-Annotations
MVC web application built with the .NET Framework and Entity Framework that demonstrates how to use Data Annotations for validation in a model-driven application.

The project manages student records while ensuring data integrity through built-in validation attributes such as:

[Required] – Ensures that fields like StudentName, DateOfBirth, and UserName must be filled.
[StringLength] – Restricts the length of StudentName and UserName.
[Range] – Validates that StudentAge falls between 18 and 25.
[RegularExpression] – Ensures a valid email format for EmailID.
[Compare] – Confirms that RetypePassword matches Password.
[DataType] – Specifies password field formatting.

The backend is powered by Entity Framework DbContext, and data is stored in a SQL Server database via the configured connection string in web.config.

Features
Add new student records with validation.
View student details.
Edit and update student information.
Delete student records.
Automatic validation using Data Annotations.
