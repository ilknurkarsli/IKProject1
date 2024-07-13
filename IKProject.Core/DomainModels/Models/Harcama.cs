using IKProject.Core.DomainModels.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.Core.DomainModels.Models
{
    public class Harcama:BaseEntity,IBaseEntity
    {
        public string HarcamaTuru { get; set; }
        public string ParaBirimi { get; set; }
        public DateTime TalepTarihi { get; set; }
        public DateTime CevaplanmaTarihi { get; set; }
        public string OnayDurumu { get; set; }
        public double Miktar { get; set; }
        public string Dokuman { get; set; }
        public string YoneticiID { get; set; }
        public Yonetici Yonetici { get; set; }

    }
}
