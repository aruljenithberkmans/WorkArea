using CartesianChart.Model;
using CartesianChart.ViewModel;
using Syncfusion.Maui.Charts;
using System;
using System.Collections.ObjectModel;

namespace CartesianChart;

public partial class MainPage : ContentPage
{
    //UnemployeementViewModel viewModel=new UnemployeementViewModel();

   
    ObservableCollection<UnemployeeRate> Unemployees { get; set; }
	public MainPage()
	{
		InitializeComponent();

        /* StackLayout layout= new StackLayout();

         layout.Orientation = StackOrientation.Vertical;

        SfCartesianChart chart= new SfCartesianChart();

         chart.Title = new Label
         {
             Text = "UnEmployeement Rate"
         };

         chart.Legend = new ChartLegend();

         chart.TrackballBehavior=new ChartTrackballBehavior();
         chart.ZoomPanBehavior=new ChartZoomPanBehavior();
         //SeriesSelectionBehavior seriesSelectionBehavior = new SeriesSelectionBehavior();
         //seriesSelectionBehavior.SelectionBrush = Color.FromArgb("#314A6E");

         DataPointSelectionBehavior dataPointSelection= new DataPointSelectionBehavior();
         dataPointSelection.Type = ChartSelectionType.SingleDeselect;
         dataPointSelection.SelectionBrush = Color.FromArgb("#008000");

        DateTimeAxis primaryAxis=new DateTimeAxis();
         primaryAxis.Title = new ChartAxisTitle
         {
             Text = "Year"
         };
         primaryAxis.PlotOffsetStart = 10;
         primaryAxis.PlotOffsetEnd = 10;
         primaryAxis.ShowTrackballLabel = true;
         primaryAxis.RangePadding = DateTimeRangePadding.Additional;

         chart.XAxes.Add(primaryAxis);

         NumericalAxis secondaryAxis=new NumericalAxis();
         secondaryAxis.Title = new ChartAxisTitle
         {
             Text = "Rate"
         };
         chart.YAxes.Add(secondaryAxis);

         StepLineSeries stepLineSeries = new StepLineSeries()
         {
             Label="US Unemployement Rate",
             ItemsSource =viewModel.Data,
             XBindingPath="Year",
             YBindingPath="Rate",
             LegendIcon=ChartLegendIconType.Circle,
             ShowMarkers=true,
             EnableAnimation=true,
             EnableTooltip=true,
             ShowTrackballLabel=true,
             SelectionBehavior=dataPointSelection

         };

         chart.Series.Add(stepLineSeries);

         this.Content= chart;



         Button button = new Button
         {
             Text = "Add",


         };

         button.Clicked += AddDataPointClicked;
         layout.Children.Add(chart);

         layout.Children.Add(button);
         */

        /*  Unemployees = new ObservableCollection<UnemployeeRate>()
              {
                  new UnemployeeRate()
                  {
                    Rate=56,
                    UAERate=61,
                    Year=new DateTime(2018,01,01)
                  },
                 new UnemployeeRate()
                  {
                    Rate=73,
                    UAERate=72,
                    Year=new DateTime(2019,01,01)
                  },
                 new UnemployeeRate()
                  {
                    Rate=45,
                    UAERate=50,
                    Year=new DateTime(2020,01,01)
                  }


               };*/


       

    }


    public void TooltipTemplateClick(object sender, EventArgs e)
    {
        DataTemplate template = new DataTemplate(() =>
        {
        StackLayout stacklayout = new StackLayout();
        Label label = new Label();
        label.SetBinding(Label.TextProperty, new Binding("Item.Year"));
            label.TextColor = Color.FromRgb(255, 255, 255);
        stacklayout.Children.Add(label);
        return stacklayout;
        });

        Stepline.TooltipTemplate = template;

    }

    public void PalettebrushClick(object sender, EventArgs e)
    {
        Stepline.PaletteBrushes = viewModel.BrushList;
       
    }

  /*  public void LegendtemplateClick(object sender, EventArgs e)
    {
        DataTemplate template = new DataTemplate(() =>
        {
            StackLayout stacklayout = new StackLayout();
            BoxView box = new BoxView();
            box.BackgroundColor= Color.FromRgb(255,255,255);
            stacklayout.Children.Add(box);
            return stacklayout;
        });

        ChartLegend legend=new ChartLegend();
        legend.ItemTemplate= template;
        
    }*/


    //private void Button_Clicked(object sender, EventArgs e)
    //{

    //    //Stepline.ItemsSource = viewModel.Data;
    //    //Stepline.XBindingPath = "Year";
    //    //Stepline.YBindingPath = "Rate";
    //    //Stepline.EnableTooltip = true;


    //}

    /* private void Switch_Toggled(object sender, ToggledEventArgs e)
     {

         //if (UAERate.IsVisible)
         //{
         //    UAERate.IsVisible = false;

         //}
         //else
         //{
         //    UAERate.IsVisible = true;
         //}
     }
 */
    /*    private void AddSeriesClicked(object sender, EventArgs e)
        {
            Charts.Series.Insert(0, new StepLineSeries()
            {
                ItemsSource = viewModel.Data,
                XBindingPath = "Year",
                YBindingPath = "UAERate",
                // PaletteBrushes = viewModel.BrushList,
                EnableAnimation = true,
                ShowDataLabels = true,
                EnableTooltip = true,
                Label = "UAE Unemployee Rate",
                ShowMarkers = true,
                StrokeWidth = 5
            });

            //Charts.Series.Remove(Stepline);


        }*/

    private void AddDataPointClicked(object sender, EventArgs e)
    {
        var unEmployee = new UnemployeeRate()
        {
            Rate = 30,
            Year = new DateTime(2023, 01, 01)
        };

        viewModel.Data.Add(unEmployee);

        // Stepline.EnableAnimation=false;
        //Stepline.ItemsSource = viewModel.Data;
    }

    private void AddAnotherPoints(object sender, EventArgs e)
    {
        viewModel.Data.Add(new UnemployeeRate()
        {
            Rate = 67,
            Year = new DateTime(2024, 01, 01)
        });
    }

    private void InsertDataPointFirstIndexClicked(object sender, EventArgs e)
    {
        // viewModel.Data.RemoveAt(0);
        viewModel.Data.Insert(4, new UnemployeeRate()
        {
            Rate = 40,
            Year = new DateTime(2021, 10, 01)

        });

       

    }

    private void LegendIconChangeClicked(object sender, EventArgs e)
    {
        Stepline.LegendIcon = ChartLegendIconType.Hexagon;
    }

    private void TooltipTemplateChangeClicked(object sender, EventArgs e)
    {
        Stepline.Label = "Salary data";
    }

    private void NullPalettebrushClicked(object sender, EventArgs e)
    {
        Stepline.PaletteBrushes = null;
        
    }

    private void DynamicallychangeBindingPath(object sender, EventArgs e)
    {
        //Stepline.XBindingPath = "Year";
        //Stepline.YBindingPath = "UAERate";
        Stepline.YAxisName = "SecondAxis";


    }

    /*  private void RemoveDataPointFirstIndexClicked(object sender, EventArgs e)
      {
          viewModel.Data.RemoveAt(0);
          Stepline.ItemsSource = viewModel.Data;
      }

      private void ClearSeriesItemSourceClicked(object sender, EventArgs e)
      {
          viewModel.Data.Clear();

          Stepline.ItemsSource = viewModel.Data;

      }*/

    /*private void ClickForItemSourceNull(object sender, EventArgs e)
    {
        Stepline.ItemsSource = null;
    }*/

    //private void ClickEventForReplace(object sender, EventArgs e)
    //{
    //    Stepline.ItemsSource = Unemployees;
    //}

    /* private void ClearItemSourceOfSeries(object sender, EventArgs e)
     {
         viewModel.Data.Clear();
         Stepline.ItemsSource= viewModel.Data;
     }*/
}

