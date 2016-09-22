﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Nome.Configuration.Test
{
    [TestClass]
    public class ConfigurationTest
    {
        private static StreamReader sr = new StreamReader("./config/config.json");
        private string jsonString = sr.ReadToEnd();

        [TestMethod]
        public void ConstractorTest()
        {
            var conf = new Nome.Configuration.Manager(jsonString);
            Assert.AreNotEqual(0, conf.Configuration.Language.Length);
            Assert.AreNotEqual(0, conf.Configuration.Connection.Host.Length);
            Assert.AreNotEqual(0, conf.Configuration.Connection.User.Length);
            Assert.AreNotEqual(0, conf.Configuration.Connection.Password.Length);
        }
    }
}
