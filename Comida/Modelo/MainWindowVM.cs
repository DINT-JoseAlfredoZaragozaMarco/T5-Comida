﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida.Modelo
{
    class MainWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Plato> platos;

        public ObservableCollection<Plato> Platos
        {
            get { return platos; }
            set
            {
                platos = value;
                NotifyPropertyChanged("Personas");
            }
        }

        public MainWindowVM()
        {
            Platos = new ObservableCollection<Plato>();

            Plato hamburguesa = new Plato("Hamburguesa", "assets/burguer.jpg", "USA", true, false, true, true);
            Plato dumplings = new Plato("Dumplings", "assets/dumplings.jpg", "China", true, true, false, false);
            Plato tacos = new Plato("Tacos", "assets/tacos.jpg", "USA", true, false, false, true);
            Plato cerdoAgridulce = new Plato("Cerdo Agridulce", "assets/cerdoagridulce.jpg", "USA", true, true, false, true);
            Plato hotDogs = new Plato("Hot Dogs", "assets/hotdog.jpg", "USA", true, true, true, true);
            Plato fajitas = new Plato("Fajitas", "assets/fajitas.jpg", "USA", true, false, false, true);

            Platos.Add(hamburguesa);
            Platos.Add(dumplings);
            Platos.Add(tacos);
            Platos.Add(cerdoAgridulce);
            Platos.Add(hotDogs);
            Platos.Add(fajitas);
        }

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}