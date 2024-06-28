using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotanikBambu.Models
{
    public class Truckerİnfo :BaseModel
    {
        public int truckerName {  get; set; }
        public string truckerTelNo { get; set; }
        public string truckPlateNo { get; set; }
        public string truckColor { get; set; }
        public string truckType { get; set; }
        public DateTime receivedDate { get; set; }
        public DateTime deliveryDate { get; set; }
    }
}
