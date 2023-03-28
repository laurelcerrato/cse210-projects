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

        bool usaorn1 = address1.UsaOrnot();
        customer1.SetAddress(address1);
        customer1.LiveinUsa(address1);

        Order order1 = new Order();
        order1.SetCustomer(customer1);
        order1.AddProducts(p1);
        order1.AddProducts(p2);
        order1.SetList(order1.GetList());
        order1.SetUsaornot(usaorn1);
        //2
        Address address2 = new Address("5th Street","Miami","Florida","USA");
        Customer customer2 = new Customer("Ashly");
        Product p3 = new Product("Candles", 32312,15,10);
        Product p4 = new Product("Meet", 765231,150,2);
        Product p5 = new Product("Shampoo", 128192,10,1);

        

        bool usaorn2 = address2.UsaOrnot();
        customer2.SetAddress(address2);
        customer2.LiveinUsa(address2);

        Order order2 = new Order();
        order2.SetCustomer(customer2);
        order2.AddProducts(p3);
        order2.AddProducts(p4);
        order2.AddProducts(p5);
        order2.SetList(order2.GetList());
        order2.SetUsaornot(usaorn2);

        orders.Add(order1);
        orders.Add(order2);
        
        foreach(Order order in orders){
            order.TotalCost();
            Console.WriteLine();
            Console.WriteLine("Shipping Label: ");
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine("\nPacking Label: ");
            foreach(Product product in order.GetList()){
            Console.WriteLine(order.PackingLabel(product));
        }
        }
    }
}