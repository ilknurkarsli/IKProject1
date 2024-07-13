using IKProject.Core.DomainModels.BaseModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.Core.DomainModels.Models
{
    public class Sirket : BaseEntity, IBaseEntity
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string MersisNo { get; set; }
        public string TaxNumber { get; set; }
        public string TaxAdministration { get; set; }
        public string Logo { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        private int _numberOfEmployees;
        public int NumberOfEmployees
        {
            get
            {
                if (_numberOfEmployees < 1)
                    throw new ArgumentOutOfRangeException(nameof(_numberOfEmployees), "Çalışan sayısı 1 veya 1'den fazla olmalıdır!");
                return _numberOfEmployees;
            }
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException(nameof(value), "Çalışan sayısı 1 veya 1'den fazla olmalıdır!");
                _numberOfEmployees = value;
            }
        }
        public DateTime Establishment { get; set; }
        public DateTime ContractStart { get; set; }
        public DateTime? ContractEnd { get; set; }

        public bool? IsActive
        {
            get { return !ContractEnd.HasValue || ContractEnd.Value > DateTime.Now; }
            set { }
        }

        public List<Yonetici> Yoneticiler { get; set; }

    }
}
