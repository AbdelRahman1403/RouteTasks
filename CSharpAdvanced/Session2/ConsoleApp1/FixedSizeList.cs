using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FixedSizeList<T>
    {
        private T[] items;
        private int count;

        public FixedSizeList(int size)
        {
            try
            {
                if (size <= 0)
                    throw new ArgumentOutOfRangeException("Size must be greater than zero.");
                items = new T[size];
                count = 0;
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Add(T item)
        {
            try
            {
                if (count >= items.Length)
                    throw new InvalidOperationException("List is full.");
                items[count++] = item;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Get(int index, out T res)
        {
            if(index < 0 || index >= count)
                throw new ArgumentOutOfRangeException("Index is out of range.");

            res = items[index];
        }
    }
}
