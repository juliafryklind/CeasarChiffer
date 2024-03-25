namespace gerdasCeasarChiffer
{
    class Program
    {
        //Mainmetod
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            bool isRunning = true;

            while (isRunning)
            {
                Console.ReadKey();
                int nKey = Random.Shared.Next(0, 195); //slumpar fram nyckeln
                Console.WriteLine("Skriv in datan du vill kryptera:");
                string userInput = Console.ReadLine(); //läser in användardata
                char[] charArray = userInput.ToCharArray();
                int[] decryptedNumbers = new int[charArray.Length]; //dekrypterade nummer för respektive tecken
                int[] encryptedNumbers = new int[charArray.Length]; //krypterade nummer för respektive tecken
                char[] decryptedChars = new char[charArray.Length]; //dekrypterade tecken
                char[] encryptedChars = new char[charArray.Length]; //krypterade tecken

                Console.WriteLine("Krypterad data:");
                for (int i = 0; i < charArray.Length; i++)
                {
                    int j = (int)charArray[i] + nKey; //räknar fram ny position
                    encryptedNumbers[i] = j; //sätter numret för position i array
                    encryptedChars[i] = (char)j; //sätter tecknet för denna position
                    Console.Write(encryptedChars[i]); //skriver ut tecken
                }
                Console.WriteLine("");
                Console.WriteLine("Den ursprungliga datan:");

                for (int i = 0; i < charArray.Length; i++) //skriver ut originaldata, dekrypterar mha nyckeln
                {
                    int j = (int)encryptedNumbers[i] - nKey; //räknar fram originaltecknets position
                    decryptedNumbers[i] = j;  //sätter numret för position i array
                    decryptedChars[i] = (char)j; //sätter tecknet för denna position
                    Console.Write(decryptedChars[i]); //skriver ut tecknet
                }
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}

