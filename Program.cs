using PhoneBook.Models;

try
{
    Schedule schedule = new Schedule();
    do
    {
        Console.Clear();
        Menu();
    } while (true);

    void Menu()
    {
        Console.WriteLine("Welcome to your schedule!");
        Console.WriteLine("1 - List of Contacts");
        Console.WriteLine("2 - Add Contact");
        Console.WriteLine("3 - Edit Contact");
        Console.WriteLine("4 - Delect Contact");
        Console.WriteLine("----------------");
        short option = short.Parse(Console.ReadLine());

        string name;

        switch (option)
        {
            case 1:
                Console.Clear();
                schedule.GetAll();
                Console.ReadLine();
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Write the contact´s name: ");
                name = Console.ReadLine();
                Console.WriteLine("Write the contact´s number: ");
                int number = int.Parse(Console.ReadLine());
                schedule.AddContact(number, name);
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("write the contacts id: ");
                var id = Console.ReadLine();
                Console.WriteLine("Write the new contact´s name: ");
                var newName = Console.ReadLine();
                Console.WriteLine("Write the new contact´s number: ");
                int newPhoneNumber = int.Parse(Console.ReadLine());
                schedule.EditContact(id, newName, newPhoneNumber);
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("Write the contact´s name you want to delect: ");
                name = Console.ReadLine();
                schedule.DelectContact(name);
                break;
        }
    }
}
catch (Exception e)
{
    Console.WriteLine("Aconteceu um erro inesperado no aplicativo");
    Thread.Sleep(3000);
    Console.WriteLine("Reiniciando...");
    Thread.Sleep(3000);
}
