namespace BotanikBambu.Models
{
    public class Truckerİnfo : BaseModel
    {
        public int TruckerName { get; set; }
        public string TruckerTelNo { get; set; }
        public string TruckPlateNo { get; set; }
        public string TruckColor { get; set; }
        public string TruckType { get; set; }
        public DateTime ReceivedDate { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
