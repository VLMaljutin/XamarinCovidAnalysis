using Covid.Model.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid.ForAnalysis.World
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Recovery_World : ContentPage
    {
        World_Recovery vm;
        public Recovery_World()
        {
            vm = new World_Recovery(0);
            InitializeComponent();
            this.BindingContext = vm;
        }

        private void Tap_Clicked1(object sender, EventArgs e)
        {
            int a;
            World_Recovery vm1;

            try
            {
                a = int.Parse(Number1.Text);
                vm1 = new World_Recovery(a);
                this.BindingContext = vm1;
                textLabel1.Text = "Введите кол-во дней";
                if (a < 0 || a == -0)
                {
                    textLabel1.Text = "Число меньше нуля или вы ввели -0";
                }


            }
            catch (ArgumentOutOfRangeException)
            {
                textLabel1.Text = "Слишком большое число";

            }
            catch (FormatException)
            {
                textLabel1.Text = "Вы ввели не число";
            }
        }
    }
}