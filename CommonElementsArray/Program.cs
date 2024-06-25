class CommonElementsArray
{
    static void Main()
    {
        
        int[] numbers1 = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();
        int[] numbers2 = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();

        for (int i = 0; i < numbers1.Length; i++)
        {
            int currentNumber=numbers1[i];
            foreach(int number in numbers2){
                if (currentNumber==number){
                    Console.Write($"{number} ");
                    break; 
                } 
            }
        } 
    }
        }