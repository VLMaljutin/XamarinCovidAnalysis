using Covid.Model.Country;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid.ForAnalysis.Usa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Recovery_Usa : ContentPage
    {
        public int a;
        public int b;
        public Recovery_Usa()
        {
           
            InitializeComponent();
          
        }

        private void Tap2_Clicked(object sender, EventArgs e)
        {
            Country_Recovery vm;
            vm = new Country_Recovery(a, b, 8);
            this.BindingContext = vm;
        }
        private void datepicker1_DateSelected(object sender, DateChangedEventArgs e)
        {
            DateTime date = new DateTime(2020, 1, 22);
            a = e.NewDate.Subtract(date).Days;
        }

        private void datepicker2_DateSelected(object sender, DateChangedEventArgs e)
        {
            DateTime date = new DateTime(2020, 1, 22);
            b = e.NewDate.Subtract(date).Days;
        }
    }
}