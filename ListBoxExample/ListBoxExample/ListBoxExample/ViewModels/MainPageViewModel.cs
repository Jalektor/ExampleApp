using System.Collections.ObjectModel;
using ListBoxExample.Models;
using System.Windows.Input;
using ListBoxExample.Commands;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.ComponentModel;


namespace ListBoxExample.ViewModels
{
    public class MainPageViewModel/* : INotifyPropertyChanged*/
    {
        // strings to display name for title, buttons etc
        public string Title { get; set; }

        public string LBox1 { get; set; }

        public string Pick1Name { get; set; }

        public string Navigate { get; set; }

        public string Pick1Item { get; set; }

        // observable used to store contents for first picker
        //  used as any changes to content is automatically updated.
        public ObservableCollection<string> Picker1 { get; set; }


        public MainPageViewModel()
        {
            Picker1 = Lists.List1();

            Title = "ListBox Example App";
            LBox1 = "First List Box";
            Pick1Name = "Selection 1";

            Pick1Item = string.Empty;

            Navigate = "Shows options";

        }

    }
}
