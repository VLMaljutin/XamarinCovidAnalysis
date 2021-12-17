using Covid.Model.Country;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid.ForAnalysis.Britain
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Recovery_Britain : ContentPage
    {
        Country_Recovery vm;
        public Recovery_Britain()
        {
            vm = new Country_Recovery(0,1);
            InitializeComponent();
            this.BindingContext = vm;
        }

        private void Tap2_Clicked(object sender, EventArgs e)
        {
            int a;
            Country_Recovery vm1;

            try
            {
                a = int.Parse(Number2.Text);
                vm1 = new Country_Recovery(a,1);
                this.BindingContext = vm1;
                textLabel2.Text = "Введите кол-во дней";
                if (a < 0 || a == -0)
                {
                    textLabel2.Text = "Число меньше нуля или вы ввели -0";
                }


            }
            catch (ArgumentOutOfRangeException)
            {
                textLabel2.Text = "Слишком большое число";

            }
            catch (FormatException)
            {
                textLabel2.Text = "Вы ввели не число";
            }

        }
    }
}