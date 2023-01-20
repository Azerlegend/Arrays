//int[] array = new int[] { 100, 300, 200, 50 };
//for (int i = 0; i < array.Length; i++)
//{
//    int minimumIndex = i;

//    for (int j = i; j < array.Length; j++)
//    {
//        if (array[minimumIndex] > array[j])
//        {
//            minimumIndex = j;
//        }
//    }


//    int k = array[i];
//    array[i] = array[minimumIndex];
//    array[minimumIndex] = k;


//    Console.WriteLine(array[i]);
//}




//using System.Diagnostics.CodeAnalysis;

//int[] array = new int[] { 500, 600, 100, 50 };
//double Sum = 0;
//double averagelement = 0;
//for (int i = 0; i < array.Length; i++)
//{
//    Sum += array[i];
//}
//averagelement = Sum / array.Length;
//Console.WriteLine(averagelement);















int[] array = new int[] { 100, 200, 500, 400 };
int temp;
for (int i = array.Length - 1; i >= 0; i--)
{
    for (int j = 0; j < array.Length ; j++)
    {
        if (array[j] > array[i])
        {
            temp = array[i];
            array[i] = array[j];
            array[i] = temp;

        }

    }
    Console.WriteLine(array[i]);
}







