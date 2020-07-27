using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaRepro.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public List<List<string>> Items { get; }= new List<List<string>>()
        {
            new List<string>()
            {
                "Item1",
                "Item2",
                "Item3",
                "Item4",
                "Item5"
            },
            new List<string>()
            {
                "Item1",
                "Item2",
                "Item3",
                "Item4",
                "Item5"
            },
        };


        public string Greeting => @"
Example command to show semantics of byte fields
they are similar to string fields, just do not have encoding
";
    }
}
