using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace TabControlWithAnimationExample
{
    public class TabControlViewModel: BaseViewModel
    {
        public ObservableCollection<TabItemViewModel> TabCollection { get; set; }

        private TabItemViewModel _selectedTab;

        public TabItemViewModel SelectedTab
        {
            get { return _selectedTab; }
            set 
            {
                if (!(_selectedTab is null))
                    _selectedTab.IsSelected = false;
                _selectedTab = value;
                _selectedTab.IsSelected = true;
                OnPropertyChanged(nameof(SelectedTab));
            }
        }


        public TabControlViewModel()
        {
            TabCollection = new ObservableCollection<TabItemViewModel>();
            TabCollection.CollectionChanged += OnCollectionChanged;

            TabCollection.Add(new TabItemViewModel() { Name="Tab 1", Val = 0 });
            TabCollection.Add(new TabItemViewModel() { Name="Tab 2", Val = 2 });
        }

        /// <summary>
        /// Event handler for changes to a collection object
        /// </summary>
        /// <param name="sender">The object being changed</param>
        /// <param name="e">The change being made</param>
        private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {

        }

    }
}
