using LiveCharts;
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
            series.Add(lineSerie);

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
