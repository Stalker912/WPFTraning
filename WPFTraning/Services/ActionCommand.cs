using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFTraning.Services
{
    
    internal class ActionCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private readonly Action action;
        private readonly Predicate<object> canExecute;

        public ActionCommand(Action action)
        {
            this.action = action;
        }

        public ActionCommand(Action action, Predicate<object> CanExecute, EventHandler? CanExecuteChanged)
        {
            this.action = action;
            this.canExecute = CanExecute;
            this.CanExecuteChanged += CanExecuteChanged;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            action();
        }
    }
}
