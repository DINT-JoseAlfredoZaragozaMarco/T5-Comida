using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida.Modelo
{
    class Plato : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string comida;
        public string Comida
        {
            get { return comida; }
            set 
            { 
                comida = value;
                NotifyPropertyChanged("Comida");
            }
        }

        private string imagen;

        public string Imagen
        {
            get { return imagen; }
            set 
            {
                imagen = value;
                NotifyPropertyChanged("Imagen");
            }
        }

        private string nacionalidad;

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set
            {
                nacionalidad = value;
                NotifyPropertyChanged("Nacionalidad");
            }
        }

        private bool gluten;

        public bool Gluten
        {
            get { return gluten; }
            set 
            { 
                gluten = value;
                NotifyPropertyChanged("Gluten");
            }
        }

        private bool soja;

        public bool Soja
        {
            get { return soja; }
            set 
            { 
                soja = value;
                NotifyPropertyChanged("Soja");
            }
        }

        private bool leche;

        public bool Leche
        {
            get { return leche; }
            set 
            { 
                leche = value;
                NotifyPropertyChanged("Leche");
            }
        }

        private bool sulfitos;

        public bool Sulfitos
        {
            get { return sulfitos; }
            set 
            { 
                sulfitos = value;
                NotifyPropertyChanged("Sulfitos");
            }
        }

        public Plato(string comida, string imagen, string nacionalidad, bool gluten, bool soja, bool leche, bool sulfitos)
        {
            this.Comida = comida;
            this.Imagen = imagen;
            this.Nacionalidad = nacionalidad;
            this.Gluten = gluten;
            this.Soja = soja;
            this.Leche = leche;
            this.Sulfitos = sulfitos;
        }

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
