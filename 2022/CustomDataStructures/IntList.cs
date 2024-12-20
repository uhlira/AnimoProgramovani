using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructures
{
    public class IntList
    {
        private int[] array;

        public IntList()
        {
            #region Metody listu
            /*
             * zakladni metody listu:
             * 
             * Add
             * AddRange
             * Count
             * Clear
             * Contains
             * IndexOf
             * Insert
             * InsertRange
             * Remove
             * RemoveAt
             * Reverse
             * Sort
             * Min
             * Max
             */
            #endregion

            Clear();
        }

        public int Count
        {
            get { return array.Length; }
        }

        public int this[int index]
        {
            get => array[index];
        }

        private void Reinitialize(int increment)
        {
            int[] tmparray = new int[array.Length + increment];
            if (tmparray.Length < array.Length) 
            {
                Array.Resize(ref array, tmparray.Length);
            }
            
            array.CopyTo(tmparray, 0);
            array = tmparray;
        }

        public void Add(int number)
        {
            Reinitialize(1);
            array[array.Length - 1] = number;
        }

        public void RemoveLast() 
        {
            Reinitialize(-1);
        }

        public bool Contains(int number) 
        {
            for (int i = 0; i < Count-1; i++)
            {
                if (array[i] == number) return true;
            }

            return false;
        }

        public void Reverse()
        {
            Array.Reverse(array);
        }

        public void Clear() 
        {
            array = new int[0];
        }

        public int IndexOf(int number)
        {
            for (int i = 0; i < Count - 1; i++)
            {
                if (array[i] == number) return i;
            }

            return -1;
        }
    }
}
