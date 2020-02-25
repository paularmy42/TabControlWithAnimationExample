using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;

namespace TabControlWithAnimationExample
{
    public class BaseViewModel : DependencyObject, INotifyPropertyChanged, INotifyCollectionChanged
    {
        public event PropertyChangedEventHandler PropertyChanged; // = (sender, e) => { };

        public void OnPropertyChanged(string _propName) //Pass the property that has changed to this method
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(_propName)); //Invoke the event handler if PropertyChanged has been triggered by a listener
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged = (sender, e) => { };

        public void OnCollectionChanged(NotifyCollectionChangedAction _action)
        {
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(_action));
        }
    }
}
