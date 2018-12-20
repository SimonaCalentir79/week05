using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMCarStoreModels
{
    public class OrderStatus : IStatusOfOrder
    {
        public string StatusOfOrder { get; set; }
        public DateTime DateOfStatus { get; set; }
        public string Details { get; set; }

        public OrderStatus(string statusOfOrder, DateTime dateOfStatus, string details)
        {
            this.StatusOfOrder = statusOfOrder;
            this.DateOfStatus = dateOfStatus;
            this.Details = details;
        }

        public void PrintStatus()
        {
            Console.WriteLine($"\t\t\t Status: {this.StatusOfOrder} - {this.DateOfStatus}");
            Console.WriteLine($"\t\t\t Details: {this.Details}");
        }
    }
}
