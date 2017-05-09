using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscoJazz;
using static System.Console;

namespace LINQUERIES
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1.
            QueryOne();
            2.
            QueryTwo();
            3.
            QueryThree("1964", "Henderson", "Joe");
            4.*/
            QueryFour(new DateTime(1962, 1, 1), new DateTime(1964, 1, 1));
            


        }


        static void QueryOne()
        {
            //Affichez tous les artistes par ordre alphabétique de nom puis de prénom, en cas d'égalité.
            Disco d = new Disco();

            d.Artistes
                .OrderBy(artist => artist.Nom)
                .ThenBy(artist => artist.Prénom)
                .ToList()
                .ForEach(artist => WriteLine($"{artist.Prénom} {artist.Nom}"));
        }

        static void QueryTwo()
        {
            //Affichez la liste de tous les albums sur lesquels un Artiste joue du trombone.
            Disco d = new Disco();
            d.Albums.OrderBy(album => album.Titre).Where(album => album.SideMen.Any(artist => artist.Value == "trombone")).ToList().ForEach(album => WriteLine(album));
        }

        static void QueryThree(string year, string lastName, string firstName)
        {
            /*
             * Ecrivez une méthode qui prendra en paramètres une année, le nom et le prénom d'un artiste, 
             * et affichera tous les disques sur lesquels l'artiste en question a joué durant cette année
             * (comme sur l'image ci-dessous, si vous choisissez “1964”, “Henderson” et “Joe”) et utilisez 
             * cette méthode.
             */

            Disco d = new Disco();
            d.Albums.OrderBy(album => album.Titre)
                .Where(album =>
                        album.SideMen.Keys.Any(artist => artist.Nom == lastName && artist.Prénom == firstName)
                        && album.DateEnregistrement.Year == int.Parse(year))
                .ToList().ForEach(album => WriteLine(album));
        }

        static void QueryFour(DateTime startDate, DateTime endDate)
        {
            /*
             * Ecrivez une méthode qui prendra en paramètres deux dates
             * et affichera tous les disques enregistrés entre ces deux
             * dates par ordre chronologique inverse (comme sur l'image
             * ci-dessous, si vous choisissez comme dates, le 1er janvier
             * 1962 et le 1er janvier 1964) et utilisez cette méthode.
             */

            Disco d = new Disco();

            d.Albums
                .Where(album => album.DateEnregistrement.Date >= startDate && album.DateEnregistrement <= endDate.Date)
                .ToList()
                .ForEach(album => WriteLine(album));

        }
    }
}
