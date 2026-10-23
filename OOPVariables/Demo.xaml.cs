using System;
using System.Collections;
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
using System.Xaml;
using QueryCollection.Emp;
namespace QueryCollection
{
    /// <summary>
    /// Interaction logic for Demo.xaml
    /// </summary>
    public partial class Demo : Window
    {
        MathOperations math = new MathOperations();
      
        public Demo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //static classs And extension
            int num = txtFirstNumber.Text.Tointkani();
            Helper.value = 20;
            MessageBox.Show(Helper.value.ToString());
            Helper.AddTwo();
            //normal int variable
            Empitem oemp = new Empitem();
            oemp.value = 99;
            MessageBox.Show(oemp.value.ToString());
            int a = oemp.value;
            MessageBox.Show(a.ToString());
            Empitem oemp2 = new Empitem();
            int b = oemp2.value;
            MessageBox.Show(oemp2.value.ToString());
            //Const variable
            MessageBox.Show(Empitem.x.ToString());
            //Readonly Variable
            // Empitem oemp3 = new Empitem("50");
            // MessageBox.Show(oemp3.offer);
            //----
            //static variable
            //MessageBox.Show(Empitem.data.ToString());
            Empitem.data = 04;
            MessageBox.Show(Empitem.data.ToString());
            //PartialPractice
            Empitem emps = new Empitem();
            emps.name();
            //NestedPractice
            Automobile auto = new Automobile();
            Automobile.Car cars = new Automobile.Car();
            Automobile.Engine engine = new Automobile.Engine();


            string name = math.names("vasanthasenan");
            MessageBox.Show(name);

            string output = math.stringformate("My name {0}, My Age is {1}", "Vasanthasenan", 21);

           //int num =  math.Numbers(10, 20, 30, 40);
           // MessageBox.Show(num.ToString());

            List<string> names = txtFirstNumber.Text.Split(',').ToList();
            ArrayList outc = math.Getnames(names);
            foreach (var utm in outc)
            {
                MessageBox.Show(utm.ToString());
            }    

            string[] nums = txtFirstNumber.Text.Split(',');
            string outvalue = math.Addnumbers(nums);
            MessageBox.Show(outvalue);
        //string output = math.Add(txtFirstNumber.Text, txtSecondNumber.Text);
        //txtResult.Text = output;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string output = math.Sub(txtFirstNumber.Text, txtSecondNumber.Text);
            txtResult.Text = output;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string output = math.Mult(txtFirstNumber.Text, txtSecondNumber.Text);
            txtResult.Text = output;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string output = math.Div(txtFirstNumber.Text, txtSecondNumber.Text);
            txtResult.Text = output;
        }
    }
}
