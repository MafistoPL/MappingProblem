// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Program
    {
        static IDictionary<string, ShipmentMethod> Map(
            List<BasketContentSettings> basketContentSettingsList)
        {
            var shipmentMethods = 
                new Dictionary<string, ShipmentMethod>();

            foreach (var basketContentSettings in basketContentSettingsList)
            {
                var shipmentMethod = basketContentSettings.ShipmentMethod;
                var paymentMethod = basketContentSettings.PaymentMethod;

                if (!shipmentMethods.ContainsKey(shipmentMethod))
                {
                    shipmentMethods[shipmentMethod] = new ShipmentMethod()
                    {
                        Method = shipmentMethod,
                        PaymentMethods = new Dictionary<string, PaymentMethod>()
                    };
                }
                shipmentMethods[shipmentMethod].PaymentMethods[paymentMethod] =
                    new PaymentMethod()
                    {
                        Content = basketContentSettings.Content
                    };
            }

            return shipmentMethods;
        }

        static void Main(string[] args)
        {
            var basketContentSettings = 
                DataProvider.GetBasketContentSettings();

            var shipmentMethods = Map(basketContentSettings);

            string res = JsonConvert.SerializeObject(shipmentMethods,
                Formatting.Indented);

            Console.WriteLine(res);
        }
    }
}
