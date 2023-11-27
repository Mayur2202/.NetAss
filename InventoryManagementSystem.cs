class Item
{
    public int ID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    
        public Item(int Id,string name,double price,int quantity)
    {
        ID = Id;
        Name = name;
        Price = price;
        Quantity = quantity;
    }


}
class Inventory
{
    public List<Item> product = new List<Item> ();
   

   public Inventory()
    {
        List<Item> product=new List<Item>();
    }

    public void AddItem(Item item)
    {
        product.Add(item: item);
    }

    public void DisplayAllItems()
    {
        if (product.Count == 0)
        {
            Console.WriteLine("empty Inventory. ");
        }
        else
        {
            Console.WriteLine("Items in Inventory:");
            foreach (var item in product)
            {
                Console.WriteLine($"ID: {item.ID}");
                Console.WriteLine($"Item Name is:{item.Name}");
                Console.WriteLine($"Item Price:{item.Price}");
                Console.WriteLine($"Item Quantity:{item.Quantity}");
            }
        }
    }

    public Item FindItemByID(int id)
    {
        return product.Find(item => item.ID == id);
    }

    public void UpdateItem(int id, string name, double price, int quantity)
    {
        var item = product.Find(i => i.ID == id);
        if (item != null)
        {
            item.Name = name;
            item.Price = price;
            item.Quantity = quantity;
        }
        else
        {
            Console.WriteLine("Item is not found");
        }
    }


    public void DeleteItem(int id)
    {
        var item = product.Find(i => i.ID == id);
        if (item != null)
        {
            product.Remove(item);
        }
        else
        {
            Console.WriteLine("Item not found");
        }

    }

   

    class program
{
   public static void Main()
    {
        var inventory = new Inventory();

        while (true)
        {
            Console.WriteLine("\"Inventory Management System\"");
            Console.WriteLine("1. Add new item");
            Console.WriteLine("2. Display all items");
            Console.WriteLine("3. Find an item by ID");
            Console.WriteLine("4. Update an item's information");
            Console.WriteLine("5. Delete an item");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your Number: ");
            int number = int.Parse(Console.ReadLine());
            switch(number)
            {
                case 1:
                    AddItem(inventory);
                    break;
                case 2:
                    inventory.DisplayAllItems();
                    break;
                case 3:
                    FindItemByID(inventory);
                    break;
                case 4:
                    UpdateItem(inventory);
                    break;
                case 5:
                        DeleteItem(inventory);
                        break;
                case 6:
                        Environment.Exit(0);
                        break;
                    default:
                       Console.WriteLine("enter only the no.");
                        break;



            }

             

        }
           static void AddItem(Inventory inventory)
            {
                Console.WriteLine("Add item .");
                Console.Write("Enter a Id:");
                int Id =int.Parse(Console.ReadLine());
                Console.Write("Enter a item name:");
                string Name = Console.ReadLine();
                Console.Write("Enter a price:");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Enter a Quantity:");
                int quantity = int.Parse(Console.ReadLine());

                inventory.AddItem(new Item (Id,Name,price,quantity));
                Console.WriteLine("Item added succefully");

                

            }
            static void FindItemByID(Inventory inventory)
            {
                Console.WriteLine("Enter a id :");
                int id = int.Parse(Console.ReadLine());

                Item Id = inventory.FindItemByID(id);
                if(id !=null)
                {
                    Console.WriteLine($"item Id:{Id.ID}");
                    Console.WriteLine($"item Name :{Id.Name }");
                    Console.WriteLine($"Item Price:{Id.Price}");
                    Console.WriteLine($"Item Quantity:{Id.Quantity}");

                    Console.WriteLine("Item finded succefully.");
                }
                else
                {
                    Console.WriteLine("ID is not found");
                }

            }
            static void UpdateItem(Inventory inventory)
            {
                Console.Write("Enter a item Id to update:");
                int Id = int.Parse(Console.ReadLine());
                Item toupdate = inventory.FindItemByID(Id);
                if(toupdate != null)
                {
                    Console.Write("Enter the item name to :");
                    string newName = Console.ReadLine();
                    Console.Write("Enter the item Price:");
                    double newPrice = double.Parse(Console.ReadLine());
                    Console.Write("Enter the item Quantity:");
                    int newQuantity = int.Parse(Console.ReadLine());

                    inventory.UpdateItem(Id,newName, newPrice, newQuantity);
                    Console.WriteLine("Item updated succefully.");
                }
                else
                {
                    Console.WriteLine("Id is not foud");
                }
            }
            static void DeleteItem(Inventory inventory)
            {
                Console.Write("Enter the Id of the item to Delect:");
                int Id = int.Parse(Console.ReadLine());
                inventory.DeleteItem(Id);
                Console.WriteLine("Item deleted succefully.");
            }
    }


 }

    
}
