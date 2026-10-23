using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Markup;
using System.Xaml;

namespace QueryCollection.Emp
{
    public partial class Empitem
    {
       
        public int value;
        public const int x = 20;
        public readonly string offer;
        public static int data;
     
        public Empitem ()
        {
            value = 100;
            data = 33;
            name();
           

        }
        public int AddTwoNumber(int value1, int value2)
        {
         
            int output = value1 + value2;
            return output;
        }

    }
}
