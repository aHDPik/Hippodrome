using System;
using System.Collections.Generic;
using System.Linq;

namespace Hippodrome
{
    internal class Program
    {
        private static HippodromeContext context = new HippodromeContext();
        public static double Odds(string Number)
        {
            //int totalCount = (from part in context.Participations
            //                  where part.RiderHorse.HorseNumber == Number
            //                 select part).Count();
            //int winCount = (from part in context.Participations
            //                where part.RiderHorse.HorseNumber == Number && 
            //                part.Place == 1
            //                select part).Count();

            List<Participation> total = (from part in context.Participations
                                              where part.RiderHorse.HorseNumber == Number
                                              select part).ToList();
            double totalCount = total.Count();
            double winCount = total.Count(c => c.Place == 1);
            return winCount/totalCount;
        }

        public static double Coefficient(string Number, int raceId)
        {
            double totalMoney = (from bet in context.Bets
                                where bet.Participation.RaceId == raceId
                                select bet.Amount).Sum();
            double totalMoneyHorse = (from bet in context.Bets
                                      where bet.Participation.RaceId == raceId
                                      && bet.Participation.RiderHorse.HorseNumber
                                      == Number
                                      select bet.Amount).Sum();
            double revenue = 1000;
            double maxCoefficient = totalMoney/(totalMoneyHorse - revenue)/
                Odds(Number);
            return maxCoefficient;
        }




        static void Main(string[] args)
        {
                context.Database.EnsureCreated();
        }
    }
}
