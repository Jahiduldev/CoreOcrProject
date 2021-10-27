using Microsoft.EntityFrameworkCore;
using OcrRndProject.DAL.Contracts;
using OcrRndProject.DAL.Model.Entity;
using OcrRndProject.DAL.Utils;
using OcrRndProject.DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcrRndProject.DAL.Repositoty
{
    public class OcrImplementRepository : IOcrImplementRepository
    {

        private readonly OCrRndProjectDbContext _context;

        public OcrImplementRepository(OCrRndProjectDbContext context)
        {
            _context = context;

        }
        public string NidInfoGetAll()
        {
            throw new NotImplementedException();
        }


        public async Task<IEnumerable<NidInformations>> GetAllNidInformation()
        {
            var response = await (from a in _context.NidInformations select a).ToListAsync();
            return response;
        }


        public async Task<IEnumerable<AllNidIndoOcrViewModel>> GetNidAddressAndBasicInfo()
        {
            var result = await (from Nbasic in _context.NidInformations // outer sequence
                        join NInfo in _context.NidAddressInfo //inner sequence 
                        on Nbasic.Id equals NInfo.Id // key selector 
                        select new AllNidIndoOcrViewModel
                        { // result selector 
                            FirstName = Nbasic.FirstName,
                            Village = NInfo.Village
                        }).ToListAsync();
                        return result;

        }

        
        public async Task<CommonResponse> CreateNidInformation(NidInformations nid)
        {

            await _context.AddRangeAsync(nid);
            var result = await _context.SaveChangesAsync();

            if (result > 0)
            {
                return (CommonResponse.Success("Success!"));
            }
            else
            {
                return (CommonResponse.Failure("Failed! Try again."));
            }
        }


        public string OcrRead()
        {
            throw new NotImplementedException();
        }
    }
}
