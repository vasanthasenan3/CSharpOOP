using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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
    /// Interaction logic for inherits.xaml
    /// </summary>
    public partial class inherits : Window
    {
    
  
        public inherits()
        {
            InitializeComponent();
        }

 

        private void btnShow_Click_1(object sender, RoutedEventArgs e)
        {
            Manager man = new Manager();
            man.Name = txtName.Text;
            man.Email = txtEmail.Text;
            man.ManagerID = txtManagerId.Text;
            man.department = txtDepartment.Text;
            txtOutput.Text = $@"Name:{man.Name} Email:{man.Email} ManagerID:{man.ManagerID} Department:{man.department}";
        }
    }
}
