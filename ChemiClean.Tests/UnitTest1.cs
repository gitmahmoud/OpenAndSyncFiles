using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChemiCleanWinService;
using BL;

namespace ChemiClean.Tests
{
    [TestClass]
    public class UniTetstWinService
    {
        [TestMethod]
        public void TestMethod1()
        {
            ReadFile readFile = new ReadFile();
            Byte[] byteArray =  readFile.DownloadFile("https://drive.google.com/file/d/1Cx-pxr1tmBTRkW2PlS8tJYuqQEc0pRsq/view");
            Assert.IsNotNull(byteArray);
        }
    }
}
