using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ListBoxExample.ViewModels;
using System.Collections.ObjectModel;
using ListBoxExample.Models;

namespace ListBoxExample
{
	public partial class MainPage : ContentPage
	{
        // these strings store selected index for both pickers 
        public string Pick1Item { get; set; }

        public string Pick2Item { get; set; }

        // observable used to store contents for first picker
        //  used as any changes to content is automatically updated.
        public ObservableCollection<string> Picker2 { get; set; }

        MainPageViewModel viewModel = new MainPageViewModel();

        // sets Binding for certain text/Itemssources for pickers
        public MainPage()
		{
			InitializeComponent();
            BindingContext = viewModel;
            Pick1Item = "test 1";
            Pick2Item = "test 2";
		}

        // Changes content of observable collection, based on which option was selected in picker1
        public void ItemSelectChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(viewModel.Pick1Item.Contains("1") || viewModel.Pick1Item.Contains("2") || viewModel.Pick1Item.Contains("3"))
            {
                Picker2 = Lists.List2();
                pick2.ItemsSource = Picker2;
            }
            if (viewModel.Pick1Item.Contains("4") || viewModel.Pick1Item.Contains("5"))
            {
                Picker2 = Lists.List3();
                pick2.ItemsSource = Picker2;
            }
        }

        // displays message showing what options where selected in pickers
        private void OnButtonClicked(object sender, EventArgs e)
        {
            Pick1Item = viewModel.Pick1Item;
            Pick2Item = pick2.SelectedItem.ToString();
            DisplayAlert(Pick1Item, Pick2Item, "Passed");
        }

    }
}
