namespace StrongPasswordChecker
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(@"Digite uma senha para verificar. Obs: A senha tem que conter de 12 a 16 caracter, sendo no mínimo uma letra maiúscula, uma minúscula e um caracter especial (!@#$%^&*()_+-=[]{}|;:,.<>?)");
            string password = Console.ReadLine();

            string isValid = IsPasswordValid(password);

            if (isValid == "ok")
            {
                Console.WriteLine("A senha é válida.");
            }
            else
            {
                Console.WriteLine(isValid);
            }
        }

        static string IsPasswordValid(string password)
        {
            if (password.Length < 12 || password.Length > 16)
            {
                return "A senha precisa conter de 12 a 16 caracteres";
            }

            if (!password.Any(char.IsDigit))
            {
                return "A senha precisa conter no mínimo um número";
            }

            if (!password.Any(char.IsLower))
            {
                return "A senha precisa conter no mínimo uma letra minúscula";
            }

            if (!password.Any(char.IsUpper))
            {
                return "A senha precisa conter no mínimo uma letra minúscula";
            }

            string specialCharacters = @"!@#$%^&*()_+-=[]{}|;:,.<>?";
            if (!password.Intersect(specialCharacters).Any())
            {
                return @"A senha precisa conter no mínimo um caracter especial (!@#$%^&*()_+-=[]{}|;:,.<>?)";
            }

            return "ok";
        }
    }
}