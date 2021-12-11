using Android.Content.Res;
using CsvHelper;

using OxyPlot;
using OxyPlot.Series;
using System;

using System.Globalization;
using System.IO;

using Xamarin.Forms;

namespace Covid.Model
{
    class Britain_Infections
    {   
        public PlotModel PieModel { get; set; }

        public Britain_Infections()
        {
            PieModel = CreatePieChart();
        }

        private PlotModel CreatePieChart()
        {
            string[] britain_arr = new string[685];
           
            int i = 0;
            var plotModel1 = new PlotModel();
            

            var lineSeries1 = new LineSeries
            {
                Title = "Великобритания",

                MarkerType = MarkerType.Circle,

                MarkerSize = 2,

                MarkerStroke = OxyColors.White
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
                            var britain = csv.GetField(1);
                            britain_arr[i] = britain;
                            i++;
                        }
                    }
                }

            }

            for (i = 1; i < britain_arr.Length; i++)
            {
                lineSeries1.Points.Add(new DataPoint(i, double.Parse(britain_arr[i])));
                
            }
            plotModel1.Series.Add(lineSeries1);
            return plotModel1;
        }
    }
}
