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

            return mockData;
        }
    }
}
