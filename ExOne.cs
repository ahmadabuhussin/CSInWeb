using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication4.Controllers
{
    [ApiController]
    [Route("one")]
    public class ExOne
    {
        // #Ex6
        // one/MaxCountWord
        [HttpGet("MaxCountWord")]
        public int Ex6( string sentence) {
            int max=0, count=0;

            var sentenceArray = sentence.Split(' '); //this function for push the words in array => like: sentence= Hello How Are You, so create array =[Hello, How, Are, You]
            foreach (var s in sentenceArray)
            {
                count = 0;
                for (int i=0; i< sentenceArray.Length; ++i)
                {
                    if( s.Equals(sentenceArray[i]))
                    {
                        ++count;
                    }
                }
                if (max < count)
                {
                    max = count;
                }
            }
            return max;
            }


        // #Ex8
        // one/ChainingTwoStrings
        [HttpGet("ChainingTwoStrings")]
        public string Ex8(string s1, string s2)
        {
            var newstring = s1 + " " + s2; 
            return newstring;
        }

        // #Ex11
        // one/ReverseString
        [HttpGet("ReverseString")]
        public string Ex11(string sentence)
        {
            var chars = sentence.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
            
        }

        // #Ex15
        // one/MaxNumber
        [HttpGet("MaxNumber")]
        public float Ex15(float num1, float num2, float num3)
        {
            float max = num1;
            float[] numberArray = { num2, num3 };
            for (int i = 0; i < 2; ++i)
            {
                if (max < numberArray[i])
                    max = numberArray[i];
            }
            return max;
        }

        // #Ex19
        // one/Numbers
        [HttpGet("Numbers")]
        public List<int> Ex19(int num)
        {
            var listnum = new List<int>();
            for ( int i=1; i < num; ++i)
            {
                listnum.Add(i);
            }
            return listnum;
        }


    }
}
