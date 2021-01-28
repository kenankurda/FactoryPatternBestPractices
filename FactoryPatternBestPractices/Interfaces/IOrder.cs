using FactoryPatternBestPractices.Models;

namespace FactoryPatternBestPractices.Interfaces
{
    public interface IOrder
    {
        int Amount { get; set; }
        string Articel { get; set; }
        ICustomer Customer { get; set; }
        decimal Price { get; set; }

        void OrderConfirmation();
    }
}