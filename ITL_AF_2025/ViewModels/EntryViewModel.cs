using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ITL_AF_2025.Models;

namespace ITL_AF_2025.ViewModels
{
	public class EntryViewModel : BaseViewModel
	{
        #region Lifecycle
        public EntryViewModel()
		{
            SaveTodoListCommand = new Command(SaveItemList);
            TodoDataList = new ObservableCollection<TodoDataModel>();
        }

        private void SaveItemList(object obj)
        {
            TodoDataList.Add(new TodoDataModel
            {
                Task = TodoDataText,
                IsChecked = false
            });
            TodoDataText = string.Empty;
        }
        #endregion Lifecycle

        #region Properties
        private string _todoDataText;
        public string TodoDataText
        {
            get => _todoDataText;
            set
            {
                _todoDataText = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<TodoDataModel> _todoDataList;
        public ObservableCollection<TodoDataModel> TodoDataList
        {
            get => _todoDataList;
            set
            {
                _todoDataList = value;
                OnPropertyChanged();
            }
        }

        private TodoDataModel _todoDataItem;
        public TodoDataModel TodoDataItem
        {
            get => _todoDataItem;
            set
            {
                _todoDataItem = value;
                OnPropertyChanged();
            }
        }

        private ICommand _saveTodoListCommand;
        public ICommand SaveTodoListCommand
        {
            get => _saveTodoListCommand;
            set
            {
                _saveTodoListCommand = value;
                OnPropertyChanged();
            }
        }
        #endregion Properties
    }
}

