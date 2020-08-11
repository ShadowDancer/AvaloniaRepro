using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AvaloniaRepro.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public List<string> Items { get; } = new List<string>
        {
            "Item1",
            "Item2",
            "Item3",
            "Item4"
        };

        public MainWindowViewModel()
        {
            SelectedItems.Add(Items[1]);
        }

        public ObservableCollection<string> SelectedItems { get; } = new ObservableCollection<string>();
    }
}
