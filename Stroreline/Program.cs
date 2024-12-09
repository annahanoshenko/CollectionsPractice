//List<string> nameString = new List<string>() { "Alice", "Brad", "Jack", "Samanta" };
//List<int> agelist = new List<int>() { 20, 31, 50, 15 };
//List<int> productCount = new List<int>() { 12, 4, 1, 6 };

using StroreLine;

Customer customer1 = new Customer();

List<Customer> customers = new List<Customer>()
{
   new Customer {Name = "Alice", Age = 31, ItemsInCart = 12 },
   new Customer {Name = "Brad", Age = 20, ItemsInCart = 4},
   new Customer {Name = "Jack", Age = 50, ItemsInCart = 1},
   new Customer {Name = "Samanta", Age = 15, ItemsInCart = 6},
};

foreach (var customer in customers)
{
    Console.WriteLine($"Initial list: {customer}");
}

customers.Sort();
customers.Sort((x, y) => x.Age.CompareTo(y.Age));
Console.WriteLine("\nSorted by Age:");

customers.Sort((x, y) => x.Age.CompareTo(y.Age));
Console.WriteLine("\nSorted by Age:");
PrintCustomers(customers);

// 2. Знаходимо покупця з найбільшою кількістю товарів
var maxItemsCustomer = customers.OrderByDescending(c => c.ItemsInCart).FirstOrDefault();
Console.WriteLine($"\nCustomer with the most items: {maxItemsCustomer}");

// 3. Видаляємо покупця з найменшою кількістю товарів
var minItemsCustomer = customers.OrderBy(c => c.ItemsInCart).FirstOrDefault();
if (minItemsCustomer != null)
{
    customers.Remove(minItemsCustomer);
}
Console.WriteLine("\nList after removing customer with the least items:");
PrintCustomers(customers);

// 4. Переносимо дані до LinkedList
LinkedList<Customer> customerQueue = new LinkedList<Customer>(customers);

// Додаємо VIP-клієнта в початок черги
var vipCustomer = new Customer { Name = "VIP John", Age = 50, ItemsInCart = 8 };
customerQueue.AddFirst(vipCustomer);
Console.WriteLine("\nQueue after adding VIP customer:");
PrintQueue(customerQueue);

// Обробляємо (видаляємо) перших трьох покупців
for (int i = 0; i < 3; i++)
{
    if (customerQueue.First != null)
    {
        customerQueue.RemoveFirst();
    }
}
Console.WriteLine("\nQueue after processing (removing) first three customers:");
PrintQueue(customerQueue);

// Додаємо нового клієнта в кінець черги
var newCustomer = new Customer { Name = "New Customer Jane", Age = 28, ItemsInCart = 4 };
customerQueue.AddLast(newCustomer);
Console.WriteLine("\nQueue after adding new customer at the end:");
PrintQueue(customerQueue);


    static void PrintCustomers(List<Customer> customers)
{
    foreach (var customer in customers)
    {
        Console.WriteLine(customer);
    }
}

static void PrintQueue(LinkedList<Customer> queue)
{
    foreach (var customer in queue)
    {
        Console.WriteLine(customer);
    }
}
    
