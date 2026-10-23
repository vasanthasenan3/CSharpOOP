using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OopPrac2
{
    /// <summary>
    /// Interaction logic for OopPractice.xaml
    /// </summary>
    public partial class OopPractice : Window
    {
        public OopPractice()
        {
            InitializeComponent();
        }

        //Abstract Class
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FTemployees ftemp = new FTemployees();
            ftemp.name = "Vasanthasenan";
            ftemp.shoname();
            ftemp.CalSalary();
            double salary = ftemp.CalSalary();
            MessageBox.Show($"EmpName:{ftemp.name} - Rs"+salary.ToString());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PTemployees ptemp = new PTemployees();
            ptemp.name = "Kanishka";
            ptemp.shoname();
            ptemp.CalSalary();
            double payment = ptemp.CalSalary();
            MessageBox.Show($"EmpName:{ptemp.name} - Rs" + payment.ToString());

        }

        //interfaces
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Payment payment = new upipayment();
            payment.pay();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Payment pay = new cardpayment();
            pay.pay();
        }
    }
}
