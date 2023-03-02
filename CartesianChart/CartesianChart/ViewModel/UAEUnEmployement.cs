using CartesianChart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartesianChart.ViewModel
{
     public class UAEUnEmployement
    {
        public List<UnemployeeRate> Data2 { get; set; }

        public UAEUnEmployement()
        {
            Data2 = new List<UnemployeeRate>()
            {
                new UnemployeeRate()
                {
                  Rate=43,
                  Year=new DateTime(2018,01,01)
                },
               new UnemployeeRate()
                {
                  Rate=20,
                  Year=new DateTime(2019,01,01)
                },
               new UnemployeeRate()
                {
                  Rate=65,
                  Year=new DateTime(2020,01,01)
                },

                 new UnemployeeRate()
                {
                  Rate=38,
                  Year=new DateTime(2021,01,01)
                },

               new UnemployeeRate()
                {
                  Rate=38,
                  Year=new DateTime(2022,01,01)
                }
            };
        }
    }
}
