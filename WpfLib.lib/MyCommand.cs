using System;
using System.Windows.Input;

namespace WPFL.lib
{
    public class MyCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        Action<object> action;
        public MyCommand(Action<object> action)
        {
            this.action = action;
        }
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {

            action(parameter);
        }
    }
}
