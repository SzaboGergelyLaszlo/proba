using Microsoft.VisualStudio.TestTools.UnitTesting;
using celloveszetCLI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celloveszetCLI.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        [DataRow(22, 29, 12, 23, 29)]
        [DataRow(16, 45, 87, 33, 87)]
        [DataRow(96, 49, 67, 45, 96)]
        [DataRow(44, 3, 12, 77, 77)]


        public void LegnagyobbTest(int elsoLoves, int masodikLoves, int harmadikLoves, int negyedikLoves, int expected)
        {
            Assert.AreEqual(expected, Program.Legnagyobb(elsoLoves, masodikLoves, harmadikLoves, negyedikLoves));
        }
    }
}