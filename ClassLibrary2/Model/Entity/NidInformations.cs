using Microsoft.EntityFrameworkCore;
using OcrRndProject.DAL.Insrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcrRndProject.DAL.Model.Entity
{
    public class NidInformations : BaseEntity
    {
        //[Required]
        //[StringLength(10)]
        public string FirstName { get; set; }

        //[Required]
        public string LastName { get; set; }

        //[MaxLength(50)]
        public string FatherName { get; set; }

        //[StringLength(50)]
        public string MotherName { get; set; }


        public string DateOfBirth{ get; set; }

        //[ConcurrencyCheck]
        public string IDNO { get; set; }
    }
}
