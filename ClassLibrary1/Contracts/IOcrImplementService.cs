using OcrRndProject.BLL.DomainModel;
using OcrRndProject.DAL.Utils;
using OcrRndProject.DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcrRndProject.BLL.Contracts
{
   public interface IOcrImplementService
    {
      
        public Task<CommonResponse> CreateNidInformation(NidDomainModel nid);
        public string GetNidInformation();
        public string OcrRead();

        public Task<IEnumerable<NidDomainModel>> GetAllNidInformation();
        public Task<IEnumerable<AllNidIndoOcrViewModel>> GetNidAddressAndBasicInfo();



    }
}
