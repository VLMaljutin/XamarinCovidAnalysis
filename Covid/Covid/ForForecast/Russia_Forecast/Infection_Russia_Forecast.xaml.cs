using Accord.Math.Optimization.Losses;
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
        public int type;
        public Infection_Russia_Forecast()
        {
            InitializeComponent();
        }
        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            Infection_Forecast inf_forecast = new Infection_Forecast();
            List<string> data = inf_forecast.DataInfections(7);
            DateTime date = new DateTime(2022, 5, 21);
            int a = date.Subtract(e.NewDate).Days;
            if (a>=0){
                double[] inputs = new double[data.Count - a];
                double[] outputs = new double[data.Count - a];
                double[] pred = new double[outputs.Length];
                real.Text = "";
                prediction.Text = "";
                error.Text = "";
                for (int i = 1; i < inputs.Length; i++)
                {
                    inputs[i] = i;
                    outputs[i] = double.Parse(data[i]);
                }
                if (type == 1)
                {
                    OrdinaryLeastSquares ols = new OrdinaryLeastSquares();
                    SimpleLinearRegression regression = ols.Learn(inputs, outputs);
                    pred = regression.Transform(inputs);
                }
                else if (type == 2)
                {
                    var ls = new PolynomialLeastSquares()
                    {
                        Degree = 2
                    };
                    PolynomialRegression poly = ls.Learn(inputs, outputs);
                    pred = poly.Transform(inputs);
                }
                double error_one = new AccuracyLoss(outputs).Loss(pred);
                real.Text = "Реальное значение " + outputs[outputs.Length - 1].ToString();
                prediction.Text = "Прогноз " + ((int)pred[pred.Length - 1]).ToString();
                error.Text = "Точность прогноза " + (100 * Math.Round(1 - error_one, 4)).ToString() + "%";
            }
            else
            {
                double[] inputs = new double[data.Count];
                double[] outputs = new double[data.Count];
                double pred;
                real.Text = "";
                prediction.Text = "";
                error.Text = "";
                for (int i = 1; i < inputs.Length; i++)
                {
                    inputs[i] = i;
                    outputs[i] = double.Parse(data[i]);
                }
                if (type == 1)
                {
                    OrdinaryLeastSquares ols = new OrdinaryLeastSquares();
                    SimpleLinearRegression regression = ols.Learn(inputs, outputs);
                    pred = regression.Transform(inputs.Length-a);
                    prediction.Text = "Прогноз " + ((int)pred).ToString();
                }
                else if (type == 2)
                {
                    var ls = new PolynomialLeastSquares()
                    {
                        Degree = 2
                    };
                    PolynomialRegression poly = ls.Learn(inputs, outputs);
                    pred = poly.Transform(inputs.Length-a);
                    prediction.Text = "Прогноз " + ((int)pred).ToString();
                }
                real.Text = "Реальных данных нет";
            }
            
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = picker.SelectedIndex;
            switch (name)
            {
                case 0:
                    type = 1;
                    break;
                case 1:
                    type = 2;
                    break;
            }
        }
    }
}