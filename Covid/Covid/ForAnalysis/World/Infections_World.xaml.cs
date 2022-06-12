using Covid.Model.World;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid.ForAnalysis
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Infections_World : ContentPage
    {
        public int type;
        public int a;
        public int b;
       
        public Infections_World()
        {
            
            InitializeComponent();
            
        }

        private void Tap_Clicked(object sender, EventArgs e)
        {
            World_Infections vm1;
            
                vm1 = new World_Infections(a, b);
                this.BindingContext = vm1;
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