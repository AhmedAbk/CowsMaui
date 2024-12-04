using AnimalManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AnimalManagementSystem.ViewModel
{
  
        public class CalculFourrageViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<Forage> Forages { get; set; }
            private string _alertMessage;
            private double _ci;  
            public string AlertMessage
            {
                get => _alertMessage;
                set
                {
                    _alertMessage = value;
                    OnPropertyChanged();
                }
            }

            public double TotalKgMS => Forages.Sum(f => f.KgMS);

            public double CI
            {
                get => _ci;
                set
                {
                    _ci = value;
                    OnPropertyChanged();
                    UpdateAlertMessage();
                }
            }

            public CalculFourrageViewModel()
            { 
                Forages = new ObservableCollection<Forage>
            {
                new Forage { Name = "Betteraves Fourragères", PercentMS = 13 },
                new Forage { Name = "Paille de Pois", PercentMS = 86 },
                new Forage { Name = "Paille d'Avoine", PercentMS = 88 },
                new Forage { Name = "Paille d'Orge", PercentMS = 88 },
                new Forage { Name = "Paille de Blé", PercentMS = 88 },
                new Forage { Name = "Paille de Colza", PercentMS = 88 }
            };
            }

            public void UpdateAlertMessage()
            {
                if (TotalKgMS < CI)
                {
                    AlertMessage = "Alerte : La capacité d’ingestion de votre vache n’est pas saturée. Augmentez la quantité des fourrages distribuées.";
                }
                else if (TotalKgMS > CI)
                {
                    AlertMessage = "Alerte : La capacité d’ingestion de votre vache est sursaturée. Diminuez la quantité des fourrages distribuées.";
                }
                else
                {
                    AlertMessage = string.Empty;
                }

                OnPropertyChanged(nameof(TotalKgMS));
            }

            public event PropertyChangedEventHandler PropertyChanged;

            protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

