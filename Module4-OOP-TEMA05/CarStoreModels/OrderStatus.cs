using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarStoreInterfaces;

namespace CarStoreModels
{
    public class OrderStatus : IOrderStatus
    {
        public string Status { get; }

        public DateTime DateOfStatus { get; }

        public string Details { get; }

        private static List<string> ListStatus = new List<string>{ "pending", "confirmed", "cancelled", "received", "delivered" };

        public OrderStatus(string status, DateTime dateOfStatus, string details)
        {
            if (ListStatus.Contains(status.ToLower()))
            {
                this.Status = status;
                this.DateOfStatus = dateOfStatus;
                this.Details = details;
            }
        }

        public void PrintStatus()
        {
            Console.WriteLine($"\t\t status: '{this.Status.ToUpper()}' since {this.DateOfStatus}");
            Console.WriteLine($"\t\t details: {this.Details}");
        }
    }
}
