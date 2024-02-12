using System;
using System.Windows.Input;

namespace Flat_App
{
    public class RelayCommand : ICommand
    {
        private readonly Func<bool> _canExecute; // Делегат для проверки возможности выполнения команды
        private readonly Action _execute; // Делегат для выполнения команды

        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            _execute = execute ??
                       throw new ArgumentNullException("execute"); // Установка делегата для выполнения команды
            _canExecute = canExecute; // Установка делегата для проверки возможности выполнения команды
        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested +=
                value; // Добавление делегата для обработки изменений возможности выполнения команды
            remove => CommandManager.RequerySuggested -=
                value; // Удаление делегата для обработки изменений возможности выполнения команды
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(); // Проверка возможности выполнения команды
        }

        public void Execute(object parameter)
        {
            _execute(); // Выполнение команды
        }
    }
}

public class RelayCommand : ICommand
{
    private readonly Func<bool> _canExecute; // Делегат для проверки возможности выполнения команды
    private readonly Action _execute; // Делегат для выполнения команды

    public RelayCommand(Action execute, Func<bool> canExecute = null)
    {
        _execute = execute ?? throw new ArgumentNullException("execute"); // Установка делегата для выполнения команды
        _canExecute = canExecute; // Установка делегата для проверки возможности выполнения команды
    }

    public event EventHandler CanExecuteChanged
    {
        add => CommandManager.RequerySuggested +=
            value; // Добавление делегата для обработки изменений возможности выполнения команды
        remove => CommandManager.RequerySuggested -=
            value; // Удаление делегата для обработки изменений возможности выполнения команды
    }

    public bool CanExecute(object parameter)
    {
        return _canExecute == null || _canExecute(); // Проверка возможности выполнения команды
    }

    public void Execute(object parameter)
    {
        _execute(); // Выполнение команды
    }
}