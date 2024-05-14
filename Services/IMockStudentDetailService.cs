using RazorToPDF.ViewModels;

namespace RazorToPDF.Services
{
    public interface IMockStudentDetailService
    {
        StudentMockDataViewModel GetMockData();
    }

    public class MockStudentDetailService : IMockStudentDetailService
    {
        public StudentMockDataViewModel GetMockData()
        {
          
            var mockData = new StudentMockDataViewModel();

            mockData.IntialIntakeData = MockDataGenerator.GetMockIntialIntakeData();
            mockData.TestSelectionData = MockDataGenerator.GetMockTestSelectionData();
            mockData.SVMPTData = MockDataGenerator.GetMockSVMPTData();
            mockData.WOLDData = MockDataGenerator.GetMockWOLDData();
            mockData.HSWAData = MockDataGenerator.GetMockHSWAData();
            mockData.BoehmData = MockDataGenerator.GetMockBoehmData();
            mockData.ReadingReadinessData = MockDataGenerator.GetMockReadingReadinessData();
            mockData.HPAData = MockDataGenerator.GetMockHPAData();
            mockData.RosnerData = MockDataGenerator.GetMockRosnerdata();
            mockData.IRIData = MockDataGenerator.GetMockIRIData();
            mockData.STARData = MockDataGenerator.GetMockSTARData();
            mockData.HMPEData = MockDataGenerator.GetMockHMPEData();
            mockData.WritingSampledata = MockDataGenerator.GetMockWritingSampleData();
            mockData.HSSSData = MockDataGenerator.GetMockHSSSdata();
            mockData.ConcludingConversationData = MockDataGenerator.GetMockConcludingConversationData();


            return mockData;
        }
    }
}
