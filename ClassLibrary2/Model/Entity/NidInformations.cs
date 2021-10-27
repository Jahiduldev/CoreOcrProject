using OcrRndProject.DAL.Insrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcrRndProject.DAL.Model.Entity
{
    public class NidInformations : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string DateOfBirth{ get; set; }
        public string IDNO { get; set; }
    }
}
