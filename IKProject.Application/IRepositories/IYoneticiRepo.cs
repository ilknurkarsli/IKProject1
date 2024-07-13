using IKProject.Application.DTOs;
using IKProject.Core.DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.Application.IRepositories
{
    public interface IYoneticiRepo: IBaseRepo<Yonetici>
    {
        Task<List<SirketYoneticiDTO>> GetAktifSirketYonetici();
        Task<List<SirketYoneticiDTO>> GetPasifSirketYonetici();
        Task<List<SirketYoneticiDTO>> GetAktifPersonel();
        Task<List<SirketYoneticiDTO>> GetPasifPersonel();
        Task<List<Yonetici>> GetYoneticisSirketById(string sirketid);
    }
}
