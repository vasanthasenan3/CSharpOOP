using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Documents;

namespace QueryCollection.Emp
{
  public class MathOperations
  {
        public string stringformate(string formate, params object[] args)
        {
            int count = args.Length;
            for(int i=0; i < count; i++)
            {
                string val = "{" + i + "}";
                formate = formate.Replace(val, args[i].ToString());
            }
            return formate;
        }
        public int Numbers(params int[] nums)
        {
            int output = 0;
            foreach (int i in nums)
            {
                output = output + i;
            }
            return output;
        }
        //method overloading
        public string names(string name1)
        {
            return name1;
        }
        public string names(string name1, string name2)
        {
            return name1 + name2;
        }
        public string names(string name1, string name2, string name3)
        {
            return name1 + name2 + name3;
        }

        public ArrayList Getnames(List<String> values)
        { 
                ArrayList list = new ArrayList();
                foreach (var item in values)
                {
                    list.Add(item);
                }
                return list;    
        }
        public string Addnumbers(String[] value)
        {
            int output = 0;
            try
            {
                foreach(var items in value)
                {
                    int count = Convert.ToInt16(items);
                    output += count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return output.ToString();

            //int value = Convert.ToInt16(a);
            //int value2 = Convert.ToInt16(b);
            //int result = value + value2;
            //return result.ToString();
        }
        public String Sub(String a, String b)
        {
            //    int value = Convert.ToInt16(a);
            //    int value2 = Convert.ToInt16(b);
            int.TryParse(a, out int number1);
            int.TryParse (b, out int number2);
            int result = number1  - number2;
            return result.ToString();
        }
        public String Mult(String a, String b)
        {
            int value = Convert.ToInt16(a);
            int value2 = Convert.ToInt16(b);
            int result = value * value2;
            return result.ToString();
        }
        public String Div(String a, String b)
        {
            int value = Convert.ToInt16(a);
            int value2 = Convert.ToInt16(b);
            int result = value / value2;
            return result.ToString();
        }

    }
}
