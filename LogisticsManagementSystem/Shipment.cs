using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsManagementSystem
{
    public abstract class Shipment
    {
        public string ShipmentType { get; protected set; }
        public abstract void ProcessShipment();
    }

    public class FedExShipment : Shipment
    {
        public FedExShipment()
        {
            ShipmentType = "FedEx";
        }
        public override void ProcessShipment()
        {
            Console.WriteLine("FedEx shipment processed.");
        }
    }

    public class UPSShipment : Shipment
    {
        public UPSShipment()
        {
            ShipmentType = "UPS";
        }
        public override void ProcessShipment()
        {
            Console.WriteLine("UPS shipment processed.");
        }
    }

    public class ShipmentFactory
    {
        public static Shipment CreateShipment(string type)
        {
            return type.ToLower() switch
            {
                "fedex" => new FedExShipment(),
                "ups" => new UPSShipment(),
                _ => throw new ArgumentException("Invalid shipment type")
            };
        }
    }
}
