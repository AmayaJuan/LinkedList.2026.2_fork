using Backend;

var list = new DoublyLinkedList<string>();//new SinglyLinkendList<string>();
var option = string.Empty;

do
{
    option = Menu();
    switch (option)
    {
        case "1":
            Console.Write("Enter value: ");
            list.InsertAtBeginning(Console.ReadLine()!);
            break;
        case "2":
            Console.Write("Enter value: ");
            list.InsertAtEnd(Console.ReadLine()!);
            break;
        case "3":
            Console.Write("Enter value: ");
            var itemToSearch = Console.ReadLine()!;
            Console.WriteLine(list.Contains(itemToSearch) 
                ? $"The item: '{itemToSearch}' exists!" 
                : $"The item: '{itemToSearch}' doesn't exists!");
            break;
        case "4":
            Console.Write("Enter value: ");
            var itemToRemove = Console.ReadLine()!;
            if (!list.Contains(itemToRemove))
            {
                Console.WriteLine($"The item: '{itemToRemove}' not exists in the list.");
                break;
            }
            list.Remove(itemToRemove);
            Console.WriteLine($"The item: '{itemToRemove}' removed.");
            break;
        case "5":
            //list.Reverse();
            Console.WriteLine("List reversed.");
            break;
        case "6":
            Console.Write("Enter the previous value: ");
            var previous = Console.ReadLine() ?? "";

            Console.Write("Enter the new value: ");
            var value = Console.ReadLine() ?? "";

            /*Console.WriteLine(list.InsertAfter(previous, value)
                ? "Element inserted."
                : "Prevous element not found or item already exists.");*/
            break;
        case "7":
            //list.Order();
            Console.WriteLine("List ordered alphabetically.");
            break;
        case "8":
            Console.WriteLine(list);
            break;
        case "9":
            Console.WriteLine(list.ToStringReverse());
            break;
        case "0":
            Console.WriteLine("Goobye!");
            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }
} while (option != "0");

string Menu()
{
    Console.WriteLine("1. Insert at begining.");
    Console.WriteLine("2. Insert at end.");
    Console.WriteLine("3. Contains.");
    Console.WriteLine("4. Remove.");
    Console.WriteLine("5. Reverse.");
    Console.WriteLine("6. Insert.");
    Console.WriteLine("7. Order.");
    Console.WriteLine("8. Show list.");
    Console.WriteLine("9. Show reverse list.");
    Console.WriteLine("0. Exit.");
    Console.Write("Emter your option? ");
    return Console.ReadLine()!;

}