using CartesianChart.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartesianChart.ViewModel
{
    internal class UnemployeementViewModel
    {
       
        public List<Brush> BrushList { get; set; }
        public ObservableCollection<UnemployeeRate> Data { get; set; }

        public List<string> fillColor { get; set; }

        public UnemployeementViewModel()
        {
            Data = new ObservableCollection<UnemployeeRate>()
            {
                new UnemployeeRate()
                {
                  Rate=23,
                  UAERate=61,
                  Year=new DateTime(2018,01,01)
                },
               new UnemployeeRate()
                {
                  Rate=32,
                  UAERate=72,
                  Year=new DateTime(2019,01,01)
                },
               new UnemployeeRate()
                {
                  Rate=-45,
                  UAERate=50,
                  Year=new DateTime(2020,01,01)
                },

                 new UnemployeeRate()
                {
                  Rate=30,
                  UAERate=65,
                  Year=new DateTime(2021,01,01)
                },

               new UnemployeeRate()
                {
                  Rate=-53,
                  UAERate=65,
                  Year=new DateTime(2022,01,01)
                },
                new UnemployeeRate()
                {
                  Rate=23,
                  UAERate=61,
                  Year=new DateTime(2023,01,01)
                },
               new UnemployeeRate()
                {
                  Rate=32,
                  UAERate=72,
                  Year=new DateTime(2024,01,01)
                },
               new UnemployeeRate()
                {
                  Rate=-45,
                  UAERate=50,
                  Year=new DateTime(2025,01,01)
                },

                 new UnemployeeRate()
                {
                  Rate=30,
                  UAERate=65,
                  Year=new DateTime(2026,01,01)
                },

               new UnemployeeRate()
                {
                  Rate=-53,
                  UAERate=65,
                  Year=new DateTime(2027,01,01)
                }
            };



            BrushList = new List<Brush>();
            BrushList.Add(new SolidColorBrush(Color.FromRgb(255, 0, 255)));
            BrushList.Add(new SolidColorBrush(Color.FromRgb(0,255,255)));
            BrushList.Add(new SolidColorBrush(Color.FromRgb(0, 128, 0)));
            BrushList.Add(new SolidColorBrush(Color.FromRgb(255, 0, 0)));
            BrushList.Add(new SolidColorBrush(Color.FromRgb(128, 0, 0)));

            fillColor = new List<string>
        {
           "red",
           "green",
           "blue"
        };

          

        }
    }
}
