using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcrRndProject.DAL.Utils
{
    public class CommonResponse
    {
        public bool IsSuccessfull { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public object Data { get; set; }

        internal CommonResponse(bool isSuccessfull, string message, int statusCode, object data)
        {
            IsSuccessfull = isSuccessfull;
            Message = message;
            StatusCode = statusCode;
            Data = data;
        }

        public static CommonResponse Success(object data = null, string message = "Successfull", int statusCode = 200)
        {
            return new CommonResponse(true, message, statusCode, data);
        }

        public static CommonResponse Failure(string message = "Failed", int statusCode = 400)
        {
            return new CommonResponse(false, message, statusCode, null);
        }
    }
}
