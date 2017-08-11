using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace giContacts
{
    /// <summary>
    /// une adresse d'une personne
    /// </summary>
    public class Adresse : INotifyPropertyChanged
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
        /// le numéro de la maison ou du bâtiment dans la rue
        /// </summary>
        public int Numéro
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
        private int mNuméro;

        /// <summary>
        /// le nom de la rue
        /// </summary>
        public string Rue
        {
            get
            {
                return mRue;
            }
            set
            {
                if (mRue != value)
                {
                    mRue = value;
                    OnPropertyChanged("Rue");
                }
            }
        }
        private string mRue;

        /// <summary>
        /// la ville
        /// </summary>
        public string Ville
        {
            get
            {
                return mVille;
            }
            set
            {
                if (mVille != value)
                {
                    mVille = value;
                    OnPropertyChanged("Ville");
                }
            }
        }
        private string mVille;

        /// <summary>
        /// le code postal
        /// </summary>
        public int CodePostal
        {
            get
            {
                return mCodePostal;
            }
            set
            {
                if (value < 0 || value > 99999)
                {
                    return;
                }
                if (mCodePostal != value)
                {
                    mCodePostal = value;
                    OnPropertyChanged("CodePostal");
                }
            }
        }
        /// <see cref="CodePostal"/>
        private int mCodePostal;

        /// <summary>
        /// les différents types d'Adresse possibles
        /// </summary>
        public enum AdresseType
        {
            Inconnu,
            Domicile,
            Travail
        }

        /// <summary>
        /// le type de cette adresse
        /// </summary>
        public AdresseType Type
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
        private AdresseType mType;
    }
}
