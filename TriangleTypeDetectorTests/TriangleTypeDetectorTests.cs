using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTypeDetector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTypeDetector.Tests
{
    [TestClass()]
    public class TriangleTypeDetectorTests
    {
        [TestMethod()]
        public void GetTriangleTypeTest()
        {
            Assert.AreEqual(TriangleTypeDetector.TriangleTypes.AcuteAngled, TriangleTypeDetector.GetTriangleType(new int[] { 5, 6, 7 }));
            Assert.AreEqual(TriangleTypeDetector.TriangleTypes.Rectangular, TriangleTypeDetector.GetTriangleType(new int[] { 6, 8, 10 }));
            Assert.AreEqual(TriangleTypeDetector.TriangleTypes.Obtuse, TriangleTypeDetector.GetTriangleType(new int[] { 9, 5, 6 }));
        }
    }
}