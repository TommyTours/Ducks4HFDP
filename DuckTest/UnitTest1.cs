using Ducks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DuckTest
{
    [TestClass]
    public class UnitTest1
    {
        Duck myDuck = new Duck(); 
        [TestMethod]
        public void CanQuack()
        {
            Assert.AreEqual("Quack Quack", myDuck.Quack());
        }

        [TestMethod]
        public void CanFly()
        {
            Assert.AreEqual("Flap Flap", myDuck.Fly());
        }

        [TestMethod]
        public void CanSwim()
        {
            Assert.AreEqual("Splash Splash", myDuck.Swim());
        }

        Duck myMallardDuck = new Mallard();

        
        [TestMethod]
        public void MallardCanQuack()
        {
            Assert.AreEqual("Quack Quack", myMallardDuck.Quack());
        }

        [TestMethod]
        public void MallardCanFly()
        {
            Assert.AreEqual("Flap Flap", myMallardDuck.Fly());
        }

        [TestMethod]
        public void MallardCanSwim()
        {
            Assert.AreEqual("Splash Splash", myMallardDuck.Swim());
        }

        [TestMethod]
        public void MallardCanDisplay()
        {
            Assert.AreEqual("Green Head, Brown Body", myMallardDuck.Display());
        }

        private Duck myRubberDuck = new RubberDuck();

        [TestMethod]
        public void RubberCanQuack()
        {
            Assert.AreEqual("Squeak Squeak", myRubberDuck.Quack());
        }

        [TestMethod]
        public void RubberCanFly()
        {
            Assert.AreEqual("I can't fly; I'm Rubber", myRubberDuck.Fly());
        }

        [TestMethod]
        public void RubberCanSwim()
        {
            Assert.AreEqual("Splash Splash", myRubberDuck.Swim());
        }

        [TestMethod]
        public void RubberCanDisplay()
        {
            Assert.AreEqual("Yellow and Rubber", myRubberDuck.Display());
        }

        private Duck myDecoyDuck = new DecoyDuck();

        [TestMethod]
        public void DecoyCanQuack()
        {
            Assert.AreEqual("Silence", myDecoyDuck.Quack());
        }

        [TestMethod]
        public void DecoyCanFly()
        {
            Assert.AreEqual("I can't fly; I'm Wood", myDecoyDuck.Fly());
        }

        [TestMethod]
        public void DecoyCanSwim()
        {
            Assert.AreEqual("Splash Splash", myDecoyDuck.Swim());
        }

        [TestMethod]
        public void DecoyCanDisplay()
        {
            Assert.AreEqual("Looks like a wooden Mallard", myDecoyDuck.Display());
        }

    }
}
