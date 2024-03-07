

public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        // TODO: Initialize the properties with the values passed to the constructor.
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)

    {
        Console.WriteLine("--------------------------------------------------------------------------------");
        Console.Write($"Price for the {ItemName} Item with ID: {ItemId} was {Price}");
        // TODO: Update the item's price with the new price.
        Price = newPrice;
        Console.WriteLine($" is now updated to {Price} ");
        Console.WriteLine("--------------------------------------------------------------------------------");
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        Console.WriteLine("--------------------------------------------------------------------------------");
        // TODO: Increase the item's stock quantity by the additional quantity.
        Console.WriteLine($"Quantity for {ItemName} Item with Id: {ItemId} was {QuantityInStock}");
        QuantityInStock = QuantityInStock + additionalQuantity;
        Console.WriteLine($"Now, {additionalQuantity} units are added for {ItemName} Item with Id: {ItemId}. Quantity is now updated to {QuantityInStock}");
        Console.WriteLine("--------------------------------------------------------------------------------");
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // TODO: Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.
        if (quantitySold <= QuantityInStock)
        {
            QuantityInStock = QuantityInStock - quantitySold;
            Console.WriteLine("Congratulations " + quantitySold + " units of " + ItemName + " Item with ID: " + ItemId + " is  sold !! Remaining Quantity left is " + QuantityInStock);
            Console.WriteLine("--------------------------------------------------------------------------------");
        }
        else
        {
            Console.WriteLine("Sorry, Can't sell the item due to Insufficient Stock for " + ItemName + " Item with ID: " + ItemId + ". Please Restock the" + ItemName + " Item.");
            Console.WriteLine("--------------------------------------------------------------------------------");
        }
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        // TODO: Return true if the item is in stock (quantity > 0), otherwise false.
        if (QuantityInStock > 0)
        {

            Console.WriteLine($"Don't Worry, {ItemName} Item with {ItemId} is available in the Stock!! Quantity present is {QuantityInStock}");
            Console.WriteLine("--------------------------------------------------------------------------------");
        }

        else
        {
            Console.WriteLine($"Attention, {ItemName} Item with {ItemId} is not available in the Stock!!");
            Console.WriteLine("--------------------------------------------------------------------------------");

        }
        return QuantityInStock > 0;
    }

    // Print item details
    public void PrintDetails()
    {
        // TODO: Print the details of the item (name, id, price, and stock quantity).

        Console.WriteLine($"Item: {ItemName}");

        Console.WriteLine($"ID: {ItemId}");

        Console.WriteLine($"Price: {Price}");

        Console.WriteLine($"Quantity in stock: {QuantityInStock}");
        Console.WriteLine("--------------------------------------------------------------------------------");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Ravneet(8876396) Inventory");
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);




        // TODO: Implement logic to interact with these objects.
        // Example tasks:
        // 1. Print details of all items.
        item1.UpdatePrice(1700.75);
        item1.PrintDetails();
        // 2. Sell some items and then print the updated details.
        item1.SellItem(5);
        // 3. Restock an item and print the updated details.
        item1.RestockItem(15);
        item1.PrintDetails();
        // 4. Check if an item is in stock and print a message accordingly.
        item1.IsInStock();

        
        item2.PrintDetails();
        item2.UpdatePrice(1000);
        item2.PrintDetails();
        item2.SellItem(15);
        item2.SellItem(5);
        Console.WriteLine($"Is {item2.IsInStock()}");
        item2.RestockItem(15);
        item2.PrintDetails();


    }
}