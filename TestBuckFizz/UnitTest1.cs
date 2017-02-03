using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.IO;
using ConsumeRESTFulService;

namespace TestRESTFulService
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestService()
        {
            // arrange  
            string input ="Go Seamless";
            string output= "Go Seamless";
            ConsumeService service = new ConsumeService();

            // act  
           output= service.RESTConsume(input);

            // assert  
            Assert.AreEqual(input, output, true);
        }
    }
}
