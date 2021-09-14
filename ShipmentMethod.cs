// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    internal class ShipmentMethod
    {
        public string Method { get; set; }
        public IDictionary<string, PaymentMethod> PaymentMethods { get; set; }
    }
}