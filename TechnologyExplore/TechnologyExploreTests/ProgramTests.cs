using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnologyExplore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyExplore.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void testTest()
        {
            new TechnologyExplore.Program().test();

            Assert.Fail();
        }
    }
}