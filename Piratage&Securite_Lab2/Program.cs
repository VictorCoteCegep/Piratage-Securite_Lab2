namespace Piratage_Securite_Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileReader reader = new FileReader();
            PasswordEncryptor encryptor = new PasswordEncryptor();
            string[] passwords = reader.ReadFileLines("input.txt");
            string[] hashedPasswords = new string[16];
            int i = 0;
            foreach (string password in passwords)
            {
                hashedPasswords[i] = encryptor.EncryptPassword(password);
                i++;
            }
            FileWriter writer = new FileWriter();
            writer.WriteFileLines("output.txt",hashedPasswords);
            Console.WriteLine("Done!");
        }
    }
}
