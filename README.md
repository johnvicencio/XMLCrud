# XMLCrud
This is a console application that serves as a facts repository. Users can add a question about a fact of the world and enter a factual answer to it. The application uses C# Console application with XML as the database with CRUD (Create, Read, Update, and Delete) operations.

# Problem 
The task is to develop a C# application that utilizes CRUD operations to display, manipulate, and delete data. The application should use a database to store records about facts. Each fact should have an Id, Question, and Answer column.

# Solution
To solve this problem, a prototype C# application was developed that uses CRUD operations and an XML file to store facts records. The application consists of two classes: Fact (which holds properties like Id, Question, and Answer) and FactController (which handles the logic of the application like CRUD operations). A console input menu was also created to allow for various CRUD operations, including entering data, displaying data, updating data, deleting data, and exiting the application.

The application uses an XML file as its database. Each record saved is serialized and deserialized when read. Although an XML database may not have the same robustness as other databases like MS SQL Server, MySQL, SQLite, it serves the purpose for this application.

## Pseudo Code
1. Create a C# Console (.NET Core) up using Visual Studio.
2. Name the application XMLCrud.
3. Create two classes: Fact (that holds properties: Id, Question, Answer) and FactController (that handles the logic of the application like CRUD).
4. Create a console input menu for various CRUD operations: 1. Enter data, 2. Display data, 3. Update data, 4. Delete data, 0. To exit the application.
5. Use an XML file as the database. Every record saved is serialized and deserialized when read.

## What is XML?
XML is an acronym for Extensible Markup Language, a markup language that structures data into a hierarchy and represents the information it contains. Unlike HTML, which also has elements that arrange data hierarchically, XML describes the content rather than its presentation. In this application, the XML file serves as the database because it contains the data for each record, including the Id, Question, and Answer. However, in reality, even a JSON file or a plain text file that organizes data in a meaningful way can also serve as a database.
## Using the application
1. Run the application.
2. A terminal window will show a menu for selection.
3. Follow the instructions on the screen to perform various CRUD operations.
4. Press 0 to exit the application.