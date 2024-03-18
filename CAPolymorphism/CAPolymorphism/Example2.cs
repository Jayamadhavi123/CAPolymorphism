using System;

// Base class for Product
public class Product
{
    // Properties
    public string ProductName { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    // Constructor
    public Product(string productName, double price, int quantity)
    {
        ProductName = productName;
        Price = price;
        Quantity = quantity;
    }

    // Method to display product information
    public void DisplayProductInfo()
    {
        Console.WriteLine($"Product: {ProductName}, Price: {Price}, Quantity: {Quantity}");
    }
}

// Subclass for Electronics
public class Electronics : Product
{
    // Additional properties specific to Electronics
    public string Brand { get; set; }
    public string Warranty { get; set; }

    // Constructor
    public Electronics(string productName, double price, int quantity, string brand, string warranty)
        : base(productName, price, quantity)
    {
        Brand = brand;
        Warranty = warranty;
    }

    // Method to display electronics information
    public void DisplayElectronicsInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Warranty: {Warranty}");
    }
}

// Subclass for Clothing
public class Clothing : Product
{
    // Additional properties specific to Clothing
    public string Size { get; set; }
    public string Material { get; set; }

    // Constructor
    public Clothing(string productName, double price, int quantity, string size, string material)
        : base(productName, price, quantity)
    {
        Size = size;
        Material = material;
    }

    // Method to display clothing information
    public void DisplayClothingInfo()
    {
        Console.WriteLine($"Size: {Size}, Material: {Material}");
    }
}

// Subclass for Books
public class Books : Product
{
    // Additional properties specific to Books
    public string Author { get; set; }

    // Constructor
    public Books(string productName, double price, int quantity, string author)
        : base(productName, price, quantity)
    {
        Author = author;
    }

    // Method to display book information
    public void DisplayBookInfo()
    {
        Console.WriteLine($"Author: {Author}");
    }
}

class Phone
{
    static void Main(string[] args)
    {
        // Creating instances of each subclass
        Electronics phone = new Electronics("Smartphone", 499.99, 10, "Samsung", "1 Year");
        Clothing shirt = new Clothing("T-Shirt", 19.99, 20, "M", "Cotton");
        Books novel = new Books("The Great Gatsby", 12.99, 30, "F. Scott Fitzgerald");

        // Accessing properties and methods inherited from the base class
        phone.DisplayProductInfo();
        phone.DisplayElectronicsInfo();

        shirt.DisplayProductInfo();
        shirt.DisplayClothingInfo();

        novel.DisplayProductInfo();
        novel.DisplayBookInfo();
    }
}