using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LogisticsManagementSystem
{
    public interface IShipmentProvider
    {
        string GetTrackingDetails(string trackingNumber);
    }

    internal class FedExShipmentProvider : IShipmentProvider
    {
        FedExThirdPartyShipmentProvider fedExThirdPartyShipmentProvider;
        public FedExShipmentProvider(FedExThirdPartyShipmentProvider fedExThirdPartyShipmentProvider)
        {
            this.fedExThirdPartyShipmentProvider = fedExThirdPartyShipmentProvider;
        }
        public string GetTrackingDetails(string trackingNumber)
        {
            return fedExThirdPartyShipmentProvider.GetTrackingDetails(trackingNumber);
        }
    }

    internal class UPSShipmentProvider : IShipmentProvider
    {
        UPSThirdPartyShipmentProvider upsThirdPartyShipmentProvider;
        public UPSShipmentProvider(UPSThirdPartyShipmentProvider upsThirdPartyShipmentProvider)
        {
            upsThirdPartyShipmentProvider = upsThirdPartyShipmentProvider;
        }
        public string GetTrackingDetails(string trackingNumber)
        {
            return upsThirdPartyShipmentProvider.GetTrackingDetails(trackingNumber);
        }
    }

    //Fedex Third Party Shipment Provider
    internal class FedExThirdPartyShipmentProvider
    {
        public string GetTrackingDetails(string shipmentId)
        {
            return $"FedEx third party tracking details for {shipmentId}";
        }
    }

    //UPS Third Party Shipment Provider
    internal class UPSThirdPartyShipmentProvider
    {
        public string GetTrackingDetails(string consignmentNumber)
        {
            return $"UPS third party tracking details for {consignmentNumber}";
        }
    }
}
