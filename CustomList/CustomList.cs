using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>: IEnumerable<T>
    {
        int count;
        int capacity = 4;
        public int Count 
        { 
        get
        {
                return count;
        }
        set
        {
                count = value;
        }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }
        //My add and subtract methods will be useful later on.
        T[] data;
        
        public CustomList()
        {
            data = new T[capacity];
        }

        public void IncreaseCapacity()
        {
            if (count == Capacity)
            {
                capacity += 4;
            }
        }

        public void Add(T item)
        {
            T[] newArray = new T[capacity + 1];
            IncreaseCapacity();
            if(count >= capacity/2)
            {
                int newCapacity = capacity * 2;
                newArray = new T[newCapacity];
            }
            for (int i = 0; i < count; i++)
            {
                newArray[i] = data[i];  
            }
            newArray[count] = item;
            Count++;
            data = newArray;
        }
        public bool Remove(T item)
        {
            T[] newArray = new T[capacity];
            if(count >= capacity/2)
            {
                int newCapacity = capacity * 2;
                newArray = new T[newCapacity];
            }
            for (int i = 0; i < count; i++)
            {
                if (item.Equals(data[i]))
                {
                    data[i] = data[i + 1];
                    i++;
                    for( i = 0; i < count; i++)
                    {
                        data[i] = data[i + 1];  
                    }
                    newArray[i] = data[i];
                }
                return true;

            }
            
            return false;
            
        }
        //public virtual string ToString()
        //{
        //    string newString = ""; 
        //    for (int i = 0; i < count; i++)
        //    {
        //        newString = item[i].ToString();
        //    }
        //    return newString;
        //}
    public virtual void AddTwoArrays(T item)
        {
            T[] newArray = new T[capacity + 1];
            if (count >= capacity / 2)
            {
                int newCapacity = capacity * 2;
                newArray = new T[newCapacity];
            }
            for (int i = 0; i < count; i++)
            {
                newArray[i] = data[i];
                newArray[count - 1] = item;
            }
        }
        public virtual void SubtractTwoArrays(T item)
        {

        }
        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < count; i++)
            {
                yield return data[i];
            }
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
