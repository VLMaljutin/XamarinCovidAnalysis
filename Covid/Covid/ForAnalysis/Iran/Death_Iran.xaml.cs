using Covid.Model.Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid.ForAnalysis.Iran
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Death_Iran : ContentPage
    {
        public int a;
        public int b;
        public Death_Iran()
        {
            
            InitializeComponent();
            
        }

        private void Tap2_Clicked(object sender, EventArgs e)
        {
            Country_Death vm;
            vm = new Country_Death(a, b, 3);
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