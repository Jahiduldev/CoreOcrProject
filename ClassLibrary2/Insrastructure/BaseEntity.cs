using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcrRndProject.DAL.Insrastructure
{

    public class BaseEntity
    {
        //private DateTime? _dateCreate;
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.UtcNow;
        //{
        //    get { return _dateCreate.Value; }
        //    set { _dateCreate = value; }
        //}
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool IsActive
        {
            get;
            set;
        }
        public bool? IsDeleted { get; set; } = false;
    }
    public static class dateTimeUtility
    {
        public static DateTime? ToNullIfTooEarlyForDb(this DateTime date)
        {
            return (date >= (SqlDateTime)SqlDateTime.MinValue) ? date : null;
        }
    }
}
