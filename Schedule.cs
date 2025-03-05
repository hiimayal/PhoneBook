
namespace PhoneBook.Models;

public class Schedule
{
    public List<Contact> Contacts { get; set; }

    public Schedule()
    {
        Contacts = [];
    }

    public void AddContact(int number, string name)
    {
        try
        {
            Contact contact = new Contact(number, name);
            Contacts.Add(contact);
            Console.WriteLine("Contact added!");
        }
        catch
        {
            Console.WriteLine("deu erro caiu no catch");
        }
    }

    public void DelectContact(string name)
    {
        Contact? contact = Contacts.Find(contato => contato.Name == name);
        if (contact == null)
        {
            return;
        }
        Contacts.Remove(contact);
        Console.WriteLine("Contact deleted!");
    }

    public void GetAll()
    {
        foreach (var contact in Contacts)
        {
            contact.ShowContact();
        }
    }

    public void EditContact(string id, string name, int phoneNumber)
    {
        Contact? contact = Contacts.FirstOrDefault(contact => contact.Id == id);
        if (contact == null)
        {
            return;
        }
        contact.EditContact(phoneNumber, name);
        Console.WriteLine("contact edited");
    }
}
