using System;
using System.Xml.Serialization;

public class FactController
{
    private readonly string _xmlFilePath;
    private readonly XmlSerializer _xmlSerializer;

    public FactController(string xmlFilePath)
    {
        _xmlFilePath = xmlFilePath;
        _xmlSerializer = new XmlSerializer(typeof(List<Fact>));
    }

    public void Create(Fact fact)
    {
        var facts = GetAll();
        fact.Id = facts.Count + 1;
        facts.Add(fact);
        Save(facts);
    }

    public List<Fact> GetAll()
    {
        if (!File.Exists(_xmlFilePath)) return new List<Fact>();

        using var reader = new StreamReader(_xmlFilePath);
        return (List<Fact>)_xmlSerializer.Deserialize(reader);
    }

    public void Update(Fact fact)
    {
        var facts = GetAll();
        var index = facts.FindIndex(p => p.Id == fact.Id);

        if (index >= 0)
        {
            facts[index] = fact;
            Save(facts);
        }
        else
        {
            Console.WriteLine($"Fact with ID {fact.Id} not found.");
        }
    }

    public void Delete(int id)
    {
        var facts = GetAll();
        var index = facts.FindIndex(p => p.Id == id);

        if (index >= 0)
        {
            facts.RemoveAt(index);
            Save(facts);
        }
        else
        {
            Console.WriteLine($"Fact with ID {id} not found.");
        }
    }

    private void Save(List<Fact> facts)
    {
        using var writer = new StreamWriter(_xmlFilePath);
        _xmlSerializer.Serialize(writer, facts);
        writer.Flush();
        writer.Close();
    }
}


