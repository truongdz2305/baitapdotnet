using System;

public abstract class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

    // Constructor
    protected Product(string name, decimal price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }

    // Phương thức trừu tượng để hiển thị thông tin sản phẩm
    public abstract void DisplayProductInfo();

    // Phương thức trừu tượng để áp dụng giảm giá
    public abstract void ApplyDiscount(decimal percentage);
}
public interface ISellable
{
    void Sell(int quantity);
    bool IsInStock();
}
public class MobilePhone : Product, ISellable
{
    public MobilePhone(string name, decimal price, int stock) : base(name, price, stock) { }

    // Triển khai phương thức DisplayProductInfo
    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Mobile Phone - Name: {Name}, Price: {Price:C}, Stock: {Stock}");
    }

    // Triển khai phương thức ApplyDiscount
    public override void ApplyDiscount(decimal percentage)
    {
        Price -= Price * (percentage / 100);
    }

    // Triển khai phương thức Sell
    public void Sell(int quantity)
    {
        if (IsInStock() && Stock >= quantity)
        {
            Stock -= quantity;
            Console.WriteLine($"Sold {quantity} Mobile Phones. Remaining stock: {Stock}");
        }
        else
        {
            Console.WriteLine("Not enough stock or product is not available.");
        }
    }

    // Triển khai phương thức IsInStock
    public bool IsInStock()
    {
        return Stock > 0;
    }
}
public class Laptop : Product, ISellable
{
    public Laptop(string name, decimal price, int stock) : base(name, price, stock) { }

    // Triển khai phương thức DisplayProductInfo
    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Laptop - Name: {Name}, Price: {Price:C}, Stock: {Stock}");
    }

    // Triển khai phương thức ApplyDiscount
    public override void ApplyDiscount(decimal percentage)
    {
        Price -= Price * (percentage / 100);
    }

    // Triển khai phương thức Sell
    public void Sell(int quantity)
    {
        if (IsInStock() && Stock >= quantity)
        {
            Stock -= quantity;
            Console.WriteLine($"Sold {quantity} Laptops. Remaining stock: {Stock}");
        }
        else
        {
            Console.WriteLine("Not enough stock or product is not available.");
        }
    }

    // Triển khai phương thức IsInStock
    public bool IsInStock()
    {
        return Stock > 0;
    }
}
public class Accessory : Product, ISellable
{
    public Accessory(string name, decimal price, int stock) : base(name, price, stock) { }

    // Triển khai phương thức DisplayProductInfo
    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Accessory - Name: {Name}, Price: {Price:C}, Stock: {Stock}");
    }

    // Triển khai phương thức ApplyDiscount
    public override void ApplyDiscount(decimal percentage)
{
    Price -= Price * (percentage / 100);
}

// Triển khai phương thức Sell
public void Sell(int quantity)
{
    if (IsInStock() && Stock >= quantity)
    {
        Stock -= quantity;
        Console.WriteLine($"Sold {quantity} Accessories. Remaining stock: {Stock}");
    }
    else
    {
        Console.WriteLine("Not enough stock or product is not available.");
    }
}

// Triển khai phương thức IsInStock
public bool IsInStock()
{
    return Stock > 0;
}
}
class Program
{
    static void Main()
    {
        // Khởi tạo các đối tượng
        MobilePhone phone = new MobilePhone("Samsung Galaxy S23", 999.99m, 10);
        Laptop laptop = new Laptop("Dell XPS 15", 1499.99m, 5);
        Accessory accessory = new Accessory("USB-C Charger", 29.99m, 20);

        // Hiển thị thông tin sản phẩm
        phone.DisplayProductInfo();
        laptop.DisplayProductInfo();
        accessory.DisplayProductInfo();

        // Bán sản phẩm và kiểm tra tồn kho
        phone.Sell(3);
        Console.WriteLine($"Phone in stock: {phone.IsInStock()}");

        laptop.Sell(1);
        Console.WriteLine($"Laptop in stock: {laptop.IsInStock()}");

        accessory.Sell(5);
        Console.WriteLine($"Accessory in stock: {accessory.IsInStock()}");

        // Áp dụng giảm giá
        phone.ApplyDiscount(10); // Giảm 10%
        laptop.ApplyDiscount(15); // Giảm 15%
        accessory.ApplyDiscount(5); // Giảm 5%

        // Hiển thị thông tin sản phẩm sau khi giảm giá
        phone.DisplayProductInfo();
        laptop.DisplayProductInfo();
        accessory.DisplayProductInfo();
    }
}