namespace Praticas.Utils;

public static class PalindromeChecker
{
    /// <summary>
    /// Verifica se uma string é um palíndromo (ignorando espaços e maiúsculas/minúsculas).
    /// Se for um palíndromo, retorna a string original. Caso contrário, retorna null.
    /// </summary>
    public static string? GetPalindromeIfValid(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return null;

        // Remove espaços e converte para minúsculas
        string cleaned = input.Replace(" ", "").ToLower();

        // Verifica se é palíndromo comparando com sua reversa
        for (int i = 0; i < cleaned.Length / 2; i++)
        {
            if (cleaned[i] != cleaned[cleaned.Length - 1 - i])
                return null;
        }

        return input;
    }

    /// <summary>
    /// Apenas verifica se uma string é um palíndromo.
    /// </summary>
    public static bool IsPalindrome(string input)
    {
        return GetPalindromeIfValid(input) != null;
    }
}
