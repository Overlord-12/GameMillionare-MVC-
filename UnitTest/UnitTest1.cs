using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GameMillionare_MVC_.Models;
using System.Data.Entity;
using GameMillionare_MVC_.Controllers;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Repos()
        {
            Answer answ = new Answer();
            var c = Repository.Init();
            Assert.AreEqual(answ, c);
        }
      
    }
}
