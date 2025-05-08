using System;
using System.Windows.Input;

namespace ITL_AF_2025.ViewModels
{
	public class ButtonViewModel : BaseViewModel
	{
        #region Lifecycle
        public ButtonViewModel()
		{
            PlusCommand = new Command(PlusOperation);
		}
        #endregion Lifecycle

        #region Internals
        private void PlusOperation(object obj)
        {
            if (LocalCount < Constants.MaxValueInt)
            {
                LocalCount++;
                FirstText = $"Count {LocalCount}";
            }
        }
        #endregion Internal

        #region Properties
        public int _localCount;
        public int LocalCount
        {
            get => _localCount;
            set
            {
                _localCount = value;
                OnPropertyChanged();
            }
        }

        private string _firstText;
        public string FirstText
		{
			get => _firstText;
			set
			{
				SetObservableProperty(ref _firstText, value);
			}
		}

		private ICommand _plusCommand;
        public ICommand PlusCommand
		{
            get => _plusCommand;
            set
            {
                SetObservableProperty(ref _plusCommand, value);
            }
        }
		#endregion Properties
	}
}

