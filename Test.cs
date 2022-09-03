void task1()
{
    int counter = 0;
    string[] words = {"Hello ", "world ", "QA ", "AAA "};

    for(int i = 0; i < words.Length; i++)
    {
        Console.Write(words[i]);
             
    }
    Console.WriteLine("");
    Console.WriteLine("");

    for (int i = 0; i < words.Length; i++)
    {  
        int length = words[i].Length - 1;
        if (length <= 3)
        {                        
            Console.WriteLine("Слова в которых не больше трёх символов - " + words[i]);
            counter++;                        
        }  
    }
                
    Console.WriteLine("");

    string[] solution = new string[counter];
    Console.WriteLine("Размер массива solution равен " + solution.Length);
    for (int i = 0; i < words.Length; i++)
    {
        int length = words[i].Length - 1;
        if (length <= 3)
        {                        
            int y = 0;
            solution[y] = words[i];
            Console.Write(solution[y]);
            y++;                        
        }
                
    }

    

}
task1();