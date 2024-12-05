using AnimalManagementSystem.Entity;
using AnimalManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AnimalManagementSystem.ViewModel
{
    public class ForageCalculatorViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Forage> _forages;
        private double _ingestionCapacity;
        private string _alertMessage;
        private Color _alertColor;

        public event PropertyChangedEventHandler PropertyChanged;

        public ForageCalculatorViewModel()
        {
            Forages = new ObservableCollection<Forage>(ForageData.GetDefaultForages());
            UpdateTotalCommand = new Command(CalculateTotal);
        }

        public ObservableCollection<Forage> Forages
        {
            get => _forages;
            set
            {
                _forages = value;
                OnPropertyChanged();
            }
        }
        public double IngestionCapacity
        {
            get => _ingestionCapacity;
            set
            {
                _ingestionCapacity = value;
                OnPropertyChanged();
                CalculateTotal();
            }
        }
        public string AlertMessage
        {
            get => _alertMessage;
            set
            {
                _alertMessage = value;
                OnPropertyChanged();
            }
        }
        public Color AlertColor
        {
            get => _alertColor;
            set
            {
                _alertColor = value;
                OnPropertyChanged();
            }
        }

        public ICommand UpdateTotalCommand { get; }

        public double totale => Forages.Sum(f => f.KgMs);

        private void CalculateTotal()
        {
            double total = totale;

            if (IngestionCapacity == 0)
            {
                AlertMessage = "Veuillez entrer la capacité d'ingestion";
                AlertColor = Colors.Orange;
                return;
            }

            if (total < IngestionCapacity)
            {
                AlertMessage = "La capacité d'ingestion de votre vache n'est pas saturée. Augmentez la quantité des fourrages distribuées.";
                AlertColor = Colors.Red;
            }
            else if (total > IngestionCapacity)
            {
                AlertMessage = "La capacité d'ingestion de votre vache est sursaturée. Diminuer la quantité des fourrages distribuées.";
                AlertColor = Colors.Red;
            }
            else
            {
                AlertMessage = "La ration est équilibrée.";
                AlertColor = Colors.Green;
            }

            OnPropertyChanged(nameof(totale));
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
