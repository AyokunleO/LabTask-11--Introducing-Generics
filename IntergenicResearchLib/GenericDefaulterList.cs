using System;
using System.Collections.Generic;

namespace IntergenicResearchLib
{
    public class GenericDefaulterList<T> where T: IDefaulterList
    {
        public List<T> DefaulterList { get; set; }
        public GenericDefaulterList()
        {
            DefaulterList = new List<T>();
        }

        public void Add(T item)
        {
            DefaulterList.Add(item);
        }
        public void PrintDef()
        {
            if(DefaulterList.Count > 0)
            {
                foreach (var defaulter in DefaulterList)
                {
                   Console.WriteLine($"{defaulter.GetDefaulter()}\n");
                }
            }
        }



        // private T[] data;
        // private int numElements = 0;
        // private int tail = 0;
        // private int head = 0;

        // public GenericDefaulterList(int size)
        // {
        //     if (size > 0){
        //         data = new T[size];
        //     }else{
        //         throw new System.Exception("Size must be greater than zero");
        //     }
        // }

        // public void Enqueue(T item)
        // {
        //     if(numElements == data.Length){
        //         throw new Exception("Queue is full");
        //     }
        //     data[head] = item;
        //     head ++;
        //     numElements++;
        // }
        // public T Dequeue()
        // {
        //     if(numElements == 0){
        //         throw new Exception("Queue is empty!");
        //     }
        //     T item = data[tail];
        //     tail++;
        //     numElements--;
        //     return item;
        // }
    }
}