
namespace TabControlWithAnimationExample
{
    public class MainWindowViewModel: BaseViewModel
    {
        private TabControlViewModel _tabControlVM;

        public TabControlViewModel TabControlVM
        {
            get { return _tabControlVM; }
            set 
            { 
                _tabControlVM = value;
                OnPropertyChanged(nameof(TabControlVM));
            }
        }

        public MainWindowViewModel()
        {
            TabControlVM = new TabControlViewModel();
        }
    }
}
