using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace OopPrac2
{
    public abstract class Employees
    {
        public string name;
        public void shoname()
        {
            MessageBox.Show("EmpName:"+ name);
        }
        public abstract double CalSalary();
    }

    public class FTemployees : Employees
    {
        public override double CalSalary()
        {
            return 30000;
        }
    }

    public class PTemployees : Employees
    {
        public override double CalSalary()
        {
            return 20000;
        }
    }
    public interface Payment
    {
        void pay();
    }
    public class upipayment : Payment
    {
        public void pay()
        {
            MessageBox.Show("UPI Payment Success");
        }
    }

    public class cardpayment : Payment
    {
        public void pay()
        {
            MessageBox.Show("Card Payment Success");
        }
    }
}
