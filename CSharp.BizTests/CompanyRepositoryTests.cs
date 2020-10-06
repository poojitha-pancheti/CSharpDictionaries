using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp.Biz;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Biz.Tests
{
    [TestClass()]
    public class CompanyRepositoryTests
    {
        [TestMethod()]
        public void RetrieveTest()
        {
            var repository = new CompanyRepository();

            var expected = new List<Company>();
            expected.Add(new Company()
            { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com" });
            expected.Add(new Company()
            { VendorId = 2, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" });

            var actual = repository.Retrieve();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetrieveWithKeysTest()
        {
            var repository = new CompanyRepository();

            var expected = new Dictionary<string, Company>()
            {
            {"ABC Corp" , new Company()
                {VendorId = 5, CompanyName = "ABC Corp" , Email = "abc@abc.com" }},
                { "XYZ Inc" , new Company()
                {VendorId = 8, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" }}
                };
            var actual = repository.RetrieveWithKeys();

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}


