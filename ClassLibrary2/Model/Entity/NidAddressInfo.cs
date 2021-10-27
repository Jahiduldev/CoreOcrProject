using OcrRndProject.DAL.Insrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcrRndProject.DAL.Model.Entity
{
    public class NidAddressInfo : BaseEntity
    {
        public string Village { get; set; }
        public string PostName { get; set; }
        public string District { get; set; }
        public string Thana { get; set; }
        public string PostCode { get; set; }

        //public ICollection<NidInformations> NidInformations { get; set; }
    }
}
