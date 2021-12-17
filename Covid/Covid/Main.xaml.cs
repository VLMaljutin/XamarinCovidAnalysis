using Android.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Main : ContentPage
    {
        public Main()
        {
            InitializeComponent();
        }

        private async void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = picker.SelectedIndex;
            switch (name)
            {
                case 0:
                    var result = await DisplayAlert("Перейти на сайт клиники ИНВИТРО", null, "Да", "Нет");
                    
                    if (result)
                    {
                        
                        await Launcher.OpenAsync(new Uri("https://www.invitro.ru/"));
                    }
                    break;
                case 1:
                    result = await DisplayAlert("Перейти на сайт клиники СИТИЛАБ", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://citilab.ru/"));
                    }
                    break;
                case 2:
                    result = await DisplayAlert("Перейти на сайт клиники КДЛ", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://kdl.ru/"));
                    }
                    break;
                case 3:
                    result = await DisplayAlert("Перейти на сайт клиники РАЗУМЕД", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://razumed.su/"));
                    }
                    
                    break;
                case 4:
                    result = await DisplayAlert("Перейти на сайт клиники БИОМЕД", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://biomed-mc.ru/"));
                    }
                   break;
            }
        }

        private async void picker2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = picker2.SelectedIndex;
            switch (name)
            {
                case 0:
                    var result = await DisplayAlert("Перейти на карту?", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://yandex.ru/maps/org/punkt_vaktsinatsii_v_tts_mega/226476524211/?display-text=Пункты%20%20вакцинации%20от%20COVID-19&ll=49.343311%2C55.771256&mode=search&sctx=ZAAAAAgBEAAaKAoSCfJ7m%2F7sjUhAERCVRszs5UtAEhIJrUz4pX7e4T8RN3Fyv0NR1T8iBQABAgMEKAA4AEDvVkgBYihtaWRkbGVfd2l6ZXh0cmE9cHBvX2NoYWluX2ZpeGxpc3Rfb2JzOD0yYhttaWRkbGVfd2l6ZXh0cmE9b2xkX2RydWdzPTFiG3JlbGV2X2ZpeF9sMl9wcnVubmluZz1mYWxzZWoCcnWdAc3MTD2gAQCoAQC9AYdRFFvCAZMBs4W22MsG5Naf%2FIADxdnmgogHzNnClsgB%2B46464YEj8WhqO4BhLGav%2BIFne%2BqxI0B6fKFltMEgNOaw%2F4E6%2FfLhogB9LrvvO8FtrWx5d0DhpLC%2BsMB3qnt0FnZ0N6WwQP2y%2BuzR7K7o7fIBN3o9oyTAu24tr2EBZe%2BxoMU%2FrOS6PgD%2BN7Yl7QDgoDojJkC%2F86Bi5AE6gEA8gEA%2BAEAggIZY2F0ZWdvcnlfaWQ6KDI3ODQ5MDQ2MDA5KYoCCzI3ODQ5MDQ2MDA5kgIA&sll=49.343311%2C55.771256&sspn=0.520477%2C0.183080&text=category_id%3A%2827849046009%29&z=11"));
                    }
                    break;
                case 1:
                    result = await DisplayAlert("Перейти на карту", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://yandex.ru/maps/org/punkt_vaktsinatsii_v_tts_yuzhny/103339780964/?ll=49.217176%2C55.768355&z=17"));
                    }
                    break;
                case 2:
                    result = await DisplayAlert("Перейти на карту", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://yandex.ru/maps/org/punkt_vaktsinatsii_v_mo_spaseniye/53734321356/?ll=49.133516%2C55.768805&z=17"));
                    }
                    break;
                case 3:
                    result = await DisplayAlert("Перейти на карту", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://yandex.ru/maps/org/punkt_vaktsinatsii_v_kts_saydash/159765330281/?ll=49.178445%2C55.799353&z=17"));
                    }

                    break;
                case 4:
                    result = await DisplayAlert("Перейти на карту", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://yandex.ru/maps/org/punkt_vaktsinatsii_v_tts_megastroy_pr_pobedy/128256334518/?ll=49.217709%2C55.772335&z=17"));
                    }
                    break;
            }
        }
    }
}