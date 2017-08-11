using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace giContacts
{
    /// <summary>
    /// une personne
    /// </summary>
    public class Personne : INotifyPropertyChanged
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
        /// le nom de cette personne
        /// </summary>
        public string Nom
        {
            get
            {
                return mNom;
            }
            set
            {
                if (mNom != value)
                {
                    mNom = value;
                    OnPropertyChanged("Nom");
                }
            }
        }
        /// <see cref="Nom"/>
        private string mNom;

        /// <summary>
        /// le prénom de cette personne
        /// </summary>
        public string Prénom
        {
            get
            {
                return mPrénom;
            }
            set
            {
                if (mPrénom != value)
                {
                    mPrénom = value;
                    OnPropertyChanged("Prénom");
                }
            }
        }
        /// <see cref="Nom"/>
        private string mPrénom;

        /// <summary>
        /// la photo de cette personne
        /// </summary>
        public string ImageSource
        {
            get
            {
                return mImageSource;
            }
            set
            {
                if (mImageSource != value)
                {
                    mImageSource = value;
                    OnPropertyChanged("ImageSource");
                }
            }
        }
        /// <see cref="ImageSource"/>
        private string mImageSource;

        /// <summary>
        /// les numéros de téléphone de cette personne
        /// </summary>
        public ObservableCollection<Téléphone> Téléphones
        {
            get
            {
                return mTéléphones;
            }
        }
        /// <see cref="Téléphones"/>
        private ObservableCollection<Téléphone> mTéléphones = new ObservableCollection<Téléphone>();

        public int NbTéléphones
        {
            get
            {
                return mTéléphones.Count;
            }
        }

        /// <summary>
        /// les adresses de cette personne
        /// </summary>
        public ObservableCollection<Adresse> Adresses
        {
            get
            {
                return mAdresses;
            }
        }
        /// <see cref="Adresses"/>
        private ObservableCollection<Adresse> mAdresses = new ObservableCollection<Adresse>();

        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="prénom">prénom de cette personne</param>
        /// <param name="nom">nom de cette personne</param>
        /// <param name="téléphones">les différents téléphones de cette personne</param>
        /// <param name="adresses">les différentes adresses de cette personne</param>
        /// <param name="imageSource">la photo de cette personne</param>
        public Personne(string prénom, string nom, Téléphone[] téléphones, Adresse[] adresses, string imageSource)
        {
            Prénom = prénom;
            Nom = nom;
            téléphones.ToList().ForEach(tel => mTéléphones.Add(tel));
            //mTéléphones.AddRange(téléphones);
            adresses.ToList().ForEach(adr => mAdresses.Add(adr));
            //mAdresses.AddRange(adresses);
            ImageSource = imageSource;

            mTéléphones.CollectionChanged += (sender, args) =>
            {
                if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add
                    || args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove
                    || args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
                {
                    OnPropertyChanged("NbTéléphones");
                }
            };
        }

        /// <summary>
        /// les personnes
        /// </summary>
        public static List<Personne> Personnes = new List<Personne>{
            new Personne("Angela", "Kinsey", 
                         new Téléphone[]{ new Téléphone{Type = TéléphoneType.Domicile, Numéro = "0123456789"}, 
                                          new Téléphone{Type = TéléphoneType.Mobile, Numéro="0678901234"}},
                         new Adresse[] { new Adresse{Type = Adresse.AdresseType.Domicile, Numéro=13, Rue="Street of Somewhere", CodePostal=12345, Ville="Scranton"}, 
                                         new Adresse{Type = Adresse.AdresseType.Travail, Numéro=26, Rue="Street of Nowhere", CodePostal=2345, Ville="Scranton"}},
                         "Angela_Kinsey.jpg"),
            new Personne("Brian", "Baumgartner", 
                         new Téléphone[]{ new Téléphone{Type = TéléphoneType.Domicile, Numéro = "2837465891"}, 
                                          new Téléphone{Type = TéléphoneType.Mobile, Numéro="0682930461"}},
                         new Adresse[] { new Adresse{Type = Adresse.AdresseType.Domicile, Numéro=14, Rue="Rue de Quelque part", CodePostal=23456, Ville="Une ville"}, 
                                         new Adresse{Type = Adresse.AdresseType.Travail, Numéro=27, Rue="Rue de MontKhud", CodePostal=3456, Ville="Pas loin"}},
                         "brian_baumgartner.jpg"),
            new Personne("John", "Krasinski", 
                         new Téléphone[]{ new Téléphone{Type = TéléphoneType.Domicile, Numéro = "4038519773"}, 
                                          new Téléphone{Type = TéléphoneType.Mobile, Numéro="06529476329"},
                                          new Téléphone{Type = TéléphoneType.Travail, Numéro="+33 (0) 473177100"}},
                         new Adresse[] { new Adresse{Type = Adresse.AdresseType.Domicile, Numéro=15, Rue="Rue Perdue", CodePostal=34567, Ville="Machin"}, 
                                         new Adresse{Type = Adresse.AdresseType.Travail, Numéro=28, Rue="Boulevard du temps qui passe", CodePostal=7654, Ville="Bontemps"}},
                         "john_krasinski.jpg"),
            new Personne("Kate", "Flannery", 
                         new Téléphone[]{ new Téléphone{Type = TéléphoneType.Domicile, Numéro = "0987654321"}, 
                                          new Téléphone{Type = TéléphoneType.Mobile, Numéro="0695847362"}},
                         new Adresse[] { new Adresse{Type = Adresse.AdresseType.Domicile, Numéro=16, Rue="Rue de la Paix", CodePostal=45678, Ville="Monopoly"}, 
                                         new Adresse{Type = Adresse.AdresseType.Travail, Numéro=27, Rue="Rue de Tita Dong", CodePostal=8765, Ville="DongSong"}},
                         "Kate_Flannery.jpg"),
            new Personne("Leslie David", "Baker", 
                         new Téléphone[]{ new Téléphone{Type = TéléphoneType.Domicile, Numéro = "8208791247"}, 
                                          new Téléphone{Type = TéléphoneType.Mobile, Numéro="0617493096"}},
                         new Adresse[] { new Adresse{Type = Adresse.AdresseType.Domicile, Numéro=17, Rue="Rue de Septembre", CodePostal=56789, Ville="Rose"}, 
                                         new Adresse{Type = Adresse.AdresseType.Travail, Numéro=28, Rue="Rue de l'Amanite Phalloïde", CodePostal=9876, Ville="Queen"}},
                         "Leslie_David_Baker.jpg"),
            new Personne("Rainn", "Wilson", 
                         new Téléphone[]{ new Téléphone{Type = TéléphoneType.Domicile, Numéro = "8208791247"}, 
                                          new Téléphone{Type = TéléphoneType.Mobile, Numéro="0617493096"}},
                         new Adresse[] { new Adresse{Type = Adresse.AdresseType.Domicile, Numéro=18, Rue="Rue des gras", CodePostal=67890, Ville="Clermont-Ferrand"}, 
                                         new Adresse{Type = Adresse.AdresseType.Travail, Numéro=29, Rue="Impasse de chez moi", CodePostal=6878, Ville="Chez moi"}},
                         "Rainn_Wilson.jpg"),
            new Personne("Steve", "Carell", 
                         new Téléphone[]{ new Téléphone{Type = TéléphoneType.Domicile, Numéro = "8208791247"}, 
                                          new Téléphone{Type = TéléphoneType.Mobile, Numéro="0617493096"}},
                         new Adresse[] { new Adresse{Type = Adresse.AdresseType.Domicile, Numéro=19, Rue="Rue sympa", CodePostal=78901, Ville="Sympa"}, 
                                         new Adresse{Type = Adresse.AdresseType.Travail, Numéro=30, Rue="Rue pas sympa", CodePostal=1098, Ville="Pas sympa"}},
                         "steve_carell.jpg")};

                                         
    }
}
