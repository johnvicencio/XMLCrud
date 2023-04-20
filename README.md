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

## Use Cases That Can Be Applied to Other GUIs Besides Command Line Apps (Web, Mobile, Desktop)
- Web Application: Create a blog page with an Id, Title, and Body fields. Store the content in a database (XML, JSON, or more robust databases such as MySQL or MS SQL Server). Now, you can display, create, update, and delete blog articles.
- Web API Application: Create an API version of the above example (a headless Blog CMS, perhaps).
- Mobile Application: Create an iOS or Android GUI interface that utilizes an API to manage blog articles.
- Desktop Application: Develop a Windows or Mac version of a Blog Manager that uses an API version for handling CRUD backend operations. application: Create a Windows or Mac version as a Blog Manager that uses an API version for handling the backend opoerations of the CRUD
- Chatbot application: Create a chatbot interface that allows users to query and manage blog articles using a conversational interface. The chatbot can use an API to communicate with the backend system that manages the blog content.
- Voice assistant application: Create a voice assistant application that allows users to interact with blog articles using voice commands. For example, users can ask the voice assistant to read a blog post, create a new post, or update an existing post.
- Smartwatch application: Create a smartwatch application that displays the latest blog articles and allows users to read, save, and share them. The smartwatch can use an API to fetch the latest content from the backend system.
- Augmented reality (AR) application: Create an AR application that overlays information about blog articles onto real-world objects. For example, users can point their smartphone camera at a poster or a magazine and see related blog posts displayed on their screen.
- Virtual reality (VR) application: Create a VR application that allows users to immerse themselves in the blog content. For example, users can explore a virtual environment that showcases blog articles in an interactive and engaging way.