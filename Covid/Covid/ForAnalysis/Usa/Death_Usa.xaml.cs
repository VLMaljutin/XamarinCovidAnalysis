using Covid.Model.Country;
using System;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid.ForAnalysis.Usa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Death_Usa : ContentPage
    {
        Country_Death vm;
        public Death_Usa()
        {
            vm = new Country_Death(0, 8);
            InitializeComponent();
            this.BindingContext = vm;
        }

        private void Tap2_Clicked(object sender, EventArgs e)
        {
            int a;
            Country_Death vm;

            try
            {
                a = int.Parse(Number2.Text);
                vm = new Country_Death(a, 8);
                this.BindingContext = vm;
                textLabel2.Text = "Введите кол-во дней";
                if (a < 0)
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