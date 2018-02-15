
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzFuzz.Test
{
    class DataGenerator
    {
        public static IEnumerable<object[]> GetFizzFuzzDate()
        {
            List<object[]> list = new List<object[]>();   
            list.Add(new object[]{1, "1"});
            list.Add(new object[]{2, "1,2"});
            list.Add(new object[]{3, "1,2,Fizz"});
            list.Add(new object[]{4, "1,2,Fizz,4"});
            list.Add(new object[]{5, "1,2,Fizz,4,Fuzz"});
            list.Add(new object[]{6, "1,2,Fizz,4,Fuzz,Fizz"});
            list.Add(new object[]{10, "1,2,Fizz,4,Fuzz,Fizz,7,8,Fizz,Fuzz"});
            list.Add(new object[]{15, "1,2,Fizz,4,Fuzz,Fizz,7,8,Fizz,Fuzz,11,Fizz,13,14,FizzFuzz"});
            list.Add(new object[]{30, "1,2,Fizz,4,Fuzz,Fizz,7,8,Fizz,Fuzz,11,Fizz,13,14,FizzFuzz,16,17,Fizz,19,Fuzz,Fizz,22,23,Fizz,Fuzz,26,Fizz,28,29,FizzFuzz"});
            
            return list;
        }
    }
}
