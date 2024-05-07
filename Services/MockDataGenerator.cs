using Bogus;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using RazorToPDF.ViewModels;

namespace RazorToPDF.Services
{
    internal class MockDataGenerator
    {
        internal static IntialIntakeMockData GetMockIntialIntakeData()
        {
            var faker = new Faker();

            var mockData = new IntialIntakeMockData
            {
                FirstName = faker.Person.FirstName,
                LastName = faker.Person.LastName,
                Nickname = faker.Person.UserName,
                DateOfBirth =  faker.Date.PastDateOnly(8),
                Age = faker.Random.Number(5, 18),
                Grade = faker.Random.Word(),
                Gender = faker.PickRandom<Gender>(),
                IntakeBy = faker.Person.FullName,
                Service = faker.Random.Word(),
                CenterAEFee = faker.Random.Word(),
                AEDiscount = faker.Random.Word(),
                AEDiscountType = faker.PickRandom<AEDiscountType>(),
                AEDiscountAmount = faker.Random.Double(0, 100),
                DiscounttedAEFee = faker.Random.Double(0, 100),
                Promocode = faker.Random.Word(),
                IntakeNote = faker.Lorem.Sentence(20,50)
            };

            return mockData;
        }
    }
}