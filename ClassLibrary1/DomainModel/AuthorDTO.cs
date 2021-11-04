using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcrRndProject.BLL.DomainModel
{
    class AuthorDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookDTO> Books { get; set; }
    }
}
