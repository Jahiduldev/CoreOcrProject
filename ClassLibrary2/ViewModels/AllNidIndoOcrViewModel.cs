using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcrRndProject.DAL.ViewModels
{
    public class AllNidIndoOcrViewModel
    {
        //Nid basic Inof
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string DateOfBirth { get; set; }
        public string IDNO { get; set; }

        //Nid Address Info
        public string Village { get; set; }
        public string PostName { get; set; }
        public string District { get; set; }
        public string Thana { get; set; }
        public string PostCode { get; set; }

    }
}
