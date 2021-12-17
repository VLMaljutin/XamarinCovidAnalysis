﻿using Covid.Model.Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid.ForAnalysis.Germany
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Death_Germany : ContentPage
    {
        Country_Death vm;
        public Death_Germany()
        {
            vm = new Country_Death(0, 2);
            InitializeComponent();
            this.BindingContext = vm;
        }

        private void Tap2_Clicked(object sender, EventArgs e)
        {
            int a;
            Country_Death vm1;

            try
            {
                a = int.Parse(Number2.Text);
                vm1 = new Country_Death(a, 2);
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