using Covid.Model.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid.ForAnalysis
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Infections_World : ContentPage
    {
        World_Infections vm;
        public Infections_World()
        {
            vm = new World_Infections(0);
            InitializeComponent();
            this.BindingContext = vm;
        }

        private void Tap_Clicked(object sender, EventArgs e)
        {
            int a;
            World_Infections vm1;
            
                try {
                a = int.Parse(Number.Text);
                vm1 = new World_Infections(a);
                this.BindingContext = vm1;
                textLabel.Text = "Введите кол-во дней";
                if (a < 0 )
                {
                    textLabel.Text = "Число меньше нуля ";
                }


            }
            catch (ArgumentOutOfRangeException)
            {
                textLabel.Text = "Слишком большое число";

            }
            catch (FormatException)
            {
                textLabel.Text = "Вы ввели не число";
            }
        }
    }
}