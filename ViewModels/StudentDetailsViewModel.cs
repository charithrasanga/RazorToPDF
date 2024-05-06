namespace RazorToPDF.ViewModels
{
    public enum Gender
    {
        Male,
        Female,
        NonBinary,
        PreferNotToShare
    }

    public enum AEDiscountType
    {
        Percentage,
        Amount
    }

    public class StudentMockDataViewModel
    {
        public IntialIntakeMockData IntialIntakeData { get; set; }
    }

    public class IntialIntakeMockData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
        public Gender Gender { get; set; }
        public string IntakeBy { get; set; }
        public string Service { get; set; }
        public string CenterAEFee { get; set; }
        public string AEDiscount { get; set; }
        public AEDiscountType AEDiscountType { get; set; }
        public double AEDiscountAmount { get; set; }
        public double DiscounttedAEFee { get; set; }
        public string Promocode { get; set; }
        public string IntakeNote { get; set; }
    }
}
