using Class;

class Program
{
    static void Main(string[] args)
    {
        var orders = new List<Order>
            {
                new Order("Владислав Казнин", "ул. Пушкина, д. 1", 10000.50),
                new Order("Никита Попов", "ул. Лермонтова, д. 5", 149.75),
                new Order("Речицкий Александр", "ул. Толстого, д. 10", 150.30),
                new Order("Илья Першин", "ул. Гоголя, д. 3", 50.20),
                new Order("Илья Голышев", "ул. Пушкина д. Колотушкино", 69.01)
            };

        var order1 = new Order();
        order1.PrintCustomersByAddress("ул. Пушкина, д. 1", orders);
        Console.WriteLine();

        var order2 = new Order();
        order2.PrintCustomersByAmount(150, orders);
    }
}
