namespace LogisticsManagementSystem
{
    public abstract class ShipmentSpecification
    {
        //Common Properties
        public string Origin { get; set; }
        public string Destination { get; set; }
        public abstract string GetDeliveryEstimate();
    }
    class NorthAmericaShipmentSpecification : ShipmentSpecification
    {        
        public override string GetDeliveryEstimate()
        {
            return "North America Shipment Delivery Estimate: compliant with local regulations.";
        }
    }
    class EuropeShipmentSpecification : ShipmentSpecification
    {
        public override string GetDeliveryEstimate()
        {
            return "Europe Shipment Delivery Estimate: compliant with local regulations.";
        }
    }
}
