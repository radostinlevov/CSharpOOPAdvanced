namespace Froggy
{
    using System.Collections;
    using System.Collections.Generic;


    public class Lake : IEnumerable<int>
    {
        
        private List<int> stones;

        public Lake(List<int> stones )
        {
            this.stones = new List<int>();

            this.stones = stones;
        }

        public List<int> Stones => this.stones;
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return this.stones[i];
                }
            }

            for (int i = this.stones.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return this.stones[i];
                }
            }
        }
    }
}
