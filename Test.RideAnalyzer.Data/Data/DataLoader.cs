using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Test.RideAnalyzer.Models.Models;

namespace Test.RideAnalyzer.Data.Data
{
    public class DataLoader
    {
        public DataLoader()
        {
                
        }
        public List<Ride>? GetRides(int count) 
        {
            List<Ride> _rides = new List<Ride>();

            var rideFaker = new Faker<Ride>("tr")
                .RuleFor(x => x.TCKN, faker => faker.Random.Long(10000000000, 99999999999).ToString())
                .RuleFor(x => x.BirthDate, faker => faker.Person.DateOfBirth)
                .RuleFor(x => x.FullName, faker => faker.Person.FullName)
                .RuleFor(x => x.Phone, faker => faker.Person.Phone)
                .RuleFor(x => x.Email, faker => faker.Person.Email)
                .RuleFor(x => x.Address, faker => faker.Person.Address.City)
                .RuleFor(x => x.StartDate, faker => faker.Date.Recent())
                .RuleFor(x => x.EndDate, faker => DateTime.Now.AddMinutes(faker.Random.Number(-30, 0)))
                .RuleFor(x => x.ScooterId, faker => faker.Random.Number(1000000, 9999999))
                .RuleFor(x => x.BinBinRideId, faker => faker.Random.Number(1000001, 9999999));
            _rides = rideFaker.Generate(count);

            var rndDate = new Random();
            var rndMinute = new Random();
            var rndSecond = new Random();


            foreach (var ride in _rides)
            {
                int dayDiff = rndDate.Next(0, 5);
                int minuteDiff = rndMinute.Next(0, 60);
                int minuteDiff2 = rndMinute.Next(0, 60);
                int secondDiff = rndSecond.Next(0, 60);
                DateTime startDate = DateTime.Now.AddDays(-dayDiff).AddMinutes(-minuteDiff).AddSeconds(-secondDiff);
                DateTime endDate = startDate.AddMinutes(minuteDiff2).AddSeconds(secondDiff / 2);
                ride.StartDate = startDate;
                ride.EndDate = endDate;
            }

            return _rides;



        }

    }
}
