
namespace TabControlWithAnimationExample
{
    public class TabItemViewModel: BaseViewModel
    {
		private string _name;

		public string Name
		{
			get { return _name; }
			set 
			{ 
				_name = value;
				OnPropertyChanged(nameof(Name));
			}
		}


		private int _val;

		public int Val
		{
			get { return _val; }
			set 
			{
				_val = value;
				OnPropertyChanged(nameof(Val));
			}
		}

		private bool _isSelected;

		public bool IsSelected
		{
			get { return _isSelected; }
			set 
			{ 
				_isSelected = value;
				OnPropertyChanged(nameof(IsSelected));
			}
		}


		public TabItemViewModel()
		{

		}
	}
}
