using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcrRndProject.DAL.Model.Entity
{
    public class Author
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
