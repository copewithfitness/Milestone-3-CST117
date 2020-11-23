using System;
using System.Collections.Generic;
using System.Text;

namespace Milestone_3
{
    // Jeffery Cope
    // CST-117
    // This file is coded by me and nothing was taken from anywhere on internet
    class Owner
    {
        public int id;
        public string name;
        public double responseRate;
        public double positiveReview;
        public Owner() : this(0, "", 0, 0) { }                   //      Calling Overloaded Consturctor
        public Owner(int id, string name, double responseRate, double positiveReview)       // Overloaded Consturctor
        {
            this.id = id;
            this.name = name;
            this.responseRate = responseRate;
            this.positiveReview = positiveReview;
        }
        public Owner(Owner obj)                             // Copy Consturctor
        {
            this.id = obj.id;
            this.name = obj.name;
            this.responseRate = obj.responseRate;
            this.positiveReview = obj.positiveReview;
        }
        override
        public string ToString()
        {
            return "OwnerID: " + id + "\nOwner Name: " + name + "\nOwner ResponseRate: " + responseRate + " %\n" +
                "Owner Posstive Review: " + positiveReview + " %";
        }
    }
}
