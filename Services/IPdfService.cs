
public interface IPdfService
{
    Task<byte[]> GeneratePdfAsync(GeneratePdfRequest request);
}