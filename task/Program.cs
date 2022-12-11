// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучшеstring[] array1 = new string[5] {"123", "23", "hello", "world", "res"};

string[] FirstArray = new string[7] {"hello", "!", "world", ":)", "hi", "yes!", "no"};
string[] SecArray = new string[FirstArray.Length];
int count = 0;
    for (int i = 0; i < FirstArray.Length; i++)
       
    {
        
        if (FirstArray[i].Length <= 3)
        {
            SecArray[count] = FirstArray[i];
            count++;
            
        }
       
    }
    
    Console.Write("новый массив: " +String.Join(" ", SecArray)); 
