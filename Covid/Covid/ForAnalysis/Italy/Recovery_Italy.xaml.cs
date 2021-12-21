using Covid.Model.Country;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid.ForAnalysis.Italy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Recovery_Italy : ContentPage
    {
        Country_Recovery vm;
        public Recovery_Italy()
        {
            vm = new Country_Recovery(0, 5);
            InitializeComponent();
            this.BindingContext = vm;
        }

        private void Tap2_Clicked(object sender, EventArgs e)
        {
            int a;
            try
            {
                a = int.Parse(Number2.Text);
                vm = new Country_Recovery(a, 5);
                this.BindingContext = vm;
                textLabel2.Text = "Введите кол-во дней";
                if (a < 0 )
                {
                    textLabel2.Text = "Число меньше нуля ";
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