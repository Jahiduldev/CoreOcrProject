using AutoMapper;
using OcrRndProject.BLL.Contracts;
using OcrRndProject.BLL.DomainModel;
using OcrRndProject.DAL.Contracts;
using OcrRndProject.DAL.Model.Entity;
using OcrRndProject.DAL.Utils;
using OcrRndProject.DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcrRndProject.BLL.Services
{
    public class OcrImplementService : IOcrImplementService
    {
        private readonly IOcrImplementRepository _repository;
        private readonly IMapper _mapper;

        public OcrImplementService(IOcrImplementRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CommonResponse> CreateNidInformation(NidDomainModel nid)
        {
            NidInformations NidInformationsEntity = _mapper.Map<NidDomainModel, NidInformations>(nid);

            return await _repository.CreateNidInformation(NidInformationsEntity);


        }

        public string GetNidInformation()
        {
            throw new NotImplementedException();
        }


        public string OcrRead()
        {
            throw new NotImplementedException();
        }


        public async Task<IEnumerable<NidDomainModel>> GetAllNidInformation()
        {
            return _mapper.Map<IList<NidDomainModel>>(await _repository.GetAllNidInformation());
        }



        public async Task<IEnumerable<AllNidIndoOcrViewModel>> GetNidAddressAndBasicInfo()
        {
            return _mapper.Map<IList<AllNidIndoOcrViewModel>>(await _repository.GetNidAddressAndBasicInfo());
        }


   

    }
}
