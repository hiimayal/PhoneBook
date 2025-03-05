
namespace PhoneBook.Models;

public class Contact
{
    public string Id;
    public string Name;
    public int PhoneNumber;

    public Contact(int phoneNumber, string name)
    {
        if (phoneNumber < 30000000)
        {
            throw new Exception("number invalid");
        }
        if (string.IsNullOrEmpty(name))
        {
            throw new Exception("name invalid");
        }
        Id = Guid.NewGuid().ToString().Substring(0, 4);
        PhoneNumber = phoneNumber;
        Name = name;
    }

    public void EditContact(int? newPhoneNumber, string? newName)
    {
        if (newPhoneNumber < 30000000)
        {
            throw new Exception("number invalid");
        }
        if (string.IsNullOrEmpty(newName))
        {
            throw new Exception("name invalid");
        }
        PhoneNumber = newPhoneNumber ?? PhoneNumber;
        Name = newName ?? Name;
    }

    public void ShowContact()
    {
        Console.WriteLine($"ID: {Id}\nNAME: {Name}\nPHONENUMBER:{PhoneNumber}");
    }
}
