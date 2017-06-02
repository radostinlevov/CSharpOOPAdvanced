namespace ListIterator.Tests
{
    using System;
    using IteratorTest;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class ListIteratorTests
    {
        private ListIterator listIterator;

        [TestInitialize]
        public void Init()
        {
            this.listIterator = new ListIterator();
        }

        [TestMethod]
        public void ConstructorShouldInitializeCollectionWithGivenNonEmptyCollection()
        {
            List<string> collection = new List<string>() { "Gosho", "Lili", "Ivan" };
            this.listIterator = new ListIterator(collection);

            CollectionAssert.AreEqual(collection, this.listIterator.Collection, "Collections are not equal!");
        }

        [TestMethod]
        public void ConstructorShouldInitializeCollectionWithGivenEmptyCollection()
        {
            List<string> collection = new List<string>();
            this.listIterator = new ListIterator(collection);
            Assert.AreEqual(0, this.listIterator.Collection.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorShouldThrowWithNullCollection()
        {
            List<string> collection = null;
            this.listIterator = new ListIterator(collection);
        }

        [TestMethod]
        public void OneMoveWithThreeElementShouldReturnTrue()
        {
            List<string> collection = new List<string>() { "Gosho", "Lili", "Ivan" };
            this.listIterator = new ListIterator(collection);

            bool hasMove = this.listIterator.Move();
            Assert.IsTrue(hasMove);
        }

        [TestMethod]
        public void ThreeMovesWithThreeElementShouldReturnFalse()
        {
            List<string> collection = new List<string>() { "Gosho", "Lili", "Ivan" };
            this.listIterator = new ListIterator(collection);

            this.listIterator.Move();
            this.listIterator.Move();
            bool hasMove = this.listIterator.Move();
            Assert.IsFalse(hasMove);
        }

        [TestMethod]
        public void OneMoveShouldMoveInternalIndexByOne()
        {
            List<string> collection = new List<string>() { "Gosho", "Lili", "Ivan" };
            this.listIterator = new ListIterator(collection);

            int indexBeforeMove = this.listIterator.CurrentIndex;
            this.listIterator.Move();
            int indexAfterMove = this.listIterator.CurrentIndex;

            Assert.AreEqual(0, indexBeforeMove);
            Assert.AreEqual(1, indexAfterMove);
        }

        [TestMethod]
        public void TwoMovesShouldMoveInternalIndexByOne()
        {
            List<string> collection = new List<string>() { "Gosho", "Lili" };
            this.listIterator = new ListIterator(collection);

            int indexBeforeMove = this.listIterator.CurrentIndex;
            this.listIterator.Move();
            this.listIterator.Move();
            int indexAfterMove = this.listIterator.CurrentIndex;

            Assert.AreEqual(0, indexBeforeMove);
            Assert.AreEqual(1, indexAfterMove);
        }

        [TestMethod]
        public void HasNextWithNoMoveOnCollectionWithTwoElementsShouldReturnTrue()
        {
            List<string> collection = new List<string>() { "Gosho", "Lili" };
            this.listIterator = new ListIterator(collection);

            bool hasNext = this.listIterator.HasNext();
            Assert.IsTrue(hasNext);
        }

        [TestMethod]
        public void HasNextWithOneMoveOnCollectionWithTwoElementsShouldReturnFalse()
        {
            List<string> collection = new List<string>() { "Gosho", "Lili" };
            this.listIterator = new ListIterator(collection);

            this.listIterator.Move();
            bool hasNext = this.listIterator.HasNext();
            Assert.IsFalse(hasNext);
        }

        [TestMethod]
        public void PrintWithNoMoveShouldReturn0thElement()
        {
            List<string> collection = new List<string>() { "Gosho", "Lili" };
            this.listIterator = new ListIterator(collection);

            string element = this.listIterator.Print();
            Assert.AreEqual(collection[0], element);
        }

        [TestMethod]
        public void PrintWithOneMoveShouldReturn1thElement()
        {
            List<string> collection = new List<string>() { "Gosho", "Lili" };
            this.listIterator = new ListIterator(collection);

            this.listIterator.Move();
            string element = this.listIterator.Print();
            Assert.AreEqual(collection[1], element);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PrintEmptyCollectionShouldThrow()
        {
            List<string> collection = new List<string>();
            this.listIterator = new ListIterator(collection);

            this.listIterator.Print();
        }
    }
}
