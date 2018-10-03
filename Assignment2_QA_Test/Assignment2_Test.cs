using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2_QA;
using NUnit.Framework;

namespace Assignment2_QA_Test
{
    [TestFixture]
    public class Assignment2_Test
    {
        [Test]
        public void Analyze_inputSideA2_SideB2_SideC2_ExpectedOutputEquilateral()
        {
            // Arrange
            int a = 2;
            int b =2;
            int c = 2;
            // Act
            string output = TriangleSolver.Analyze(a,b,c);
            // Assert
            Assert.AreEqual(output, "Euqilataral Triangle Formed...");
        }
        [Test]
        public void Analyze_inputSideA4_SideB4_SideC5_ExpectedOutputIsosceles()
        {
            // Arrange
            int a = 4;
            int b = 4;
            int c = 5;
            // Act
            string output = TriangleSolver.Analyze(a, b, c);
            // Assert
            Assert.AreEqual(output, "Isosceles Triangle Formed...");
        }
        [Test]
        public void Analyze_inputSideA3_SideB4_SideC5_ExpectedOutputScalene()
        {
            // Arrange
            int a = 3;
            int b = 4;
            int c = 5;
            // Act
            string output = TriangleSolver.Analyze(a, b, c);
            // Assert
            Assert.AreEqual(output, "Scalene Triangle Formed...");
        }
        [Test]
        public void Analyze_inputSideA3_SideB4_SideC500_ExpectedOutputCantform()
        {
            // Arrange
            int a = 3;
            int b = 4;
            int c = 500;
            // Act
            string output = TriangleSolver.Analyze(a, b, c);
            // Assert
            Assert.AreEqual(output, "Can not form triangle with given sides");
        }
        [Test]
        public void Analyze_inputSideA1_SideB2_SideC3_ExpectedOutputCantform()
        {
            // Arrange
            int a = 1;
            int b = 2;
            int c = 3;
            // Act
            string output = TriangleSolver.Analyze(a, b, c);
            // Assert
            Assert.AreEqual(output, "Can not form triangle with given sides");
        }
        [Test]
        public void Analyze_inputSideA0_SideB4_SideC5_ExpectedOutputInvalidSides()
        {
            // Arrange
            int a = 0;
            int b = 4;
            int c = 5;
            // Act
            string output = TriangleSolver.Analyze(a, b, c);
            // Assert
            Assert.AreEqual(output, "Invalid side entered..");
        }
        [Test]
        public void Analyze_inputSideA0_Sid0_SideC0_ExpectedOutputInvalidSides()
        {
            // Arrange
            int a = 0;
            int b = 0;
            int c = 0;
            // Act
            string output = TriangleSolver.Analyze(a, b, c);
            // Assert
            Assert.AreEqual(output, "Invalid side entered..");
        }
        [Test]
        public void Analyze_inputSideAminus1_SideB4_SideC5_ExpectedOutputInvalidSides()
        {
            // Arrange
            int a = -1;
            int b = 4;
            int c = 5;
            // Act
            string output = TriangleSolver.Analyze(a, b, c);
            // Assert
            Assert.AreEqual(output, "Invalid side entered..");
        }
        
    }
}
