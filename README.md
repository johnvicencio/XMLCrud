# XMLCrud
Console application about facts repository. You can add a question about a fact of the world and enter an factual answer to it. It uses C# Console application with XML as the database with CRUD. 

# Problem 
Create a C# application that uses a CRUD (Create, Read, Update, and Delete) technique to display, manipulate, and delete data. Use a database that can collect records about facts. A fact has an Id, Question and Answer columns.

# Solution
Build a prototype for a C# application that uses CRUD and an XML file to collect records of facts with Id, Question, and Answer columns. The XML file will be the database; a database is simply a collection of data where one can retrieve and use the data (even when it's robusness isn't on par with other databases like MS SQL Server, MySQL, SQLite, and so on). 

## Psudo Code
1. Create a C# Console (.NET Core) up using Visual Studio
2. Name it XMLCrud
3. Create two classes: Fact (that will holds properties: Id, Question, Answer) and FactController (that handles the logic of the application like CRUD)
4. Create an console input menu for doing various CRUD: 1. Enter data, 2. Display data, 3. Update data, 4. Delete data, 0. To exit the application
5. Use an XML file: every records saved are serialized and deserialized when read. 

## What is XML?
XML formats data into a hierarchy and represents data that it holds. HTML also has elmenets into a hierarchy that represents data. But XML describes the content rather than desribes the content. The XML 'file' is itself 'the database' in this case, because it has the data (each record has Id, Question, and Answer). 

## Working with the application
1. Run the application
2. A terminal window will show a menu to select
3. Enter or follow the instruction on the screen
4. Press 0 to exit the applicaiton 
