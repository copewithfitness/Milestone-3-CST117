using System;
using System.Collections.Generic;
using System.Text;

namespace Milestone_3
{
    // Jeffery Cope
    // CST-117
    // This file is coded by me and nothing was taken from anywhere on internet
    class Data
    {
        public int id;
        public string title;
        public string category;
        public double price;
        public int quantity;
        public Owner owner;                  // Conposition
        public Data() : this(0, "", "", 0, 0, new Owner()) { }               // Calling Overloaded Consturctor
        public Data(int id, string title, string category, double price, int quantity, Owner owner)      // Overloaded COnstructor
        {
            this.id = id;
            this.title = title;
            this.category = category;
            this.price = price;
            this.quantity = quantity;
            this.owner = new Owner(owner);
        }
        public Data(Data obj)                   // Copy Consturctor
        {
            this.id = obj.id;
            this.title = obj.title;
            this.category = obj.category;
            this.price = obj.price;
            this.quantity = obj.quantity;
            this.owner = obj.owner;
        }
        override
        public string ToString()
        {
            return "ID: " + id + "\nTitle: " + title + "\nCategory: " + category + "\nPrice: " + price + "$" +
                "\nQuantity: " + quantity + "\n" + owner.ToString();
        }
    }
}
