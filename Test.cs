void task1()
{
    string[] words = {"Hello ", "world ", "2 ","AAA "};
        {
            for (int i = 0; i < words.Length; i++)
                {
                    Console.Write(words[i]);
                
                }
                
        }
        Console.WriteLine("");
        Console.WriteLine("");
    
    string[] solution = words;
        for (int i = 0; i < words.Length; i++)
                {
                    int length = solution[i].Length - 1;
                    if (length <= 3)
                    {
                        Console.WriteLine("Слова в которых не больше трёх символов - " + words[i]);
                        Console.WriteLine("");
                    }
                    
               }
   
}
task1();