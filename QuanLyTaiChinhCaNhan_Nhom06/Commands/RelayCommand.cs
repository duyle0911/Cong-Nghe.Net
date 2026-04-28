using System;
using System.Windows.Input;

namespace QuanLyTaiChinhCaNhan_Nhom06.Commands
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object?> execute;
        private readonly Predicate<object?>? canExecute;

        public RelayCommand(
            Action<object?> execute,
            Predicate<object?>? canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
            => canExecute == null || canExecute(parameter);

        public void Execute(object? parameter)
            => execute(parameter);

        public void RaiseCanExecuteChanged()
            => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}