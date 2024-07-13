using IKProject.Core.DomainModels.BaseModels;
using IKProject.Core.DomainServices;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.Core.DomainModels.Models
{
    public class Yonetici : IdentityUser, IBaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Photo { get; set; }
        public string? SecondName { get; set; }
        public string? SecondLastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? PlaceOfBirth { get; set; }
        public string? Tc { get; set; }
        public DateTime? EmploymentStartDate { get; set; }
        public DateTime? EmploymentEndDate { get; set; }
        public bool? IsActive
        {
            get { return !EmploymentEndDate.HasValue || EmploymentEndDate.Value > DateTime.Now; }
            set { }
        }
        public string? JobTitle { get; set; }
        public string? Department { get; set; }
        public override string? Email { get; set; }
        public string? Address { get; set; }
        public string? SelfPhoneNumber { get; set; } 
        public double? Salary { get; set; }
        public string? AdderID { get; set; }
        public string? SirketID { get; set; }
        public Sirket? Sirket { get; set; }
        public List<Izin>? Izinler { get; set; }
        public List<AvansTalebi>? Avanslar { get; set; }
        public List<Harcama>? Harcamalar { get; set; }
        public string? Cinsiyet { get; set; }
        public int? YillikIzinGunSayisi { get; set; }


    }
}
