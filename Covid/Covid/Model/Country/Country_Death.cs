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

namespace Covid.Model.Country
{
    class Country_Death
    {
        public PlotModel PieModel { get; set; }

        public Country_Death(int a, int b, int i)
        {
            PieModel = CreatePieChart(a, b, i);
        }

        private PlotModel CreatePieChart(int a, int b, int i)
        {
            List<string> country_arr = new List<string>();
            var plotModel1 = new PlotModel();
            var lineSeries1 = new LineSeries
            {

                MarkerType = MarkerType.Circle,

                MarkerSize = 2,

                MarkerStroke = OxyColors.White
            };
            AssetManager assets = Forms.Context.Assets;
            using (StreamReader reader = new StreamReader(assets.Open("death.csv")))
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

            for (int j = a; j < b; j++)
            {
                lineSeries1.Points.Add(new DataPoint(j, double.Parse(country_arr[j])));

            }
            plotModel1.Series.Add(lineSeries1);
            return plotModel1;
        }
    }
}
