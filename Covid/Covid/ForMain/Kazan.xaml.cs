using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid.ForMain
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kazan : ContentPage
    {
        public Kazan()
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
                    picker.SelectedIndex = -1;
                    break;
                case 1:
                    result = await DisplayAlert("Перейти на сайт клиники СИТИЛАБ", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://citilab.ru/"));
                    }
                    picker.SelectedIndex = -1;
                    break;
                case 2:
                    result = await DisplayAlert("Перейти на сайт клиники КДЛ", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://kdl.ru/"));
                    }
                    picker.SelectedIndex = -1;
                    break;
                case 3:
                    result = await DisplayAlert("Перейти на сайт клиники РАЗУМЕД", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://razumed.su/"));
                    }
                    picker.SelectedIndex = -1;
                    break;
                case 4:
                    result = await DisplayAlert("Перейти на сайт клиники БИОМЕД", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://biomed-mc.ru/"));
                    }
                    picker.SelectedIndex = -1;
                    break;
                case 5:
                    result = await DisplayAlert("Перейти на сайт клиники Doctor Lab", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://докторлабкзн.рф/"));
                    }
                    picker.SelectedIndex = -1;
                    break;
                case 6:
                    result = await DisplayAlert("Перейти на сайт клиники Полимед", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://полимед.рф/"));
                    }
                    picker.SelectedIndex = -1;
                    break;
                case 7:
                    result = await DisplayAlert("Перейти на сайт клиники ДНКОМ", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://dnkom.ru/"));
                    }
                    picker.SelectedIndex = -1;
                    break;
                case 8:
                    result = await DisplayAlert("Перейти на сайт клиники Гемотест", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://gemotest.ru/"));
                    }
                    picker.SelectedIndex = -1;
                    break;
                case 9:
                    result = await DisplayAlert("Перейти на сайт клиники Айболит", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://mc-aybolit.ru/"));
                    }
                    picker.SelectedIndex = -1;
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
                        await Launcher.OpenAsync(new Uri("https://yandex.ru/maps/org/punkt_vaktsinatsii_v_tts_park_khaus/203196957606/?display-text=Пункты%20%20вакцинации%20от%20COVID-19&ll=49.138066%2C55.802864&mode=search&sll=49.138066%2C55.802775&text=category_id%3A%2827849046009%29&z=11"));
                    }
                    picker2.SelectedIndex = -1;
                    break;
                case 1:
                    result = await DisplayAlert("Перейти на карту", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://yandex.ru/maps/org/punkt_vaktsinatsii_v_tts_yuzhny/103339780964/?ll=49.217176%2C55.768355&z=17"));
                    }
                    picker2.SelectedIndex = -1;
                    break;
                case 2:
                    result = await DisplayAlert("Перейти на карту", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://yandex.ru/maps/org/punkt_vaktsinatsii_v_mo_spaseniye/53734321356/?ll=49.133516%2C55.768805&z=17"));
                    }
                    picker2.SelectedIndex = -1;
                    break;
                case 3:
                    result = await DisplayAlert("Перейти на карту", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://yandex.ru/maps/org/punkt_vaktsinatsii_v_kts_saydash/159765330281/?ll=49.178445%2C55.799353&z=17"));
                    }
                    picker2.SelectedIndex = -1;
                    break;
                case 4:
                    result = await DisplayAlert("Перейти на карту", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://yandex.ru/maps/org/punkt_vaktsinatsii_v_fgaou_vo_kazanskiy_federalny_universitet/201722682740/?display-text=Пункты%20%20вакцинации%20от%20COVID-19&ll=49.138066%2C55.802864&mode=search&sll=49.138066%2C55.802775&text=category_id%3A%2827849046009%29&z=11"));
                    }
                    picker2.SelectedIndex = -1;
                    break;
                case 5:
                    result = await DisplayAlert("Перейти на карту", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://yandex.ru/maps/org/punkt_vaktsinatsii_v_tts_tsum/135606012147/?display-text=Пункты%20%20вакцинации%20от%20COVID-19&ll=49.138066%2C55.802864&mode=search&sll=49.138066%2C55.802775&text=category_id%3A%2827849046009%29&z=11"));
                    }
                    picker2.SelectedIndex = -1;
                    break;
                case 6:
                    result = await DisplayAlert("Перейти на карту", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://yandex.ru/maps/org/punkt_vaktsinatsii_v_kdts_na_chetayeva/5376155415/?display-text=Пункты%20%20вакцинации%20от%20COVID-19&ll=49.138066%2C55.802864&mode=search&sll=49.138066%2C55.802775&text=category_id%3A%2827849046009%29&z=11"));
                    }
                    picker2.SelectedIndex = -1;
                    break;
                case 7:
                    result = await DisplayAlert("Перейти на карту", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://yandex.ru/maps/org/punkt_vaktsinatsii_v_gosudarstvennoye_avtonomnoye_uchrezhdeniye_zdravookhraneniya_gorodskaya_poliklinika_10_g_kazani/146325266541/?display-text=Пункты%20%20вакцинации%20от%20COVID-19&ll=49.138066%2C55.802864&mode=search&sll=49.138066%2C55.802775&text=category_id%3A%2827849046009%29&z=11"));
                    }
                    picker2.SelectedIndex = -1;
                    break;
                case 8:
                    result = await DisplayAlert("Перейти на карту", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://yandex.ru/maps/org/punkt_vaktsinatsii_v_gosudarstvennoye_avtonomnoye_uchrezhdeniye_zdravookhraneniya_gorodskaya_poliklinika_7_g_kazani/198237919364/?display-text=Пункты%20%20вакцинации%20от%20COVID-19&ll=49.138066%2C55.802864&mode=search&sll=49.138066%2C55.802775&text=category_id%3A%2827849046009%29&z=11"));
                    }
                    picker2.SelectedIndex = -1;
                    break;
                case 9:
                    result = await DisplayAlert("Перейти на карту", null, "Да", "Нет");
                    if (result)
                    {
                        await Launcher.OpenAsync(new Uri("https://yandex.ru/maps/org/punkt_vaktsinatsii_v_gosudarstvennoye_avtonomnoye_uchrezhdeniye_zdravookhraneniya_tsentralnaya_gorodskaya_klinicheskaya_bolnitsa_18/117087547256/?display-text=Пункты%20%20вакцинации%20от%20COVID-19&ll=49.138066%2C55.802864&mode=search&sll=49.138066%2C55.802775&text=category_id%3A%2827849046009%29&z=11"));
                    }
                    picker2.SelectedIndex = -1;
                    break;

            }
        }
    }
}