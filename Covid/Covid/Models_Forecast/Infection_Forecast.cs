using Android.Content.Res;
using CsvHelper;
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
    }
}
