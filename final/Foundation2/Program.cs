using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the product ordering system!");

        List<Order> orders = new List<Order>();
        //1
        Address address1 = new Address("21 Street","San Pedro Sula","Cortes","Honduras");
        Customer customer1 = new Customer("Laurel");
        Product p1 = new Product("Hammer", 09821,100,1);
        Product p2 = new Product("Dress", 12131,10,2);
        //2
        Address address2 = new Address("5th Street","Miami","Florida","USA");
        Customer customer2 = new Customer("Ashly");
        Product p3 = new Product("Candles", 32312,15,10);
        Product p4 = new Product("Meet", 765231,150,2);
        Product p5 = new Product("Shampoo", 128192,10,1);

        bool usaorn1 = address1.UsaOrnot();
        string returnedadd = address1.AddresInfo();
        string customername = customer1.GetCustomername();
        customer1.SetAddress(address1);
        customer1.LiveinUsa(address1);
        Order order1 = new Order();
        order1.AddProducts(p1);
        order1.AddProducts(p2);
        order1.TotalCost(usaorn1,order1.GetList());
        orders.Add(order1);
        Console.WriteLine(order1.ShippingLabel(customername,returnedadd));
        foreach(Product product in order1.GetList()){
            Console.WriteLine(order1.PackingLabel(product));
        }
        Console.WriteLine();

        bool usaorn2 = address2.UsaOrnot();
        string returnedadd2 = address2.AddresInfo();
        string customername2 = customer2.GetCustomername();
        customer2.SetAddress(address2);
        customer2.LiveinUsa(address2);
        Order order2 = new Order();
        order2.AddProducts(p3);
        order2.AddProducts(p4);
        order2.AddProducts(p5);
        order2.TotalCost(usaorn2,order2.GetList());
        Console.WriteLine(order2.ShippingLabel(customername2,returnedadd2));
        foreach(Product product in order2.GetList()){
            Console.WriteLine(order2.PackingLabel(product));
        }

    }
}