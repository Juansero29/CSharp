using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace giContacts
{
    public enum TéléphoneType
    {
        Inconnu,
        Mobile,
        Domicile,
        Travail,
        Fax
    }
    
    /// <summary>
    /// un numéro de téléphone d'une personne
    /// </summary>
    public class Téléphone: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(String info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
            }
        }

        /// <summary>
        /// le type de ce numéro de téléphone
        /// </summary>
        public TéléphoneType Type
        {
            get
            {
                return mType;
            }
            set
            {
                if (mType != value)
                {
                    mType = value;
                    OnPropertyChanged("Type");
                }
            }
        }
        private TéléphoneType mType;

        /// <summary>
        /// le numéro de téléphone
        /// </summary>
        public string Numéro
        {
            get
            {
                return mNuméro;
            }
            set
            {
                if (mNuméro != value)
                {
                    mNuméro = value;
                    OnPropertyChanged("Numéro");
                }
            }
        }
        private string mNuméro;
    }
}
