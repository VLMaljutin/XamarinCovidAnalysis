using Android.Content.Res;
using CsvHelper;
using CsvHelper.Configuration;
using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace Covid.Model
{
    class Test
    {   
        public PlotModel PieModel { get; set; }

        public Test()
        {
            PieModel = CreatePieChart();
        }

        private PlotModel CreatePieChart()
        {
            string[] britain_arr = new string[685];
            //string[] germany_arr = new string[685];
            //string[] clock = new string[685];
            int i = 0;
            var plotModel1 = new PlotModel();
            

            var lineSeries1 = new LineSeries
            {
                Title = "Великобритания",

                MarkerType = MarkerType.Circle,

                MarkerSize = 2,

                MarkerStroke = OxyColors.White
            };
            //var lineSeries2 = new LineSeries
            //{
            //    Title = "Германия",

            //    MarkerType = MarkerType.Diamond,

            //    MarkerSize = 2,

            //    MarkerStroke = OxyColors.Red
            //};
            AssetManager assets = Forms.Context.Assets;
            using (StreamReader reader = new StreamReader(assets.Open("test.csv")))
            {
                if (reader != null)
                {
                    using (var csv = new CsvReader(reader, CultureInfo.CurrentCulture))
                    {
                        while (csv.Read())
                        {
                            var britain = csv.GetField(1);
                            var germany = csv.GetField(2);
                            britain_arr[i] = britain;
                            //germany_arr[i] = germany;
                            i++;
                        }
                    }
                }

            }

            for (i = 1; i < britain_arr.Length; i++)
            {
                lineSeries1.Points.Add(new DataPoint(i, double.Parse(britain_arr[i])));
                //lineSeries2.Points.Add(new DataPoint(i, double.Parse(germany_arr[i])));
            }
            plotModel1.Series.Add(lineSeries1);
            //plotModel1.Series.Add(lineSeries2);
            return plotModel1;
        }
    }
}
