
Dictionary<int,List<Contact>> dict = new Dictionary<int,List<Contact>>();

while (true)
{
    Console.WriteLine("1.Создать контакт\n2.Удалить контакт\n3.Показать контакт\n4.Изменить контакт\n5.Выход");
    Console.Write("Ведите команду: ");

    string com = Console.ReadLine();

    switch (com)
    {
        case "1":
            CreateContact();
            break;

        case "2":
            DeleteContact();
            break;

        case "3":
            ViewContact();
            break;

        case "4":
            ChangeContact();
            break;

        case "5":
            return;

        default:
            Console.WriteLine("Не верная команда. Попробуйте еще раз.\n");
            break;
    }
}
void CreateContact()
{
    Console.Clear();

    Console.Write("Ведите имя: ");
    string name = Console.ReadLine();

    Console.Write("Ведите номер телефона: ");
    string phone = Console.ReadLine();

    Contact contact = new Contact(name,phone);
    var key = GetHash(name);
    if(!dict.ContainsKey(key))
    {
        dict.Add(key, new List<Contact>());
    }
    dict[key].Add(contact);
    Console.Clear();
}
void DeleteContact()
{
    Console.Clear();

    Console.Write("Введите имя: ");
    string name = Console.ReadLine();
    var key = GetHash(name);
    if (dict.ContainsKey(key))
    {
        for (int i = 0; i < dict[key].Count; i++)
        {
            if (dict[key][i].name == name)
            {
                Console.WriteLine($"Удалить {dict[key][i].name} - {dict[key][i].phone}\n1 - да\n2 - нет");
                string com = Console.ReadLine();

                switch (com)
                {
                    case "1":
                        dict[key].Remove(dict[key][i]);
                        break;

                    default:
                        break;
                }
            }

        }
    }
    Console.Clear();
}
void ViewContact()
{
    Console.Clear();

    Console.Write("Введите имя: ");
    string name = Console.ReadLine();
    var key = GetHash(name);
    if (dict.ContainsKey(key))
    {
        for (int i = 0; i < dict[key].Count; i++)
        {
            if (dict[key][i].name == name)
            {
                Console.WriteLine($"{dict[key][i].name} - {dict[key][i].phone}\n");
            }

        }
    }
}
void ChangeContact()
{
    Console.Clear();

    Console.Write("Введите имя: ");
    string name = Console.ReadLine();
    var key = GetHash(name);
    if (dict.ContainsKey(key))
    {
        for (int i = 0; i < dict[key].Count; i++)
        {
            if (dict[key][i].name == name)
            {
                Console.WriteLine($"{dict[key][i].name} - {dict[key][i].phone}\n");
                Console.Write("Введите новый номер телефона: ");
                string newPhone = Console.ReadLine();
                dict[key][i].phone = newPhone;
            }

        }
    }
    Console.Clear();
}
int GetHash(string s)
{
    var hash = 13;
    hash = hash * 8 + s.GetHashCode();
    return hash;
}
class Contact
{
    public string name;
    public string phone;

    public Contact(string Name, string Phone)
    {
        name = Name;
        phone = Phone;
    }
    
}


    

