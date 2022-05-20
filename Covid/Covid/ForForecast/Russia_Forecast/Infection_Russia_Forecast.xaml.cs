using Accord.Statistics.Models.Regression.Linear;
using Covid.Models_Forecast;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid.ForForecast.Russia_Forecast
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Infection_Russia_Forecast : ContentPage
    {
        public Infection_Russia_Forecast()
        {
            InitializeComponent();
        }

        private void Tap_Clicked(object sender, EventArgs e)
        {
            Infection_Forecast inf_forecast = new Infection_Forecast();
            List<string> data = inf_forecast.DataInfections(7);
            double[] inputs = new double[data.Count];
            double[] outputs = new double[data.Count];
            for (int i = 1; i < data.Count; i++)
            {
                inputs[i] = i;
                outputs[i] = double.Parse(data[i]);
            }
            OrdinaryLeastSquares ols = new OrdinaryLeastSquares();
            SimpleLinearRegression regression = ols.Learn(inputs, outputs);
            int a = int.Parse(Number.Text);
            double y = regression.Transform(a);
            var b = (int)y;
            real.Text = data[a];
            result.Text = b.ToString();

        }
    }
}