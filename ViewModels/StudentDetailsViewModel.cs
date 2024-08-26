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

    public enum EffortRate
    {
        VeryPoor,
        Poor,
        Average,
        Good,
        VeryGood
    }

    public enum ExhibitFrustration
    {
        Yes,
        No
    }

    public enum KnowWhatToDo
    {
        Yes, 
        No,
        NotSure
    }

    public enum Likability
    {
        LikeIt,
        ItIsOk,
        DislikeIt
    }

    public enum UnderstandLevel
    {
        VeryLittle,
        Sometimes,
        Mostly
    }

    public enum HomeWorkTime
    {
        IDoNotGetHomeWork,
        OneToTowHours,
        TowToThreeHours,
        MoreThan3Hours
    }
    public enum HowHappy
    {
        Happy,
        IDoNotCare,
        Unhappy
    }

    public enum EasyOrHard
    {
        Easy,
        SomeHardAndSomeEasy,
        Hard
    }

    public enum HowOftenHomeWork
    {
        Always,
        Sometimes,
        Never
    }

    public enum Classes
    {
        Honors,
        AP,
        Standard
    }

    public enum ThinkAboutComming
    {
        WantToComeHere,
        DoNotCare,
        DoNotWantToComeHere
    }

    public enum MathClass
    {
        GeneralMath,
        Geometry,
        PreCalculus,
        PreAlgebra,
        Algebra11,
        Calculus,
        Algebra1,
        Trignometry,
        Other
    }
    public class StudentMockDataViewModel
    {
        public IntialIntakeMockData IntialIntakeData { get; set; }
        public TestSelectionMockdata TestSelectionData { get; set; }
        public SVMPTMockData SVMPTData { get; set; }
        public WOLDMockData WOLDData { get; set; }
        public HSWAMockData HSWAData { get; set; }
        public BoehmMockdata BoehmData { get; set; }
        public ReadingReadinessMockdata ReadingReadinessData { get; set; }
        public HPAMockData HPAData { get; set; }
        public RosnerMockdata RosnerData { get; set; }
        public IRIMockData IRIData {  get; set; }
        public STARMockData STARData {  get; set; }
        public HMPEMockData HMPEData { get; set; }
        public WritingSampleMockData WritingSampledata { get; set; }
        public HSSSMockdata HSSSData { get; set; }
        public ConcludingConversationMockdata ConcludingConversationData {  get; set; }


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

    public class TestSelectionMockdata
    {
        public DateOnly AEStartDate { get; set; }
        public DateOnly AEEndDate { get; set; }
        public string Grade { get; set; }
        public string TestLocation { get; set; }
        public string TestRoom { get; set; } 
        public string TestName { get; set; }
        public bool TestCheck { get; set; }
        public DateOnly TestDate { get; set; }
        public int EstimatedTime { get; set; }
        public string TestAdministrator {  get; set; }
        public int EstimatedHours { get; set; }
    }

    public class SVMPTMockData
    {
        public string Student { get; set; }
        public DateOnly DateAdministrated { get; set; }
        public string AdministratedBy { get; set; }
        public int ActualDuration { get; set; }
        public string ResponseBy { get; set; }
        public string Paragraph { get; set; }
        public string Sentense { get; set; }
        public EffortRate EffortRate { get; set; }  
        public ExhibitFrustration ExhibitFrustration {  get; set; }
        public KnowWhatToDo KnowWhatToDo {  get; set; }
        public Likability Likability {  get; set; }


    }

    public class WOLDMockData
    {
        public string Student { get; set; }
        public DateOnly DateAdministrated { get; set; }
        public string AdministratedBy { get; set; }
        public int ActualDuration { get; set; }
        public string ResponseBy { get; set; }
        public string Paragraph { get; set; }
        public EffortRate EffortRate { get; set; }
        public ExhibitFrustration ExhibitFrustration { get; set; }
    }
    
    public class HSWAMockData
    {
        public string Student { get; set; }
        public DateOnly DateAdministrated { get; set; }
        public string AdministratedBy { get; set; }
        public int ActualDuration { get; set; }
        public string ResponseBy { get; set; }
        public string Paragraph { get; set; }
        public EffortRate EffortRate { get; set; }
        public ExhibitFrustration ExhibitFrustration { get; set; }
        public UnderstandLevel UnderstandLevel { get; set; }
        public Likability Likability { get; set; }

    }

    public class BoehmMockdata
    {
        public string Student { get; set; }
        public DateOnly DateAdministrated { get; set; }
        public string AdministratedBy { get; set; }
        public int ActualDuration { get; set; }
        public string ResponseBy { get; set; }
        public string Paragraph { get; set; }
        public EffortRate EffortRate { get; set; }
        public ExhibitFrustration ExhibitFrustration { get; set; }
        

    }

    public class ReadingReadinessMockdata
    {
        public string Student { get; set; }
        public DateOnly DateAdministrated { get; set; }
        public string AdministratedBy { get; set; }
        public int ActualDuration { get; set; }
        public string ResponseBy { get; set; }
        public string Paragraph { get; set; }
        public EffortRate EffortRate { get; set; }
        public ExhibitFrustration ExhibitFrustration { get; set; }
        public string Item { get; set; }
        public string Direction { get; set; }

    }

    public class HPAMockData
    {
        public string Student { get; set; }
        public DateOnly DateAdministrated { get; set; }
        public string AdministratedBy { get; set; }
        public int ActualDuration { get; set; }
        public string ResponseBy { get; set; }
        public string Paragraph { get; set; }
        public EffortRate EffortRate { get; set; }
        public ExhibitFrustration ExhibitFrustration { get; set; }
        public int Section { get; set; }
        public string Direction { get; set; }
    }

    public class RosnerMockdata
    {
        public string Student { get; set; }
        public DateOnly DateAdministrated { get; set; }
        public string AdministratedBy { get; set; }
        public int ActualDuration { get; set; }
        public string ResponseBy { get; set; }
        public string Paragraph { get; set; }
        public EffortRate EffortRate { get; set; }
        public ExhibitFrustration ExhibitFrustration { get; set; }
    }

    public class IRIMockData
    {
        public string Student { get; set; }
        public DateOnly DateAdministrated { get; set; }
        public string AdministratedBy { get; set; }
        public int ActualDuration { get; set; }
        public string ResponseBy { get; set; }
        public string Paragraph { get; set; }
        public EffortRate EffortRate { get; set; }
        public ExhibitFrustration ExhibitFrustration { get; set; }
        public HomeWorkTime HomeWorkTime { get; set; }
        public EasyOrHard EasyOrHard { get; set; }
        public HowOftenHomeWork HowOftenHomeWork {  get; set; }
        public HowHappy HowHappy { get; set; }
    }

    public class STARMockData
    {
        public string Student { get; set; }
        public DateOnly DateAdministrated { get; set; }
        public string AdministratedBy { get; set; }
        public int ActualDuration { get; set; }
        public string ResponseBy { get; set; }
        public string Paragraph { get; set; }
        public EffortRate EffortRate { get; set; }
        public ExhibitFrustration ExhibitFrustration { get; set; }
        public HowHappy HowHappy { get; set; }
        public EasyOrHard EasyOrHard { get; set; }


    }

    public class HMPEMockData
    {
        public string Student { get; set; }
        public DateOnly DateAdministrated { get; set; }
        public string AdministratedBy { get; set; }
        public int ActualDuration { get; set; }
        public string ResponseBy { get; set; }
        public string Paragraph { get; set; }
        public EffortRate EffortRate { get; set; }
        public ExhibitFrustration ExhibitFrustration { get; set; }
        public HowHappy HowHappy { get; set; }
        public Classes Classes { get; set; }
        public int MathGrade { get; set; }
        public MathClass MathClass { get; set; }

    }

    public class WritingSampleMockData
    {
        public string Student { get; set; }
        public DateOnly DateAdministrated { get; set; }
        public string AdministratedBy { get; set; }
        public int ActualDuration { get; set; }
        public string ResponseBy { get; set; }
        public string Paragraph { get; set; }
        public EffortRate EffortRate { get; set; }
        public ExhibitFrustration ExhibitFrustration { get; set; }
        public Likability Likability { get; set; }
        public string Sentense { get; set; }

    }

    public class HSSSMockdata
    {
        public string Student { get; set; }
        public DateOnly DateAdministrated { get; set; }
        public string AdministratedBy { get; set; }
        public int ActualDuration { get; set; }
        public string ResponseBy { get; set; }
        public string Paragraph { get; set; }
        public EffortRate EffortRate { get; set; }
        public ExhibitFrustration ExhibitFrustration { get; set; }
    }

    public class ConcludingConversationMockdata
    {
        public string Student { get; set; }
        public DateOnly DateAdministrated { get; set; }
        public string AdministratedBy { get; set; }
        public string Paragraph { get; set; }
        public ThinkAboutComming ThinkAboutComming { get; set; }
    }
}
