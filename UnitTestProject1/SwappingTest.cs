using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit.Framework;
using ClassLibrary1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestFixture]
    public class SwappingTest
    {
        //private Swapping _swapping;
        //[SetUp]
        //public void Setup()
        //{
        //    _swapping = new Swapping();
        //}
        [Test]
        public void GetOutPut_WhenCalled_ShouldReturnSwappedArray()
        {
           int[] array1 = { 11, 12, 13, 14, 15, 16 };
           int[] array2 = { 16, 15, 14, 13, 12, 11 };
          //var result = _swapping.SwapMyArray(array1,array2) ;
            var result2 = Swapping.SwapMyArray(array1,array2);
        }
    }
}
