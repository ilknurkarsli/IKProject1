using IKProject.Core.DomainModels.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.Core.DomainModels.Models
{
    public class Izin:BaseEntity,IBaseEntity
    {
        public string? IzinTuru { get; set; }
        public DateTime? BaslangicTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
        public int? GunSayisi { get; set; }
        public DateTime? TalepTarihi { get; set; }
        public DateTime? CevaplanmaTarihi { get; set; }
        public string? OnayDurumu { get; set; }
        public string? YoneticiID { get; set; }
        public Yonetici? Yonetici { get; set; }

    }
}
