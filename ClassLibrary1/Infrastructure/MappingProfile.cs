using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using OcrRndProject.BLL.DomainModel;
using OcrRndProject.DAL.Model.Entity;

namespace OcrRndProject.BLL.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<NidDomainModel, NidInformations>();
            CreateMap<NidInformations, NidDomainModel>();

            CreateMap<Book, BookDTO>().ForMember(m => m.Id, opt => opt.Ignore());

            CreateMap<Author, AuthorDTO>().ForMember(m => m.Id, opt => opt.Ignore());
        }
       
    }
}
