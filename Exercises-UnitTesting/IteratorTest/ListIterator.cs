﻿namespace IteratorTest
{
    using System;
    using System.Collections.Generic;


    public class ListIterator
    {
        private List<string> collection;
        private int currentIndex;

        public ListIterator()
        {
        }

        public ListIterator(List<string> collection)
        {
            this.Collection = collection;
        }

        public List<string> Collection
        {
            get
            {
                return this.collection;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Collection cannot be null or empty");
                }

                this.collection = value;
            }
        }

        public int CurrentIndex
        {
            get
            {
                return currentIndex;
            }

            set
            {
                currentIndex = value;
            }
        }

        public bool Move()
        {
            if (this.currentIndex + 1 < this.collection.Count)
            {
                this.currentIndex++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            if (this.currentIndex + 1 < this.collection.Count)
            {
                return true;
            }
            return false;
        }

        public string Print()
        {
            if (this.collection.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            return this.collection[this.currentIndex];
        }


    }
}
