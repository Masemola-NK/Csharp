# Overview 
---
A modern ASP.NET MVC application demonstrating complete CRUD operations (Create, Read, Update, Delete),
using C# and SQL Server stored procedures. This repository highlights how to integrate SQL Server Management Studio (SSMS) with Visual Studio to build scalable, enterprise‑grade applications.

---
### 🔑 Why Stored Procedures?
Stored procedures in SQL Server provide###:

- 📈Performance optimization by pre‑compiled execution plans 
- Security through parameterized queries, reducing SQL injection risks🛡️
- Maintainability by centralizing business logic in the database layer📝 
- 🛠️ Scalability for enterprise applications with complex transactions



- 💻 In the creation of this database I made use of SQL Server Managament Studio
- ⚙️ I made a local server which has been indicate on the [###place for the location should be attached with database string ###]([www.example.com](https://github.com/Masemola-NK/Csharp/blob/main/CRUD%26SQL/C%23_FrontEnd/CRUD%20stored%20procedures/CRUD%20stored%20procedures/Form1.cs))
  
-Note the schame the front will respond to once connected below
- ### Create the table schema
  CREATE TABLE EmpTest_Tab (
    Emp_ID INT PRIMARY KEY,             -- Employee ID
    Emp_Name NVARCHAR(50) NOT NULL,     -- Employee Name
    City NVARCHAR(50),                  -- City
    Age FLOAT,                          -- Age
    Sex NVARCHAR(20),                   -- Gender
    JoiningDate DATETIME,               -- Date of Joining
    Contact NVARCHAR(50)                -- Contact Info
); ###
