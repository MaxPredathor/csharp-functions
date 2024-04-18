namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void StampaArray(int[] array)
            {
                Console.Write("[");
                foreach (int i in array)
                {
                    Console.Write($" {i},");
                }
                Console.WriteLine("]");
            }

            int Quadrato(int numero)
            {
                return numero * numero;
            }

            int[] ElevaArrayAlQuadrato(int[] array)
            {
                int[] cloneArray = new int[array.Length];
                for(int i = 0; i < array.Length; i++)
                {
                    cloneArray[i] = Quadrato(array[i]);
                }

                return cloneArray;
            }

            int sommaElementiArray(int[] array)
            {
                int somma = 0;
                foreach (int i in array)
                {
                    somma += i;
                }
                return somma;
            }

            int[] testArray = [2, 6, 7, 5, 3, 9];

            StampaArray(testArray);
            StampaArray(ElevaArrayAlQuadrato(testArray));
            StampaArray(testArray);
            Console.WriteLine(sommaElementiArray(testArray));
            Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(testArray)));

            Console.WriteLine("Inserisci quanto lungo deve essere l'Array");
            int[] myArray = new int[Convert.ToInt32(Console.ReadLine())];
            for(int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Inserire il valore numero {i + 1}");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            StampaArray(myArray);
        }
    }
}
