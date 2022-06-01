using System;
using System.IO;

namespace CipherApp
{
    class Program
    {
        #region Main Method
        static void Main(string[] args)
        {
            string userChoose = string.Empty;
            string filePath = string.Empty;
            string fileName = string.Empty;
            string plainText = string.Empty;
            string cipherText = string.Empty;
            int shift = 0;
            StreamWriter sw = default;
            StreamReader sr = default;

            do
            {
                userChoose = WelcomeMessage();

                if (userChoose.ToLower() == "e")
                {
                    PerformEncryptOperation(out plainText, out cipherText, out shift);
                }
                else if (userChoose.ToLower() == "d")
                {
                    PerformDecryptOperation(out filePath, out fileName, ref cipherText, out shift, ref sr);
                }
                else if (!(userChoose.ToLower() == "x"))
                {
                    ErrorMessage("Invalid input, please try again");
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("----------------------------------------------------");
                Console.WriteLine("\n");
            }
            while (userChoose.ToLower() != "x");
            Console.WriteLine("Thank you for using caesar cipher app.\n\n");
        }
        #endregion

        #region Error Message
        private static void ErrorMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        #endregion

        #region App Message
        private static void AppMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion

        #region Welcome Message
        private static string WelcomeMessage()
        {
            string userChoose;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to caesar cipher app, choose \n(E) to encrypt \n(D) to decrypt \n(X) to exit\n");
            Console.ForegroundColor = ConsoleColor.White;
            userChoose = Console.ReadLine();
            return userChoose;
        }
        #endregion

        #region Perform Encrypt Operation
        private static void PerformEncryptOperation(out string plainText, out string cipherText, out int shift)
        {
            AppMessage("Welcome to encryption mode \nEnter message to encrypt");
            plainText = Console.ReadLine();
            shift = 0; cipherText = string.Empty;
            if (plainText != "")
            {
                try
                {
                    AppMessage("Enter the shift");
                    shift = int.Parse(Console.ReadLine());

                    if (shift <= 26 && shift > 0)
                    {
                        AppMessage("Cipher is");

                        cipherText = new string(CaeserCipher.Encrypt(plainText, shift));
                        Console.WriteLine(cipherText);
                    }
                    else
                    {
                        ErrorMessage("Enter a number between 1 to 26");
                    }
                }
                catch (Exception e)
                {
                    ErrorMessage(e.Message);
                }
            }
            else
            {
                ErrorMessage("Invalid input");
            }
        }
        #endregion

        #region Perform Decrypt operation
        private static void PerformDecryptOperation(out string filePath, out string fileName, ref string cipherText, out int shift, ref StreamReader sr)
        {
            shift = 0; fileName = string.Empty;
            AppMessage("Welcome to decryption mode \nEnter the path of file to decrypt");
            filePath = Console.ReadLine();

            if (filePath != "")
            {
                AppMessage("Enter file name");
                fileName = Console.ReadLine();
                if (fileName != "")
                {
                    filePath = filePath + "/" + fileName;

                    AppMessage("Enter the shift");

                    try
                    {
                        shift = int.Parse(Console.ReadLine());
                        if (shift <= 26 && shift > 0)
                        {
                            sr = new System.IO.StreamReader(filePath);
                            cipherText = sr.ReadToEnd();

                            cipherText = new string(CaeserCipher.Decrypt(cipherText, shift));
                            AppMessage("Cipher is");
                            Console.WriteLine(cipherText);

                            sr.Close();
                        }
                        else
                        {
                            ErrorMessage("Enter a number between 1 to 26");
                        }

                    }
                    catch (Exception e)
                    {
                        ErrorMessage(e.Message);
                    }
                }
                else
                {
                    ErrorMessage("File name cannot be empty");
                }
            }
            else
            {
                ErrorMessage("Path is invalid");
            }
        }
        #endregion
    }

    #region CaeserCipher
    class CaeserCipher
    {
        #region Cipher Encryption Code
        public static char[] Encrypt(string plainText, int shift)
        {
            char[] plainArray = plainText.ToLower().ToCharArray();
            char[] cipherArray = new char[plainArray.Length];

            for (int i = 0; i < plainArray.Length; i++)
            {
                char letter = plainArray[i];
                if (!(Char.IsWhiteSpace(letter)))
                {
                    letter = (char)(letter + shift);
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                    cipherArray[i] = letter;
                }
                else
                {
                    cipherArray[i] = ' ';
                }
            }
            return cipherArray;
        }
        #endregion

        #region Cipher Decryption Code
        public static char[] Decrypt(string cipherText, int shift)
        {
            char[] cipherArray = cipherText.ToLower().ToCharArray();
            char[] plainArray = new char[cipherArray.Length];

            for (int i = 0; i < cipherArray.Length; i++)
            {
                char letter = cipherArray[i];
                if (!(Char.IsWhiteSpace(letter)))
                {
                    letter = (char)(letter + shift);
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                    plainArray[i] = letter;
                }
                else
                {
                    plainArray[i] = ' ';
                }
            }
            return plainArray;
        }
        #endregion
    }
    #endregion
}
