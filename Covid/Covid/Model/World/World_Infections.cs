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

namespace Covid.Model.World
{
    class World_Infections
    {
        public PlotModel PieModel { get; set; }

        public World_Infections(int a)
        {
            PieModel = CreatePieChart(a);
        }

        private PlotModel CreatePieChart(int a)
        {
            string[] britain_arr = new string[685];
            string[] germany_arr = new string[685];
            string[] iran_arr = new string[685];
            string[] spain_arr = new string[685];
            string[] italy_arr = new string[685];
            string[] china_arr = new string[685];
            string[] russia_arr = new string[685];
            string[] usa_arr = new string[685];
            int i = 0;
            
            var plotModel1 = new PlotModel();
            int b = 0;
            var britainlineSeries = new LineSeries
            {
                Title = "Великобритания",

                MarkerType = MarkerType.Circle,

                MarkerSize = 2,

                MarkerStroke = OxyColors.White
            };
            var germanylineSeries = new LineSeries
            {
                Title = "Германия",

                MarkerType = MarkerType.Cross,

                MarkerSize = 2,

                MarkerStroke = OxyColors.DarkRed
            };
            var iranlineSeries = new LineSeries
            {
                Title = "Иран",

                MarkerType = MarkerType.Diamond,

                MarkerSize = 2,

                MarkerStroke = OxyColors.Green
            };
            var spainlineSeries = new LineSeries
            {
                Title = "Испания",

                MarkerType = MarkerType.Plus,

                MarkerSize = 2,

                MarkerStroke = OxyColors.Yellow
            };
            var italylineSeries = new LineSeries
            {
                Title = "Италия",

                MarkerType = MarkerType.Square,

                MarkerSize = 2,

                MarkerStroke = OxyColors.NavajoWhite
            };
            var chinalineSeries = new LineSeries
            {
                Title = "Китай",

                MarkerType = MarkerType.Star,

                MarkerSize = 2,

                MarkerStroke = OxyColors.IndianRed
            };
            var russialineSeries = new LineSeries
            {
                Title = "Великобритания",

                MarkerType = MarkerType.Triangle,

                MarkerSize = 2,

                MarkerStroke = OxyColors.Blue
            };
            var usalineSeries = new LineSeries
            {
                Title = "США",

                MarkerType = MarkerType.Circle,

                MarkerSize = 2,

                MarkerStroke = OxyColors.Aqua
            };
            AssetManager assets = Forms.Context.Assets;
            using (StreamReader reader = new StreamReader(assets.Open("infections.csv")))
            {
                if (reader != null)
                {
                    using (var csv = new CsvReader(reader, CultureInfo.CurrentCulture))
                    {
                        
                            while (b<=a && csv.Read())
                            {
                                var britain = csv.GetField(1);
                                britain_arr[i] = britain;
                                var germany = csv.GetField(2);
                                germany_arr[i] = germany;
                                var iran = csv.GetField(3);
                                iran_arr[i] = iran;
                                var spain = csv.GetField(4);
                                spain_arr[i] = spain;
                                var italy = csv.GetField(5);
                                italy_arr[i] = italy;
                                var china = csv.GetField(6);
                                china_arr[i] = china;
                                var russia = csv.GetField(7);
                                russia_arr[i] = russia;
                                var usa = csv.GetField(8);
                                usa_arr[i] = usa;
                                i++;
                                b++;
                            }
                        
                    }
                }
            }
            for (i = 1; i < a; i++)
            {
                britainlineSeries.Points.Add(new DataPoint(i, double.Parse(britain_arr[i])));
                germanylineSeries.Points.Add(new DataPoint(i, double.Parse(germany_arr[i])));
                iranlineSeries.Points.Add(new DataPoint(i, double.Parse(iran_arr[i])));
                spainlineSeries.Points.Add(new DataPoint(i, double.Parse(spain_arr[i])));
                italylineSeries.Points.Add(new DataPoint(i, double.Parse(italy_arr[i])));
                chinalineSeries.Points.Add(new DataPoint(i, double.Parse(china_arr[i])));
                russialineSeries.Points.Add(new DataPoint(i, double.Parse(russia_arr[i])));
                usalineSeries.Points.Add(new DataPoint(i, double.Parse(usa_arr[i])));
            }
            plotModel1.Series.Add(britainlineSeries);
            plotModel1.Series.Add(germanylineSeries);
            plotModel1.Series.Add(iranlineSeries);
            plotModel1.Series.Add(spainlineSeries);
            plotModel1.Series.Add(italylineSeries);
            plotModel1.Series.Add(chinalineSeries);
            plotModel1.Series.Add(russialineSeries);
            plotModel1.Series.Add(usalineSeries);
            return plotModel1;


        }
    }
}
