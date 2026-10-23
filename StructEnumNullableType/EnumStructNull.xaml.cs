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
    /// Interaction logic for EmployeeAttendtance.xaml
    /// </summary>
    public partial class EmployeeAttendtance : Window
    {
        struct Employees
        {
            public string Name;
            public int? Age;
            public Attendtance Status;
        }
        enum Attendtance
        {
            Active,
            InActive,
            Leave
        }
        public EmployeeAttendtance()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
           Employees employees = new Employees();
            employees.Name = txtName.Text;
            //Nullable
            if(String.IsNullOrWhiteSpace(txtAge.Text))
            {
                employees.Age = null;
            }
            else
            {
                int.Parse(txtAge.Text);
            }
            //Enum
            ComboBoxItem selecteditem = (ComboBoxItem)cmbStatus.SelectedItem;
            employees.Status = (Attendtance)Enum.Parse(typeof(Attendtance), selecteditem.Content.ToString());
            txtResult.Text = $@"Name:{employees.Name},  Age:{employees.Age},  Status:{employees.Status}";
        }
    }
}
