using IKProject.Application.DTOs;
using IKProject.Core.DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.Application.IRepositories
{
    public interface ITalepRepo
    {
        Task<int> BabalikTalebiOlustur(BabalikTalebiOlusturDTO izin);
        Task<int> EvlilikTalebiOlustur(EvlilikTalebiOlusturDTO izin);
        Task<int> VefatTalebiOlustur(VefatTalebiOlusturDTO izin);
        Task<int> DogumTalebiOlustur(DogumTalebiOlusturDTO izin);
        Task<int> YillikTalepOlustur(YillikTalepOlusturDTO izin);
        Task<List<GetPersonelTalepDTO>> OnaylanacakTalepleriGetir(string sirketid);
        Task<List<GetPersonelTalepDTO>> CevaplanmisTalepleriGetir(string sirketid);
        Task<int> TalebiGuncelle(string id, TalebiGuncelleDTO izin);
        Task<List<Izin>> GetOnayBekleyenTalepler(string id);
        Task<List<Izin>> OnaylanacakPersonelTalepleriGetir(string id);
        Task<List<Izin>> CevaplanmisPersonelTalepleriGetir(string id);
        Task<int> TalebiIptalEt(string id);
        Task<int> HarcamaTalebiIptalEt(string id);
        Task<int> AvansTalebiIptalEt(string id);
        Task<List<Izin>> GetAllTalepler(string id);
        Task<List<Harcama>> CevaplanmisPersonelHarcamaTalepleriGetir(string id);
        Task<List<Harcama>> OnaylanacakPersonelHarcamaTalepleriGetir(string id);
        Task<List<GetPersonelHarcamaTalepDTO>> CevaplanmisHarcamaTalepleriGetir(string id);
        Task<List<GetPersonelHarcamaTalepDTO>> OnaylanacakHarcamaTalepleriGetir(string id);
        Task<int> HarcamaTalebiOlustur(HarcamaTalebiDTO izin);
        Task<int> HarcamaTalebiGuncelle(string id, TalebiGuncelleDTO harcama);
        Task<int> AvansTalebiOlustur(AvansTalepDTO avans);
        Task<List<AvansTalebi>> CevaplanmisPersonelAvansTalepleriGetir(string id);
        Task<List<AvansTalebi>> OnaylanacakPersonelAvansTalepleriGetir(string id);
        Task<List<AvansTalebi>> ReddedilmisPersonelAvansTalepleriGetir(string id);
        Task<List<GetPersonelAvansTalepDTO>> CevaplanmisBireyselAvansTalepleriGetir();
        Task<List<GetPersonelAvansTalepDTO>> CevaplanmisKurumsalAvansTalepleriGetir();
        Task<List<GetPersonelAvansTalepDTO>> OnaylanacakAvansTalepleriGetir(string id);
        Task<List<GetPersonelAvansTalepDTO>> CevaplanmisAvansTalepListesiniGetir(string id);
        Task<int> AvansTalebiGuncelle(string id, TalebiGuncelleDTO avans);
    }
}
