using IKProject.Core.DomainModels.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.Core.DomainModels.Models
{
    public class AvansTalebi : BaseEntity, IBaseEntity
    {
        public string AvansTuru { get; set; }
        public double Tutar { get; set; }
        public string ParaBirimi { get; set; }
        public string Aciklama { get; set; }
        public DateTime TalepTarihi { get; set; }
        public DateTime CevaplanmaTarihi { get; set; }
        public string OnayDurumu { get; set; }
        public string YoneticiID { get; set; }
        public Yonetici Yonetici { get; set; }
    }
}
