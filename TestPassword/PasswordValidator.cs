namespace TestPassword;

public class PasswordValidator
{
    public static bool IsValid(string password)
    {
        if (password.Length >= 8 && password.Length <= 50)
        {
            if (password.Any(char.IsAsciiLetterLower) && password.Any(char.IsAsciiLetterUpper) && password.Any(char.IsDigit))
            {
                char[] invalidSymbols = ['\\', '/', ':', '*', '?', '"', '<', '>', '|'];
                if (password.Any(c => !char.IsLetterOrDigit(c)) && password.All(char.IsAscii) && !password.Any(c => invalidSymbols.Contains(c)))
                {
                    return true;
                }
            }
        }
        return false;
    }
}
