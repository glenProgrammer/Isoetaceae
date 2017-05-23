using System;
using System.Collections.Generic;

namespace Coder
{
    /// <summary>
    /// Creates a set that can be added to, or temporarily removed from.  Added values cannot be permanently removed.
    /// </summary>
    /// <typeparam name="T">Type of values being stored</typeparam>
    public class ResettableSet<T>
    {
        LinkedList<T> original;
        LinkedList<T> working;

        public int TotalInOriginal { get { return original.Count; } }

        public ResettableSet()
        {
            original = new LinkedList<T>();
            working = new LinkedList<T>();
        }

        public ResettableSet(ResettableSet<T> set)
        {
            original = new LinkedList<T>(set.GetOriginal());
            working = new LinkedList<T>(original);
        }

        private LinkedList<T> GetOriginal()
        {
            return original;
        }

        public void Reset()
        {
            if(working.Count != original.Count)
                working = new LinkedList<T>(original);
        }

        public void Add(T obj)
        {
            original.AddLast(obj);
            working.AddLast(obj);
        }

        public void Remove(T obj)
        {
            working.Remove(obj);
        }

        /// <summary>
        /// Removes element at specified index.
        /// </summary>
        /// <returns>Removed element</returns>
        public T RemoveAt(int idx)
        {
            T result = this[idx];
            Remove(result);
            return result;
        }

        /// <summary>
        /// Not efficient. Read only.
        /// </summary>
        /// <returns>Gets reference to object at passed index</returns>
        public T this[int idx]
        {
            get
            {
                var it = working.GetEnumerator();
                it.MoveNext();
                for (int i = 0; i < idx; ++i)
                    it.MoveNext();
                return it.Current;
            }
        }
    }
}