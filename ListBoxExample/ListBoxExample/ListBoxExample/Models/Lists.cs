using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace ListBoxExample.Models
{
    public class Lists
    {
        // lists created as examples for selectign different options to display different lists
        public static ObservableCollection<string> List1()
        {
            ObservableCollection<string> LB1List = new ObservableCollection<string>();

            LB1List.Add("Example 1");
            LB1List.Add("Example 2");
            LB1List.Add("Example 3");
            LB1List.Add("Example 4");
            LB1List.Add("Example 5");

            return LB1List;
        }

        public static ObservableCollection<string> List2()
        {
            ObservableCollection<string> LB2List = new ObservableCollection<string>();

            LB2List.Add("Example A");
            LB2List.Add("Example B");
            LB2List.Add("Example C");
            LB2List.Add("Example D");
            LB2List.Add("Example E");

            return LB2List;
        }

        public static ObservableCollection<string> List3()
        {
            ObservableCollection<string> LB3List = new ObservableCollection<string>();

            LB3List.Add("Example i");
            LB3List.Add("Example ii");
            LB3List.Add("Example iii");
            LB3List.Add("Example iv");
            LB3List.Add("Example v");

            return LB3List;
        }
    }
}
