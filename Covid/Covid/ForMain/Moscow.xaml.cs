using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid.ForMain
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Moscow : ContentPage
    {

        public Moscow()
        {
            InitializeComponent();
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            DateTime date1 = DateTime.Now;
            var test = date1.Subtract(e.NewDate).Days;
            if (label != null)
                label.Text = test.ToString();
        }
    }
}