using System;
using System.Collections.Generic;
using System.Text;

namespace Milestone_3
{
    // Jeffery Cope
    // CST-117
    // This file is coded by me and nothing was taken from anywhere on internet
    class Controler
    {
        private Data[] data = new Data[500];                         // Array List of type Data
        private int size;                                           //  Size of array
        public void add(Data obj)                               // Adding object to Array List
        {
            if(find(obj.id)!=null)
            {
                Console.WriteLine("Faild whole addong data,data with same data exist");
            }
            else
            {
                data[size++] = new Data(obj);
            }

        }
        private void shift(int from)
        {
            for(int i=from;i<(size-1);i++)
            {
                data[i] = data[i + 1];
            }
        }
        public void delete(Data obj)                            // Deleting object from Array List
        {
            for(int i=0;i<size;i++)
            {
                if(data[i].id==obj.id)
                {
                    shift(i);
                    break;
                }
            }
        }
        public void update(Data old, Data updated)              // Updaing object from Array List
        {
            delete(old);
            add(updated);
        }
        public Data find(int id)                                // Finding if Data exist in array list or not
        {
            for (int i = 0; i < size; i++)
            {
                if (data[i].id == id)
                    return data[i];
            }
            return null;
        }
        public Data find(string title)                                // Finding if Data exist in array list or not
        {
            for (int i = 0; i < size; i++)
            {
                if (data[i].title == title)
                    return data[i];
            }
            return null;
        }
        public Data find(double price)                                // Finding if Data exist in array list or not
        {
            for (int i = 0; i < size; i++)
            {
                if (data[i].price == price)
                    return data[i];
            }
            return null;
        }
        public bool reStock(int id,int newQuantity)
        {
            if(find(id)!=null)
            {
                find(id).quantity += newQuantity;
                return true;
            }
            else
            {
                return false;
            }
        }
         public void Display()                                   // Displaying data on console
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(data[i].ToString());
                Console.WriteLine();
                Console.WriteLine();
            }

        }
    }
}
