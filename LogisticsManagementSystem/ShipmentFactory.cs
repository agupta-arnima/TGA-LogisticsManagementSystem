using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsManagementSystem
{
    // Abstract factory for region-specific shipments
    public interface IRegionalShipmentFactory
    {
        public Shipment CreateShipment(string type);
        public ShipmentSpecification CreateSpecification();
    }

    //Concrete factory for North America shipments
    public class NorthAmericaShipmentFactory : IRegionalShipmentFactory
    {
        public Shipment CreateShipment(string type)
        {
            return ShipmentFactory.CreateShipment(type);
        }

        public ShipmentSpecification CreateSpecification()
        {
            return new NorthAmericaShipmentSpecification();
        }
    }

    //Concrete factory for Europe shipments
    public class EuropeShipmentFactory : IRegionalShipmentFactory
    {
        public Shipment CreateShipment(string type)
        {
            return ShipmentFactory.CreateShipment(type);
        }

        public ShipmentSpecification CreateSpecification()
        {
            return new EuropeShipmentSpecification();
        }
    }
}