using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotanikBambu.Models
{
    public class Orderİnfo
    {
        public string orderId { get; set; }
        public string orderName { get; set; }
        public string orderColor { get; set; }


        public int chairNumber { get; set; }
        public string chairType { get; set; }        
        public bool isChairAjurlu { get; set; }
     
        public string tableSizes { get; set; }
        public string tableType { get; set; }
        public bool isTableAjurlu { get; set; }

        public string sargıType { get; set; }
        public string sargıColor { get; set; }

        public virtual ICollection<Cushionİnfo> Cushionİnfos { get; set; }
        public virtual ICollection<Truckerİnfo> Truckers { get; set; }

    }
}
