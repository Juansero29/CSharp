using System;using System.Collections.Generic;
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
            4.
            QueryFour(new DateTime(1962, 1, 1), new DateTime(1964, 1, 1));
            5.
            QueryFive();
            6.
            QuerySix();
            7.
            QuerySeven();
            8.
            QueryEight();
            9.
             */
            QueryNine();


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
            d.Albums.OrderBy(album => album.Titre)
                .Where(album => album.SideMen.Any(artist => artist.Value == "trombone"))
                .ToList().ForEach(album => WriteLine(album));
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
                .Where(album => 
                album.DateEnregistrement.Date >= startDate && 
                album.DateEnregistrement <= endDate.Date)
                .ToList()
                .ForEach(album => WriteLine(album));
        }

        static void QueryFive()
        {
            /*
             * Affichez toutes les années où au moins 
             * un Album a été enregistré, par ordre 
             * chronologique (comme sur l'image ci-dessous).
             */
            Disco d = new Disco();
            d.Albums.GroupBy(album => album.DateEnregistrement.Year)
                .ToList().ForEach(group => WriteLine(group.Key));
        }

        static void QuerySix()
        {
            /*
             * Affichez tous les Leaders, par ordre
             * alphabétique de nom puis de prénom 
             * (comme sur l'image ci-dessous).
             */

            Disco d = new Disco();
            d.Albums.Select(album => album.Leader)
                .OrderBy(artist => artist.Nom)
                .ThenBy(artist => artist.Prénom).Distinct()
                .ToList().ForEach(artist => WriteLine(artist));
        }

        static void QuerySeven()
        {
            /*
             * Affichez tous les albums regroupés
             * par Leader (comme sur l'image ci-dessous).
             * Les Leaders seront affichés par ordre alphabétique.
             */

            Disco d = new Disco();
            d.Albums.GroupBy(album => album.Leader)
                .OrderBy(pair => pair.Key.Nom)
                .ThenBy(pair => pair.Key.Prénom)
                .ToList()
                .ForEach(pair =>
                {
                    WriteLine($"Albums de {pair.Key}:");
                    foreach (var album in pair.ToList().Select(element => element))
                    {
                        WriteLine($"\t{album}");
                    }
                });
        }

        static void QueryEight()
        {
            /*
             * Affichez le nombre de fois où les instruments
             * apparaissent au total dans les disques. Ceux-ci 
             * seront affichés en allant des plus utilisés vers
             * les moins utilisés. Si des instruments sont ex 
             * aequo, ils seront affichés sur la même ligne. 
             * L'image ci-dessous montre le résultat à obtenir.
             */

            Disco d = new Disco();
            d.Albums.ToList()
                .SelectMany(album => album.SideMen.Values)
                .ToList().GroupBy(instrument => instrument)
                .OrderByDescending(group => group.Count())
                .ToList().ForEach(group => 
                WriteLine($"Instrument {group.Key} appears {group.Count()} times."));

        }

        static void QueryNine()
        {
            /*
             * Affichez le ou les sidemen qui apparaissent
             * le plus souvent sur les disques d'autres 
             * musiciens (c'est-à-dire sur lesquels ils ne
             * sont pas Leader). Puis affichez ceux qui 
             * arrivent juste derrière (les seconds). Le 
             * résultat à obtenir est présenté ci-dessous.
             */

            Disco d = new Disco();

            var leaders = d.Albums.ToList().Select(album => album.Leader).Distinct();


            Dictionary<IArtiste, int> dico = new Dictionary<IArtiste, int>();



            foreach(var leader in leaders)
            {
                int numberOfTimes = 0;
                foreach(var album in d.Albums)
                {
                    if (!album.Leader.Equals(leader))
                    {
                        numberOfTimes += album.SideMen.Count(pair => pair.Key.Equals(leader));
                    }
                }

                dico.Add(leader, numberOfTimes);
                WriteLine($"The leader {leader} appears {numberOfTimes} times in other albums");
            }

            var max = dico.Values.Max();
            //dico.ToList().Remove()





        }
    }
}
