using System.Net;
using System.Xml;
using System.Xml.Linq;
using System.IO;

// Create a FactController with the XML file path
var factController = new FactController("facts.xml");

// Display menu options until user exits
while (true)
{
    Console.WriteLine("Select an option:");
    Console.WriteLine("1. Add a fact");
    Console.WriteLine("2. Display all facts");
    Console.WriteLine("3. Update a fact");
    Console.WriteLine("4. Delete a fact");
    Console.WriteLine("0. Exit");

    // Get user input
    int option;
    while (!int.TryParse(Console.ReadLine(), out option))
    {
        Console.WriteLine("Invalid input. Please enter a number.");
    }

    // Perform selected action
    switch (option)
    {
        case 0:
            return;
        case 1:
            // Get user input for new fact
            Console.WriteLine("Enter a new fact in form of a question:");
            string question = Console.ReadLine();
            Console.WriteLine("Enter a new fact answer to the question:");
            string answer = Console.ReadLine();

            Fact newFact = new Fact { Question = question, Answer = answer };

            // Add fact to XML file database
            factController.Create(newFact);
            Console.WriteLine("Fact added successfully.");
            break;
        case 2:
            // Display all facts
            List<Fact> allFacts = factController.GetAll();
            Console.WriteLine($"There are {allFacts.Count} facts in the database:");
            foreach (var fact in allFacts)
            {
                Console.WriteLine($"ID: {fact.Id}, Question: {fact.Question} Answer: {fact.Answer}");
            }
            break;
        case 3:
            // Get user input for fact to update
            Console.WriteLine("Enter the ID of the fact to update:");
            int updateId;
            while (!int.TryParse(Console.ReadLine(), out updateId))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            Fact updateFact = factController.GetAll().FirstOrDefault(f => f.Id == updateId);

            if (updateFact != null)
            {
                // Get user input for new fact text
                Console.WriteLine("Select 1: Update the question or 2: Update the answer");
                string select = Console.ReadLine();
                if (select == "1")
                {
                    Console.WriteLine("Update the question:");
                    string newQuestion = Console.ReadLine();
                    updateFact.Question = newQuestion;
                    // Update fact in XML file database
                    factController.Update(updateFact);
                    Console.WriteLine("Fact Question updated successfully.");
                }
                else
                {
                    Console.WriteLine("Update the answer");
                    string newAnswer = Console.ReadLine();
                    updateFact.Answer = newAnswer;
                    // Update fact in XML file database
                    factController.Update(updateFact);
                    Console.WriteLine("Fact Answer updated successfully.");
                }
                
            }
            else
            {
                Console.WriteLine($"Fact with ID {updateId} not found.");
            }
            break;
        case 4:
            // Get user input for fact to delete
            Console.WriteLine("Enter the ID of the fact to delete:");
            int deleteId;
            while (!int.TryParse(Console.ReadLine(), out deleteId))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            // Delete fact from XML file database
            factController.Delete(deleteId);
            Console.WriteLine("Fact deleted successfully.");
            break;
        default:
            Console.WriteLine("Invalid option. Please enter a number between 0 and 4.");
            break;
    }

    // Wait for user to press a key before clearing console and displaying menu again
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();
}