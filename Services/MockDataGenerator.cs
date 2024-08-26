using Bogus;
using Humanizer;
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
                Grade = "Grade " + faker.Random.Number(1, 12),
                Gender = faker.PickRandom<Gender>(),
                IntakeBy = faker.Person.FullName,
                Service = faker.Random.Word(),
                CenterAEFee = "$" + faker.Random.Number(1, 100),
                AEDiscount = faker.Random.Word(),
                AEDiscountType = faker.PickRandom<AEDiscountType>(),
                AEDiscountAmount = Math.Round(faker.Random.Double(0, 100),2),
                DiscounttedAEFee = Math.Round(faker.Random.Double(0, 100),2),
                Promocode = faker.Random.Number(1, 999).ToString("D3"),
                IntakeNote = faker.Lorem.Sentence(5,15)
            };

            return mockData;
        }

        internal static TestSelectionMockdata GetMockTestSelectionData()
        {
            var faker = new Faker();

            var mockData = new TestSelectionMockdata
            {
                AEStartDate = faker.Date.PastDateOnly(8),
                AEEndDate = faker.Date.PastDateOnly(8),
                Grade = "Grade " + faker.Random.Number(1, 12),
                TestLocation = faker.Random.Word(),
                TestRoom = faker.Lorem.Sentence(1, 5),
                TestName = faker.Lorem.Sentence(3),
                TestCheck = faker.Random.Bool(),
                TestDate = faker.Date.PastDateOnly(8),
                EstimatedTime = faker.Random.Int(1,12),
                TestAdministrator = faker.Person.FirstName,
                EstimatedHours = faker.Random.Int(1,5)
            };

            return mockData;

        }

        internal static SVMPTMockData GetMockSVMPTData()
        {
            var faker = new Faker();

            var mockData = new SVMPTMockData
            {
                Student = faker.Person.FirstName,
                DateAdministrated = faker.Date.PastDateOnly(8),
                AdministratedBy = faker.Person.FirstName,
                ActualDuration = faker.Random.Number(1, 60),
                ResponseBy = faker.Person.FirstName,
                Paragraph = faker.Lorem.Sentence(80, 100),
                Sentense = faker.Lorem.Sentence(1, 5),
                EffortRate = faker.PickRandom<EffortRate>(),
                ExhibitFrustration = faker.PickRandom<ExhibitFrustration>(),
                KnowWhatToDo = faker.PickRandom<KnowWhatToDo>(),
                Likability = faker.PickRandom<Likability>(),
            };

            return mockData;
        }

        internal static WOLDMockData GetMockWOLDData()
        {
            var faker = new Faker();

            var mockData = new WOLDMockData
            {
                Student = faker.Person.FirstName,
                DateAdministrated = faker.Date.PastDateOnly(8),
                AdministratedBy = faker.Person.FirstName,
                ActualDuration = faker.Random.Number(1, 60),
                ResponseBy = faker.Person.FirstName,
                Paragraph = faker.Lorem.Sentence(80, 100),
                EffortRate = faker.PickRandom<EffortRate>(),
                ExhibitFrustration = faker.PickRandom<ExhibitFrustration>(),
            };

            return mockData;
        }

        internal static HSWAMockData GetMockHSWAData()
        {
            var faker = new Faker();

            var mockdata = new HSWAMockData
            {
                Student = faker.Person.FirstName,
                DateAdministrated = faker.Date.PastDateOnly(8),
                AdministratedBy = faker.Person.FirstName,
                ActualDuration = faker.Random.Number(1, 60),
                ResponseBy = faker.Person.FirstName,
                Paragraph = faker.Lorem.Sentence(80, 100),
                EffortRate = faker.PickRandom<EffortRate>(),
                ExhibitFrustration = faker.PickRandom<ExhibitFrustration>(),
                UnderstandLevel = faker.PickRandom<UnderstandLevel>(),
                Likability = faker.PickRandom<Likability>(),
            };

            return mockdata;
        }
        
        internal static BoehmMockdata GetMockBoehmData()
        {
            var faker = new Faker();
            var mockData = new BoehmMockdata
            {
                Student = faker.Person.FirstName,
                DateAdministrated = faker.Date.PastDateOnly(8),
                AdministratedBy = faker.Person.FirstName,
                ActualDuration = faker.Random.Number(1, 60),
                ResponseBy = faker.Person.FirstName,
                Paragraph = faker.Lorem.Sentence(80, 100),
                EffortRate = faker.PickRandom<EffortRate>(),
                ExhibitFrustration = faker.PickRandom<ExhibitFrustration>(),
                

            };

            return mockData;
        }

        internal static ReadingReadinessMockdata GetMockReadingReadinessData()
        {
            var faker = new Faker();
            var mockData = new ReadingReadinessMockdata
            {
                Student = faker.Person.FirstName,
                DateAdministrated = faker.Date.PastDateOnly(8),
                AdministratedBy = faker.Person.FirstName,
                ActualDuration = faker.Random.Number(1, 60),
                ResponseBy = faker.Person.FirstName,
                Paragraph = faker.Lorem.Sentence(80, 100),
                EffortRate = faker.PickRandom<EffortRate>(),
                ExhibitFrustration = faker.PickRandom<ExhibitFrustration>(),
                Item = faker.Lorem.Sentence(3),
                Direction = faker.Lorem.Sentence(10, 12)
            };

            return mockData;
        }

        internal static HPAMockData GetMockHPAData()
        {
            var faker = new Faker();
            var mockData = new HPAMockData
            {
                Student = faker.Person.FirstName,
                DateAdministrated = faker.Date.PastDateOnly(8),
                AdministratedBy = faker.Person.FirstName,
                ActualDuration = faker.Random.Number(1, 60),
                ResponseBy = faker.Person.FirstName,
                Paragraph = faker.Lorem.Sentence(80, 100),
                EffortRate = faker.PickRandom<EffortRate>(),
                ExhibitFrustration = faker.PickRandom<ExhibitFrustration>(),
                Section = faker.Random.Number(1,4),
                Direction = faker.Lorem.Sentence(10, 12)
            };

            return mockData;
        }

        internal static RosnerMockdata GetMockRosnerdata()
        {
            var faker = new Faker();
            var mockData = new RosnerMockdata
            {
                Student = faker.Person.FirstName,
                DateAdministrated = faker.Date.PastDateOnly(8),
                AdministratedBy = faker.Person.FirstName,
                ActualDuration = faker.Random.Number(1, 60),
                ResponseBy = faker.Person.FirstName,
                Paragraph = faker.Lorem.Sentence(80, 100),
                EffortRate = faker.PickRandom<EffortRate>(),
                ExhibitFrustration = faker.PickRandom<ExhibitFrustration>(),
            };

            return mockData;
        }

        internal static IRIMockData GetMockIRIData()
        {
            var faker = new Faker();
            var mockData = new IRIMockData
            {
                Student = faker.Person.FirstName,
                DateAdministrated = faker.Date.PastDateOnly(8),
                AdministratedBy = faker.Person.FirstName,
                ActualDuration = faker.Random.Number(1, 60),
                ResponseBy = faker.Person.FirstName,
                Paragraph = faker.Lorem.Sentence(80, 100),
                EffortRate = faker.PickRandom<EffortRate>(),
                ExhibitFrustration = faker.PickRandom<ExhibitFrustration>(),
                HomeWorkTime = faker.PickRandom<HomeWorkTime>(),
                EasyOrHard = faker.PickRandom<EasyOrHard>(),
                HowOftenHomeWork = faker.PickRandom<HowOftenHomeWork>(),
                HowHappy = faker.PickRandom<HowHappy>()

            };

            return mockData;
        }

        internal static STARMockData GetMockSTARData()
        {
            var faker = new Faker();
            var mockData = new STARMockData
            {
                Student = faker.Person.FirstName,
                DateAdministrated = faker.Date.PastDateOnly(8),
                AdministratedBy = faker.Person.FirstName,
                ActualDuration = faker.Random.Number(1, 60),
                ResponseBy = faker.Person.FirstName,
                Paragraph = faker.Lorem.Sentence(80, 100),
                EffortRate = faker.PickRandom<EffortRate>(),
                ExhibitFrustration = faker.PickRandom<ExhibitFrustration>(),
                EasyOrHard = faker.PickRandom<EasyOrHard>(),
                HowHappy = faker.PickRandom<HowHappy>()
            };

            return mockData;
        }

        internal static HMPEMockData GetMockHMPEData()
        {
            var faker = new Faker();
            var mockData = new HMPEMockData
            {
                Student = faker.Person.FirstName,
                DateAdministrated = faker.Date.PastDateOnly(8),
                AdministratedBy = faker.Person.FirstName,
                ActualDuration = faker.Random.Number(1, 60),
                ResponseBy = faker.Person.FirstName,
                Paragraph = faker.Lorem.Sentence(80, 100),
                EffortRate = faker.PickRandom<EffortRate>(),
                ExhibitFrustration = faker.PickRandom<ExhibitFrustration>(),
                HowHappy = faker.PickRandom<HowHappy>(),
                Classes = faker.PickRandom<Classes>(),
                MathGrade = faker.Random.Number(1,100),
                MathClass = faker.PickRandom<MathClass>(),
            };

            return mockData;
        }

        internal static WritingSampleMockData GetMockWritingSampleData()
        {
            var faker = new Faker();
            var mockdata = new WritingSampleMockData
            {
                Student = faker.Person.FirstName,
                DateAdministrated = faker.Date.PastDateOnly(8),
                AdministratedBy = faker.Person.FirstName,
                ActualDuration = faker.Random.Number(1, 60),
                ResponseBy = faker.Person.FirstName,
                Paragraph = faker.Lorem.Sentence(100, 130),
                EffortRate = faker.PickRandom<EffortRate>(),
                ExhibitFrustration = faker.PickRandom<ExhibitFrustration>(),
                Sentense = faker.Lorem.Sentence(1, 5),
                Likability = faker.PickRandom<Likability>()

            };

            return mockdata;
        }

        internal static HSSSMockdata GetMockHSSSdata()
        {
            var faker = new Faker();
            var mockdata = new HSSSMockdata
            {
                Student = faker.Person.FirstName,
                DateAdministrated = faker.Date.PastDateOnly(8),
                AdministratedBy = faker.Person.FirstName,
                ActualDuration = faker.Random.Number(1, 60),
                ResponseBy = faker.Person.FirstName,
                Paragraph = faker.Lorem.Sentence(80, 100),
                EffortRate = faker.PickRandom<EffortRate>(),
                ExhibitFrustration = faker.PickRandom<ExhibitFrustration>(),
            };
            return mockdata;
        }

        internal static ConcludingConversationMockdata GetMockConcludingConversationData()
        {
            var faker = new Faker();
            var mockdata = new ConcludingConversationMockdata
            {
                Student = faker.Person.FirstName,
                DateAdministrated = faker.Date.PastDateOnly(8),
                AdministratedBy = faker.Person.FirstName,
                Paragraph = faker.Lorem.Sentence(80, 100),
                ThinkAboutComming = faker.PickRandom<ThinkAboutComming>(),
            };
            return mockdata;

        }
    }
}