using Backend;

var list = new SinglyLinkendList<string>();
var option = string.Empty;

do
{
    option = Menu();
    switch (option)
    {
        case "1":
            Console.Write("Enter value: ");
            var itemBeginnig = Console.ReadLine() ?? "";
            Console.WriteLine(list.InsertAtBeginning(itemBeginnig) ? $"Item{itemBeginnig} inserted." : $"This item {itemBeginnig} already exists.");
            break;
        case "2":
            Console.Write("Enter value: ");
            var itemEnd = Console.ReadLine() ?? "";
            Console.WriteLine(list.InsertAtEnd(itemEnd) ? $"Item {itemEnd} inserted." : $"This item {itemEnd} already exists");
            break;

        case "3":
            Console.Write("Enter value to search: ");
            var itemSearch = Console.ReadLine() ?? "";
            Console.WriteLine(list.Contains(itemSearch) ? $"Item {itemSearch} found." : $"Item {itemSearch} not found.");
            break;
        case "4":
            Console.Write("Enter value to remove: ");
            var itemRemove = Console.ReadLine() ?? "";
            Console.WriteLine(list.Remove(itemRemove) ? $"Item {itemRemove} removed." : $"Item {itemRemove} not found.");
            break;
        case "5":
            list.Reverse();
            Console.WriteLine("List reversed.");
            break;
        case "6":
            Console.Write("Enter the previous value: ");
            var previous = Console.ReadLine() ?? "";

            Console.Write("Enter the new value: ");
            var value = Console.ReadLine() ?? "";

            Console.WriteLine(list.InsertAfter(previous, value)
                ? "Element inserted."
                : "Prevous element not found or item already exists.");
            break;

        case "7":
            list.Order();
            Console.WriteLine("List ordered alphabetically.");
            break;
        case "8":
            Console.WriteLine(list);
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
    Console.WriteLine("0. Exit.");
    Console.Write("Emter your option? ");
    return Console.ReadLine()!;

}