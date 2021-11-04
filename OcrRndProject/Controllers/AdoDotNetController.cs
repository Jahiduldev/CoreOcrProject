using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace OcrRndProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdoDotNetController : Controller
    {
        private readonly IConfiguration _configuration;
        private string FirstName;


        public AdoDotNetController(IConfiguration configuration)
        {
            _configuration = configuration;

           

        }
        [HttpGet]
        [Route("[action]")]
        public string Index()
        {
            return "ss";
        }


        [HttpGet]
        [Route("[action]")]
        public string GetDataByAdoDotNet()
        {
          
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from NidInformations", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                FirstName = dr["FatherName"].ToString();

             return FirstName;

            }
            return FirstName;


            dr.Close();

            con.Close();
            Console.Read();

        }

    }
}
