using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OverrideBack
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : CustomContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OpenPageButton_OnClicked(object sender, EventArgs e)
        {
            //When Setting the mainPage a 2nd time (1st is App.xaml) the OnOptionsItemSelected(...) is not called
            //Check situation
            //Maybe it has to do with Navigation Stack

            bool triggerBreak = false;

            if (triggerBreak)
                App.Current.MainPage = new NavigationPage(new Page1());
            else
                Navigation.PushAsync(new Page1());
        }
    }
}
