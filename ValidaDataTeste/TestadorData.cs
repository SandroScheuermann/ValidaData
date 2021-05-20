using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ValidaData;

namespace ValidaDataTeste
{
    [TestClass]
    public class TestadorData
    {
        [TestMethod]
        public void TestaData()
        {
            Data validaData1 = new Data("20/02/-1");
            Data validaData2 = new Data("29/30/2020");
            Data validaData3 = new Data("02/2021");
            Data validaData4 = new Data("");
            Data validaData5 = new Data("02/02/2021");
            Data validaData6 = new Data("02/02/2020");
            Data validaData7 = new Data("20/02/-1");

            Assert.AreEqual(false, validaData1.Validar());
            Assert.AreEqual(false, validaData2.Validar());
            Assert.AreEqual(false, validaData3.Validar());
            Assert.AreEqual(false, validaData4.Validar());
            Assert.AreEqual(true, validaData5.Validar());
            Assert.AreEqual(true, validaData6.Validar());
            Assert.AreEqual(false, validaData7.Validar());
        }
    }
}
