string folderPath = @"C:\C#\dasdsadsad";
string fileName = "shoppingList.txt";
string filePath = Path.Combine(folderPath, fileName);
List<string> myShoppingList = new List<string>();
if (File.Exists(filePath))
{
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}
else
{
    File.Create(filePath).Close();
    Console.WriteLine($"File {fileName} has been created.");
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}

static List<string> GetItemsFromUser()
{


    List<string> userList = new List<string>();

    while (true)
    {
        Console.WriteLine("Add item (add)/ Exit (exit): ");
        string usercoise = Console.ReadLine();

        if (usercoise == "add")
        {
            Console.WriteLine("Enter an item: ");
            string useritem = Console.ReadLine();
            userList.Add(useritem);
        }
        else
        {
            Console.WriteLine("Bye!");
            break;

        }
    }
    return userList;
}

static void ShowItemsFromList(List<string> someList)
{

    int listlenght = someList.Count;
    Console.WriteLine($"You have added {listlenght} items to your shopping list");

    int i = 1;
    foreach (string item in someList)
    {
        Console.WriteLine($"{i}. {item}");
        i++;
    }


}