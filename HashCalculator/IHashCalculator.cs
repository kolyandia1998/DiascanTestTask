namespace DiascanTestTask.HashCalculator;

public interface IHashCalculator
{
    Task<int> CalculateHashAsync(string filePath);
    int CalculateHash(string filePath);
}