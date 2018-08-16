using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mobiles.Test
{
    [TestClass]
    public class MobileBalanceTest
    {
        [TestMethod]
        public void ValidateBalance_Case1()
        {
            var sternOne = new Stern(2) as INode;
            var sternTwo = new Stern(4) as INode;
            var sternThree = new Stern(9) as INode;

            var stabOne = new Stab(sternOne, sternTwo, 9) as INode;
            var stabTwo = new Stab(stabOne, sternThree, 10) as INode;

            stabTwo.Balance();

            Assert.IsTrue(Math.Abs(((Stab)stabOne).Position - 6) < 0.05);
            Assert.IsTrue(Math.Abs(((Stab)stabTwo).Position - 6) < 0.05);
        }

        [TestMethod]
        public void ValidateBalance_Case2()
        {
            var sternOne = new Stern(5) as INode;
            var sternTwo = new Stern(5) as INode;
            var sternThree = new Stern(10) as INode;

            var stabOne = new Stab(sternOne, sternTwo, 9) as INode;
            var stabTwo = new Stab(stabOne, sternThree, 10) as INode;

            stabTwo.Balance();

            Assert.IsTrue(Math.Abs(((Stab)stabOne).Position - 4.5) < 0.05);
            Assert.IsTrue(Math.Abs(((Stab)stabTwo).Position - 5) < 0.05);
        }
    }
}
