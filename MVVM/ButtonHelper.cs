using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ShopDemo.Viewmodel.Helper
{
    public class ButtonHelper : ICommand
    {
        public readonly Action execute; //it is a delegate method
        public ButtonHelper(Action _execute)
        {
            this.execute = _execute;
        }
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            execute.Invoke();
        }
    }
}
