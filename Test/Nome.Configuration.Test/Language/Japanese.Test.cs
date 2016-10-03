﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Nome.Configuration.Test.Language
{
    [TestClass]
    public class JapaneseTest
    {
        [TestMethod]
        public void ParamatersTest()
        {
            var conf = new Nome.Configuration.Settings.Manager();
            var lang = new Nome.Configuration.Language.Manager(conf.Configuration.Language);
            lang.ReadLanguage("ja");

            var common = new CommonTest();
            Assert.AreEqual(common.ParamatersTest(lang.Language), "");
        }
    }
}