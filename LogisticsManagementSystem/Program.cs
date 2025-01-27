// See https://aka.ms/new-console-template for more information
using LogisticsManagementSystem;

IRegionalShipmentFactory northAmericaFactory = new NorthAmericaShipmentFactory();

ShipmentSpecification specification = northAmericaFactory.CreateSpecification();
specification.Origin = "North America";
specification.Destination = "North America";

Console.WriteLine(specification.GetDeliveryEstimate()); //Get the delivery estimate as per North America regulations

Shipment shipment = northAmericaFactory.CreateShipment("FedEx");
Console.WriteLine($"Processing {shipment.ShipmentType} shipment...");

Console.ReadLine();
