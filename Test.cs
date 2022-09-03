void task1()
{
    int counter = 0;
    string var ="";
    string[] words = {"Hello ", "world ", "QA ","AAA "};
        {
            for (int i = 0; i < words.Length; i++)
                {
                    Console.Write(words[i]);
                
                }
                
        }
        Console.WriteLine("");
        Console.WriteLine("");
    
    string[] examination = words;
        for (int i = 0; i < words.Length; i++)
                {
                    int length = examination[i].Length - 1;
                    if (length <= 3)
                    {
                        Console.WriteLine("Слова в которых не больше х символов - " + words[i]);
                        Console.WriteLine("");
                        counter++;
                        var = words[i];
                        
                    }
                    
               }

    string[] solution = new string[counter];
        Console.WriteLine("Размер массива solution равен " + solution.Length);
        for( int i = 0; i < solution.Length; i++)
            {
                solution[i] = var;
                Console.WriteLine(solution[i]);
            }
        

            
        
   
}
task1();