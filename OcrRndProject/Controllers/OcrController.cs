using Microsoft.AspNetCore.Mvc;
using OcrRndProject.BLL.Contracts;
using OcrRndProject.BLL.DomainModel;
using OcrRndProject.DAL.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using Tesseract;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;

namespace OcrRndProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OcrController : ControllerBase 
    {
        private readonly IOcrImplementService _service;
        private readonly string data;
      

        public OcrController(IOcrImplementService service)
        {
            _service = service;
        }


        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateNidInformation([FromBody]  NidDomainModel nid)
        {
            if (ModelState.IsValid)
            {
               return Ok(await _service.CreateNidInformation(nid));
           }
            else
            {
                return Ok(CommonResponse.Failure("Invalid Info! Try again."));
            }

        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllNidInformation()
        {
            return Ok(await _service.GetAllNidInformation());
        }



        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetNidAddressAndBasicInfo()
        {
            return Ok(await _service.GetNidAddressAndBasicInfo());
        }


        [HttpGet]
        [Route("[action]")]
        public int GetNidInformation()
        {
            return GC.MaxGeneration; 
        }

        [HttpGet]
        [Route("[action]")]

        public List<string> OcrRead()
        {
            var img = Pix.LoadFromFile(@"C:\Users\TID-ITDev-56\Desktop\DotNetCore\CoreOcrProject\OcrRndProject\Images\NID4.jpg");
         
            var path = @"C:\Users\TID-ITDev-56\Desktop\DotNetCore\CoreOcrProject\OcrRndProject\tessdata";

            //Bitmap img = new Bitmap(@"Test1.jpg");
            using (TesseractEngine engine = new TesseractEngine(path, "eng", EngineMode.Default))
            {
                Page page = engine.Process(img, PageSegMode.Auto);

                string str = page.GetText();
               
                string[] result = Regex.Split(str, "\n\\s*");

                var name =   Array.Find(result, element => element.StartsWith("Name"));

                //var Father =  Array.Find(result, element => element.StartsWith("পিতা"));

                //var Mother =   Array.Find(result, element => element.StartsWith("মাতা"));

                var DateOfBirth = Array.Find(result, element => element.StartsWith("Date"));

                var NID = Array.Find(result, element => element.StartsWith("ID"));
              
                var BasicInfo = new List<string> { };

                BasicInfo.Add(name);
                //BasicInfo.Add(Father);
                //BasicInfo.Add(Mother);
                BasicInfo.Add(DateOfBirth);
                BasicInfo.Add(NID);

                return BasicInfo;

            }


        }



        [HttpGet]
        [Route("[action]")]

        public string OcrRead_________()
        {
          
            var img = Pix.LoadFromFile(@"C:\Users\TID-ITDev-56\Desktop\DotNetCore\CoreOcrProject\OcrRndProject\Images\NID3.jpg");
            var path = @"C:\Users\TID-ITDev-56\Desktop\DotNetCore\CoreOcrProject\OcrRndProject\tessdata";
            //Bitmap img = new Bitmap(@"Test1.jpg");
            using (TesseractEngine engine = new TesseractEngine(path, "bengali", EngineMode.Default))
            {
                Page page = engine.Process(img, PageSegMode.Auto);
                string result = page.GetText();

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\TID-ITDev-56\Desktop\DotNetCore", "WriteLines.doc")))
                {
                   return result;
                }
                //Console.WriteLine(result);
            }

        }

        [HttpGet]
        [Route("[action]")]

        public Dictionary<int, string> DictionAryListStringArray()
        {
            Dictionary<int, string> destionary = new Dictionary<int, string> { };
            destionary.Add(1, "First");

            return destionary;
        }


        [HttpGet]
        [Route("[action]")]

        public List<string> ListString()
        {
           List<string> ListString = new List<string>{ };

            ListString.Add("ListString");

            return ListString;
        }



        [HttpGet]
        [Route("[action]")]

        public string[] StringArray()
        {
            string[] StringArray = new string[1] {"ListString"};

            return StringArray;
        }


        [HttpGet]
        [Route("[action]")]

        public ArrayList ArrayListString()
        {

            ArrayList arlist1 = new ArrayList();

            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);

            return arlist1;

        }



        [HttpGet]
        [Route("[action]")]

        public SortedList<int,string> SortedListString()
        {
            SortedList<int, string> numberNames = new SortedList<int, string>();
            numberNames.Add(3, "Three");
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(4, null);
            numberNames.Add(10, "Ten");
            numberNames.Add(5, "Five");

            return numberNames;

        }



        [HttpGet]
        [Route("[action]")]

        public Hashtable HashtableString()
        {
            Hashtable numberNames = new Hashtable();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            return numberNames;

        }



        [HttpGet]
        [Route("[action]")]

        public Stack<int> StackString()
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);


            return myStack;

        }


        [HttpGet]
        [Route("[action]")]

        public Queue<int> QueueString()
        {
            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);


            return callerIds;

        }


        [HttpGet]
        [Route("[action]")]

        public static void TupleString()
        {

            var numbers = Tuple.Create(1, 2, Tuple.Create(3, 4, 5, 6, 7, 8), 9, 10, 11, 12, 13);

            Console.WriteLine(numbers.Item1); // returns 1
            Console.WriteLine(numbers.Item2); // returns 2
            Console.WriteLine(numbers.Item3); // returns (3, 4, 5, 6, 7,  8)
            Console.WriteLine(numbers.Item3.Item1); // returns 3
            Console.WriteLine(numbers.Item4); // returns 9
            Console.WriteLine(numbers.Rest.Item1); //returns 13

         
        }












    }

}




