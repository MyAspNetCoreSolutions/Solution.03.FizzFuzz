using System;
using Xunit;

namespace FizzFuzz.Test
{
    public class UnitTest1
    {

        #region InlineDataSolution
        //[InlineData(1, "1")]//this solution has 2 problem
        //[InlineData(2, "1,2")]// Enter repeated data
        //[InlineData(3, "1,2,Fizz")]// nobody can change this data from outside
        //[InlineData(4, "1,2,Fizz,4")] // best solution is use data generator
        //[InlineData(5, "1,2,Fizz,4,Fuzz")]
        //[InlineData(6, "1,2,Fizz,4,Fuzz,Fizz")]
        //[InlineData(10, "1,2,Fizz,4,Fuzz,Fizz,7,8,Fizz,Fuzz")]
        //[InlineData(15, "1,2,Fizz,4,Fuzz,Fizz,7,8,Fizz,Fuzz,11,Fizz,13,14,FizzFuzz")] 
        //[InlineData(30, "1,2,Fizz,4,Fuzz,Fizz,7,8,Fizz,Fuzz,11,Fizz,13,14,FizzFuzz,16,17,Fizz,19,Fuzz,Fizz,22,23,Fizz,Fuzz,26,Fizz,28,29,FizzFuzz")]
        #endregion
        [Theory]
        [MemberData(nameof(DataGenerator.GetFizzFuzzDate), MemberType =typeof(DataGenerator))]
        public void FizzFuzzTest(int input, string result)
        {
            FizzFuzzz fizzFuzzz = new FizzFuzzz();
            var res = fizzFuzzz.GetText(input);
            Assert.Equal(res, result);
        }
    }
}
