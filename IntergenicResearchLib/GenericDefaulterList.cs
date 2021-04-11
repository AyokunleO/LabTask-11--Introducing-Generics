using System;

namespace IntergenicResearchLib
{
    public class GenericDefaulterList<T>
    {

        private T[] data;
        private int numElements = 0;
        private int tail = 0;
        private int head = 0;

        public GenericDefaulterList(int size)
        {
            if (size > 0){
                data = new T[size];
            }else{
                throw new System.Exception("Size must be greater than zero");
            }
        }

        public void Enqueue(T item)
        {
            if(numElements == data.Length){
                throw new Exception("Queue is full");
            }
            data[head] = item;
            head ++;
            numElements++;
        }
        public T Dequeue()
        {
            if(numElements == 0){
                throw new Exception("Queue is empty!");
            }
            T item = data[tail];
            tail++;
            numElements--;
            return item;
        }
    }
}