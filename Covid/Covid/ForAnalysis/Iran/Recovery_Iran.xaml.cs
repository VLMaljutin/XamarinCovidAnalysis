﻿using Covid.Model.Country;
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
    public partial class Recovery_Iran : ContentPage
    {
        Country_Recovery vm;
        public Recovery_Iran()
        {
            vm = new Country_Recovery(0, 3);
            InitializeComponent();
            this.BindingContext = vm;
        }

        private void Tap2_Clicked(object sender, EventArgs e)
        {
            int a;
            try
            {
                a = int.Parse(Number2.Text);
                vm = new Country_Recovery(a, 3);
                this.BindingContext = vm;
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