using OcrRndProject.DAL.Model.Entity;
using OcrRndProject.DAL.Utils;
using OcrRndProject.DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcrRndProject.DAL.Contracts
{
    public interface IOcrImplementRepository
    {
        public string NidInfoGetAll();


      

        public Task<CommonResponse> CreateNidInformation(NidInformations nid);
        public Task<IEnumerable<NidInformations>> GetAllNidInformation();
        public Task<IEnumerable<AllNidIndoOcrViewModel>> GetNidAddressAndBasicInfo();

        public string OcrRead();

    }
}
