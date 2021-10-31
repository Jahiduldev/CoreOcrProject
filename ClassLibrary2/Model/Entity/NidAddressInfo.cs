using OcrRndProject.DAL.Insrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcrRndProject.DAL.Model.Entity
{
    public class NidAddressInfo : BaseEntity
    {
        public string Village { get; set; }

        //[NotMapped]
        public string PostName { get; set; }

        //[Column("Name", Order = 1)]
        public string District { get; set; }
        public string Thana { get; set; }
        //[Column(Order = 3)]
        public string PostCode { get; set; }

       public ICollection<NidInformations> NidInformations { get; set; }
    }
}
