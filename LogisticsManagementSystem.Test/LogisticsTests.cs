namespace LogisticsManagementSystem.Tests;

using NUnit.Framework;

[TestFixture]
public class LogisticsTests
{
    [Test]
    public void Adapter_Should_Return_Tracking_Info()
    {
        IShipmentProvider provider = new MockShipmentProvider();
        string result = provider.GetTrackingDetails("12345");
        Assert.That(result, Is.EqualTo("Mock Tracking Info for 12345"));
    }

    [Test]
    public void Factory_Should_Create_Express_Shipment()
    {
        Shipment shipment = ShipmentFactory.CreateShipment("FedEx");
        Assert.That(shipment, Is.Not.Null);               
        Assert.That(shipment.ShipmentType, Is.EqualTo("FedEx"));
    }

    [Test]
    public void Factory_Should_Throw_Exception_On_Invalid_Type()
    {
        Assert.Throws<ArgumentException>(() => ShipmentFactory.CreateShipment("invalid"));
    }

    [Test]
    public void AbstractFactory_Should_Create_Regional_Shipment()
    {
        IRegionalShipmentFactory factory = new NorthAmericaShipmentFactory();
        Shipment shipment = factory.CreateShipment("FedEx");
        Assert.That(shipment, Is.Not.Null);
        Assert.That(shipment.ShipmentType, Is.EqualTo("FedEx"));       
    }
}