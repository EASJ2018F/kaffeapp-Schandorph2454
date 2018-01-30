using Microsoft.VisualStudio.TestTools.UnitTesting;
using kaffe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe.Tests
{
    [TestClass()]
    public class FlatWhiteTests
    {
        [TestMethod()]
        public void MlMælkTest()
        {
            //Arrange
            var fW = new FlatWhite();
            //Act
            int mlMælk = fW.MlMælk();
            //Assert
            Assert.AreEqual(160, mlMælk);
        }

        [TestMethod()]
        public void PrisTest()
        {
            //Arrange
            var fW = new FlatWhite();
            //Act
            int pris = fW.Pris();
            //Assert
            Assert.AreEqual(45, pris);
        }

        [TestMethod()]
        public void StyrkeTest()
        {
            //Arrange
            var fW = new FlatWhite();
            //Act
            string styrke = fW.Styrke();
            //Assert
            Assert.AreEqual("Mild" , styrke);
        }
    }
}