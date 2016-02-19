﻿using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplesLiveChartsWPF
{
    class ViewModelBase : INotifyPropertyChanged
    {
        SeriesCollection series = new SeriesCollection();
        List<string> labels = new List<string>();
        SeriesCollection seriesBar = new SeriesCollection();
        SeriesCollection seriesPie = new SeriesCollection();
        SeriesCollection seriesRadar = new SeriesCollection();

        public SeriesCollection Series
        {
            get
            {
                return series;
            }

            set
            {
                series = value;
                RaisePropertyChanged("Series");
            }
        }

        public List<string> Labels
        {
            get
            {
                return labels;
            }

            set
            {
                labels = value;
                RaisePropertyChanged("Labels");
            }
        }

        public SeriesCollection SeriesBar
        {
            get
            {
                return seriesBar;
            }

            set
            {
                seriesBar = value;
                RaisePropertyChanged("SeriesBar");
            }
        }

        public SeriesCollection SeriesPie
        {
            get
            {
                return seriesPie;
            }

            set
            {
                seriesPie = value;
                RaisePropertyChanged("SeriesPie");
            }
        }

        public SeriesCollection SeriesRadar
        {
            get
            {
                return seriesRadar;
            }

            set
            {
                seriesRadar = value;
                RaisePropertyChanged("SeriesRadar");
            }
        }

        public ViewModelBase()
        {
            List<double> data = new List<double>();
            data.Add(5);
            data.Add(6);
            data.Add(7);
            data.Add(5);
            data.Add(4);
            data.Add(3);
            Labels = new List<string>();
            Labels.Add("Pedro");
            Labels.Add("Juan");
            Labels.Add("Diego");
            Labels.Add("Pablo");
            Labels.Add("Marcos");
            Labels.Add("Manuel");

            ChartValues<double> cv = new ChartValues<double>();
            cv.AddRange(data);

            var lineSerie = new LineSeries
            {
                Title = "Values",
                Values = cv,
            };

            Series.Clear();
            Series.Add(lineSerie);

            var barSerie = new BarSeries
            {
                Title = "Values",
                Values = cv,
            };

            SeriesBar.Clear();
            SeriesBar.Add(barSerie);

            var pieSerie = new PieSeries
            {
                Title = "Values",
                Values = cv,
            };

            SeriesPie.Clear();
            SeriesPie.Add(pieSerie);

            var radarSerie = new RadarSeries
            {
                Title = "Values",
                Values = cv,
            };

            SeriesRadar.Clear();
            SeriesRadar.Add(radarSerie);
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler temp = PropertyChanged;
            if (temp != null)
            {
                temp(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
