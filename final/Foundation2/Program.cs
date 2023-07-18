using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address[] addresses =  new Address[2];
        Customer[] customers =  new Customer[2];
        List<Product>[] productsLists = new List<Product>[2];
        Order[] orders = new Order[2];

        
        addresses[0] = new Address("108 Maud Street", "Dover", "Delaware", "USA");
        customers[0] =  new Customer("Mr. James Perkins", addresses[0]);
        productsLists[0] = new List<Product>();
        productsLists[0].Add(new Product("Toyota ABS Sensor", "TS014A", 42.33f, 2));
        productsLists[0].Add(new Product("Battery BOSCH S6588B", "BB009F", 259.99f, 1));
        orders[0] = new Order(customers[0],productsLists[0]);

        
        addresses[1] = new Address("Rio Segura 65", "Tudela", "Navarre", "Spain");
        customers[1] =  new Customer("Gaspar Del Pino", addresses[1]);
        productsLists[1] = new List<Product>();
        productsLists[1].Add(new Product("Fuse 5A", "EF123B", 0.06f, 150));
        productsLists[1].Add(new Product("ECU Renault Megane 2", "EX001R", 160.95f, 1));
        productsLists[1].Add(new Product("Fuel Pump Renault Megane 2", "EC083I", 76.99f, 1));
        orders[1] = new Order(customers[1], productsLists[1]);

        for(int i = 0; i < 2; i++)
        {
            Console.WriteLine($"\n-----CUSTOMER N°{i+1} ORDER-----");
            Console.WriteLine($"PACKING:\n{orders[i].GetPackingLabel()}"); 
            Console.WriteLine($"SHIPPING\n{orders[i].GetShippingLabel()}");
            Console.WriteLine($"TOTAL COST: ${orders[i].GetTotalCost()}");
        }
    }
}