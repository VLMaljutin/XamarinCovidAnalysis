using Covid.Model.World;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid.ForAnalysis.World
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Death_World : ContentPage
    {
        World_Death vm;
        public Death_World()
        {
            vm = new World_Death(0);
            InitializeComponent();
            this.BindingContext = vm;
        }

        private void Tap2_Clicked(object sender, EventArgs e)
        {
            int a;
            World_Death vm1;

            try
            {
                a = int.Parse(Number2.Text);
                vm1 = new World_Death(a);
                this.BindingContext = vm1;
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