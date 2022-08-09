// выводит массив из 8 эл-тов, заполненный 0 и 1 рандомно

//int mass(int random)
///{
  //int x = new Random().Next(0, 2);
 // return x;
//}

//Console.WriteLine($"{mass(1)},{mass(1)},{mass(1)},{mass(1)},{mass(1)},{mass(1)},{mass(1)},{mass(1)}");




int[] getNewArray(int lenghtarr)
{
    int[] array = new int[lenghtarr];

    for (int i = 0; i < array.Length; i++)
    {
         array[i] = new Random().Next(0, 2);
    }
    return array;
}

foreach ( int item in getNewArray(8))
{
    Console.Write(item + " ");
}