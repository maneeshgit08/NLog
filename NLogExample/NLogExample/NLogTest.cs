using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;

namespace NLogExample
{
    [TestClass]
    public class NLogTest
    {
        private Logger _logger = LogManager.GetCurrentClassLogger();

        [TestMethod]
        public void TestMethod1()
        {
            _logger.Trace("TestMethod1");
        }

        [TestMethod]
        public void TestMethod2()
        {
            _logger.Debug("TestMethod2");
        }

        [TestMethod]
        public void TestMethod3()
        {
            _logger.Info("TestMethod3");
        }

        [TestMethod]
        public void TestMethod4()
        {
            _logger.Error("TestMethod4");
        }

        [TestMethod]
        public void TestMethod5()
        {
            _logger.Fatal("TestMethod5");
        }
    }
}
