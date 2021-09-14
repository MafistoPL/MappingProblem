
namespace ConsoleApp1
{
    class DataProvider
    {
        public static List<BasketContentSettings> GetBasketContentSettings()
        {
            return new List<BasketContentSettings>()
            {
                new BasketContentSettings()
                {
                    ShipmentMethod = "ship-a",
                    PaymentMethod = "pay-a",
                    Content = "test 1"
                },
                new BasketContentSettings()
                {
                    ShipmentMethod = "ship-a",
                    PaymentMethod = "pay-b",
                    Content = "test 2"
                },
                new BasketContentSettings()
                {
                    ShipmentMethod = "ship-b",
                    PaymentMethod = "pay-a",
                    Content = "test 3"
                },
                new BasketContentSettings()
                {
                    ShipmentMethod = "ship-b",
                    PaymentMethod = "pay-b",
                    Content = "test 4"
                }
            };
        }
    }
}