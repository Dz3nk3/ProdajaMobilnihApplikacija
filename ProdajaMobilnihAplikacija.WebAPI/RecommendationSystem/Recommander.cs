using ProdajaMobilnihAplikacija.WebAPI.Database;
using ProdajaMobilnihAplikacija.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.RecommendationSystem
{
    public class Recommander
    {
        public class RecommenderSystem
        {
            private readonly Prodaja_Mobilnog_SoftveraContext _db;


            int numberOfSimmilarUsers = 2;
            Dictionary<int, List<Ocjena>> matricaRatings = new Dictionary<int, List<Ocjena>>();
            Dictionary<int, double> preporuceniProizvodi = new Dictionary<int, double>();
            Dictionary<int, double> simmilarity = new Dictionary<int, double>();

            List<int> users = new List<int>();
            List<Ocjena> ratingsOfThisUser = new List<Ocjena>();
            List<Ocjena> ratingsOfOthers = new List<Ocjena>();
            double denominatorUser = 0;

            public RecommenderSystem() => _db = new Prodaja_Mobilnog_SoftveraContext();


            //public Dictionary<int, double> GetRecomended(int userId)
            //{
            //    GetUsersData(userId);


            //    Parallel.ForEach(users, item =>
            //    {
            //        var sim = GetSimilarity(item);

            //        simmilarity.Add(item, sim);
            //    });

            //    simmilarity = SortDictionaryByValue(simmilarity);

            //    var topusers = simmilarity.Take(numberOfSimmilarUsers).ToList();

            //    double sumOfsim = topusers.Sum(x => x.Value);

            //    foreach (var vozilo in _db.Softver)
            //    {
            //        double totalSum = 0;
            //        foreach (var c in topusers)
            //        {
            //            var rating = matricaRatings[c.Key].Where(m => m.SoftverId == vozilo.SoftverId).FirstOrDefault();

            //            if (rating != null)
            //                totalSum += c.Value * (float)rating.Ocjena1;
            //        }

            //        double simVal = totalSum / sumOfsim;
            //        preporuceniProizvodi.Add(vozilo.SoftverId, simVal);
            //    }

            //    return SortDictionaryByValue(preporuceniProizvodi).Take(10).ToDictionary(pair => pair.Key, pair => pair.Value);
            //}


            //private double GetSimilarity(int otherUserId)
            //{
            //    double denominatorOthers = 0, numerator = 0;

            //    denominatorOthers = Math.Sqrt(ratingsOfOthers.Where(x => x.KlijentId == otherUserId).Sum(x => Math.Pow((float)x.Ocjena1, 2)));
            //    var filteredRating = ratingsOfOthers.Where(x => x.KlijentId == otherUserId).ToList();

            //    Parallel.ForEach(ratingsOfThisUser, rating =>
            //    {
            //        numerator += filteredRating.Where(x => x.SoftverId == rating.SoftverId).Select(x => (float)x.Ocjena1 * (float)rating.Ocjena1).ToList().Sum();
            //    });

            //    var denominator = denominatorUser * denominatorOthers;
            //    return denominator == 0 ? 0 : Math.Sqrt(numerator / denominator);
            //}

            //private void GetUsersData(int userId)
            //{
            //    // List<int?> ovo je upitno
            //    List<int?> users = _db.Ocjena.Select(x => x.KlijentId).Distinct().ToList();

            //    ratingsOfThisUser = _db.Ocjena.Where(x => x.KlijentId == userId).ToList();
            //    ratingsOfOthers = _db.Ocjena.Where(x => x.KlijentId != userId).ToList();

            //    Parallel.ForEach(users, u => matricaRatings.Add((int)u, ratingsOfOthers.Where(x => x.KlijentId == u).ToList()));

            //    denominatorUser = Math.Sqrt(ratingsOfThisUser.Sum(x => Math.Pow((float)x.Ocjena1, 2)));
            //}

            public static Dictionary<int, double> SortDictionaryByValue(Dictionary<int, double> data)
            {
                var myList = data.ToList();

                myList.Sort((pair1, pair2) => -1 * pair1.Value.CompareTo(pair2.Value));

                return myList.ToDictionary(p => p.Key, p => p.Value);
            }

        }
    }
}
