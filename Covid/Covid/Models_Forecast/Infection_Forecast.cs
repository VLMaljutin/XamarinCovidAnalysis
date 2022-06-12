using Accord.Statistics.Models.Regression.Linear;
using Android.Content.Res;
using CsvHelper;
using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace Covid.Models_Forecast
{
    class Infection_Forecast

    {
        public PlotModel PieModel { get; set; }

        public Infection_Forecast()
        {

        }
        public Infection_Forecast(int i, int type, int view)
        {
            if (view == 1)
            {
                PieModel = CreatePieChart(i, type);
            }
            else if (view == 2)
            {
                PieModel = CreatePieChartDay(i, type);
            }
            
        }

        private PlotModel CreatePieChart(int i, int type)
        {
            List<string> country_arr = new List<string>();
            var plotModel1 = new PlotModel();
            var realSeries = new LineSeries
            {
                Title = "Реальное значение",

                MarkerType = MarkerType.Circle,

                MarkerSize = 2,

                MarkerStroke = OxyColors.White
            };
            var predlineSeries = new LineSeries
            {
                Title = "Прогноз",

                MarkerType = MarkerType.Cross,

                MarkerSize = 2,

                MarkerStroke = OxyColors.DarkRed
            };
            AssetManager assets = Forms.Context.Assets;
            using (StreamReader reader = new StreamReader(assets.Open("infections.csv")))
            {
                if (reader != null)
                {
                    using (var csv = new CsvReader(reader, CultureInfo.CurrentCulture))
                    {
                        while (csv.Read())
                        {
                            var country = csv.GetField(i);
                            country_arr.Add(country);
                        }
                    }
                }
            }
            double[] inputs = new double[country_arr.Count];
            double[] outputs = new double[country_arr.Count];
            for (int j = 1; j < inputs.Length; j++)
            {
                inputs[j] = j;
                outputs[j] = double.Parse(country_arr[j]);
            }
            if(type == 1)
            {
                OrdinaryLeastSquares ols = new OrdinaryLeastSquares();
                SimpleLinearRegression regression = ols.Learn(inputs, outputs);
                double[] pred = regression.Transform(inputs);
                for (int j = 1; j < country_arr.Count; j++)
                {
                    realSeries.Points.Add(new DataPoint(j, double.Parse(country_arr[j])));
                    predlineSeries.Points.Add(new DataPoint(j, pred[j]));

                }
            }
            else
            {
                var ls = new PolynomialLeastSquares()
                {
                    Degree = 2
                };
                PolynomialRegression regression = ls.Learn(inputs, outputs);
                double[] pred = regression.Transform(inputs);
                for (int j = 1; j < country_arr.Count; j++)
                {
                    realSeries.Points.Add(new DataPoint(j, double.Parse(country_arr[j])));
                    predlineSeries.Points.Add(new DataPoint(j, pred[j]));

                }
            }
            plotModel1.Series.Add(realSeries);
            plotModel1.Series.Add(predlineSeries);
            return plotModel1;
        }

        private PlotModel CreatePieChartDay(int i, int type)
        {
            List<string> country_arr = new List<string>();
            var plotModel1 = new PlotModel();
            var realSeries = new LineSeries
            {
                Title = "Реальное значение",

                MarkerType = MarkerType.Circle,

                MarkerSize = 2,

                MarkerStroke = OxyColors.White
            };
            var predlineSeries = new LineSeries
            {
                Title = "Прогноз",

                MarkerType = MarkerType.Cross,

                MarkerSize = 2,

                MarkerStroke = OxyColors.DarkRed
            };
            AssetManager assets = Forms.Context.Assets;
            using (StreamReader reader = new StreamReader(assets.Open("infections_day.csv")))
            {
                if (reader != null)
                {
                    using (var csv = new CsvReader(reader, CultureInfo.CurrentCulture))
                    {
                        while (csv.Read())
                        {
                            var country = csv.GetField(i);
                            country_arr.Add(country);
                        }
                    }
                }
            }
            double[] inputs = new double[country_arr.Count];
            double[] outputs = new double[country_arr.Count];
            for (int j = 1; j < inputs.Length; j++)
            {
                inputs[j] = j;
                outputs[j] = double.Parse(country_arr[j]);
            }
            if (type == 1)
            {
                OrdinaryLeastSquares ols = new OrdinaryLeastSquares();
                SimpleLinearRegression regression = ols.Learn(inputs, outputs);
                double[] pred = regression.Transform(inputs);
                for (int j = 1; j < country_arr.Count; j++)
                {
                    realSeries.Points.Add(new DataPoint(j, double.Parse(country_arr[j])));
                    predlineSeries.Points.Add(new DataPoint(j, pred[j]));

                }
            }
            else
            {
                var ls = new PolynomialLeastSquares()
                {
                    Degree = 2
                };
                PolynomialRegression regression = ls.Learn(inputs, outputs);
                double[] pred = regression.Transform(inputs);
                for (int j = 1; j < country_arr.Count; j++)
                {
                    realSeries.Points.Add(new DataPoint(j, double.Parse(country_arr[j])));
                    predlineSeries.Points.Add(new DataPoint(j, pred[j]));

                }
            }
            plotModel1.Series.Add(realSeries);
            plotModel1.Series.Add(predlineSeries);
            return plotModel1;
        }

        public List<string> DataInfections(int column)
        {
            List<string> country_arr = new List<string>();
            AssetManager assets = Forms.Context.Assets;
            using (StreamReader reader = new StreamReader(assets.Open("infections.csv")))
            {
                if (reader != null)
                {
                    using (var csv = new CsvReader(reader, CultureInfo.CurrentCulture))
                    {
                        while (csv.Read())
                        {
                            var country = csv.GetField(column);
                            country_arr.Add(country);
                        }
                    }
                }
            }
            return country_arr;
        }
        public List<string> DataInfectionsDay(int column)
        {
            List<string> country_arr = new List<string>();
            AssetManager assets = Forms.Context.Assets;
            using (StreamReader reader = new StreamReader(assets.Open("infections_day.csv")))
            {
                if (reader != null)
                {
                    using (var csv = new CsvReader(reader, CultureInfo.CurrentCulture))
                    {
                        while (csv.Read())
                        {
                            var country = csv.GetField(column);
                            country_arr.Add(country);
                        }
                    }
                }
            }
            return country_arr;
        }

    }
}
