namespace ColdChainChecker.Models
{
    public class ColdChainCheckModel
    {
        public int? Gps { get; set; }
        public int? Humidity { get; set; }
        public int? Temperature { get; set; }
        public int? DoorOpenTimes { get; set; }
        public int? DeviceCharge { get; set; }
        public bool? ContractFulfilled { get; set; }
    }
}
