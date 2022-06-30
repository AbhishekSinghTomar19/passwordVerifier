namespace HelloWorld
{   public static class PasswordChecker
    {
        public static void Main(string[] args)
        {
            string password = " Abh5";
            Console.WriteLine(CheckPassword(password));
        }
        public static bool CheckPassword(string password)
        {
            int checkValidity = 0;
            foreach (char character in password)
            {
                if (character >= 'a' && character <= 'z')
                {
                    checkValidity++;
                    break;
                }
            }

            foreach (char character in password)
            {
                if (character >= 'A' && character <= 'Z')
                {
                    checkValidity++;
                    break;
                }
            }
            if (password.Length < 9) return false;
            
            
            foreach (char c in password)
            {
                if (c >= '0' && c <= '9')
                {
                    checkValidity++;
                    break;
                }
            }

            if (checkValidity < 3) return false;

            else if (checkValidity == 3) {
                return true;
            } ;

            return false;

        }
    }
}