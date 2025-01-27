namespace LogisticsManagementSystem.Tests;

public class MockShipmentProvider : IShipmentProvider
{
    public string GetTrackingDetails(string trackingNumber)
    {
        return $"Mock Tracking Info for {trackingNumber}";
    }
}
