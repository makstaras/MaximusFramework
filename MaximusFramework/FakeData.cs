using System;
using Bogus;

namespace MaximusFramework
{
    public class FakeData
    {
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public int Id { get; set; }
        public DateTime FoundDate { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Digit { get; set; }
        public string State { get; set; }

        public FakeData()
        {
            Id = new Faker().Random.Int(min: 0);
        }

        public FakeData FillIn()
        {
            new Faker<FakeData>()
                .StrictMode(false)
                .RuleFor(o => o.EmailAddress, (f, a) => f.Internet.Email(a.FirstName, a.LastName))
                .RuleFor(o => o.FirstName, f => f.Name.FirstName())
                .RuleFor(o => o.LastName, f => f.Name.LastName())
                .RuleFor(o => o.Company, f => f.Company.CompanyName())
                .RuleFor(o => o.Id, f => f.IndexFaker + 1)
                .RuleFor(o => o.FoundDate, f => f.Date.Past(18, DateTime.Today.AddYears(-5)))
                .RuleFor(o => o.Password, f => f.Random.Replace("#?*^"))
                .RuleFor(o => o.City, f => f.Address.City())
                .RuleFor(o => o.Address, f => f.Address.StreetAddress())
                .RuleFor(o => o.Phone, f => f.Phone.PhoneNumber())
                .RuleFor(o => o.Digit, f => f.Random.Number(1, 5))
                .RuleFor(o => o.State, f => f.Address.State())
                .Populate(this);
            return this;
        }
    }
}