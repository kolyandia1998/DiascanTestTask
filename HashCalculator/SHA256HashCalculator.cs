using System.Security.Cryptography;

namespace DiascanTestTask.HashCalculator;

public class SHA256HashCalculator : IHashCalculator
{
    public int CalculateHash(string filePath)
    {   
        using var stream = new FileStream(filePath, FileMode.Open);
        using var sha256 = SHA256.Create();
        var hash = sha256.ComputeHash(stream);
        return BitConverter.ToInt32(hash, 0);
    }

    public async Task<int> CalculateHashAsync(string filePath)
    {
        return await Task.Run(() =>
        {

            CalculateHash(filePath);
            Task.Delay(1000);
            return Thread.CurrentThread.ManagedThreadId;
        });
    }
}
