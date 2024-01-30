int[] numbers;
int[] nums = new int[4];
int[] nums2 = new int[4] { 1, 2, 3, 5 };
int[] nums3 = new int[] { 1, 2, 3, 5 };
int[] nums4 = new[] { 1, 2, 3, 5 };
int[] nums5 = { 1, 2, 3, 5 };
//-------
int[] numbers1 = { 1, 2, 3, 5 };
// получение элемента массива
Console.WriteLine(numbers1[3]);  // 5
// получение элемента массива в переменную
var n = numbers1[1];     // 2
Console.WriteLine(n);  // 2
                       //------------
int[] numbers2 = { 1, 2, 3, 5 };
numbers2[1] = 505;
Console.WriteLine(numbers2[1]);  // 505
//----------
int[] numbers3 = { 1, 2, 3, 5 };
Console.WriteLine(numbers3.Length);
//------------
int[] numbers4 = { 1, 2, 3, 5 };
Console.WriteLine(numbers4[numbers4.Length - 1]);
Console.WriteLine(numbers4[numbers4.Length - 2]); 
Console.WriteLine(numbers4[numbers4.Length - 3]);

//--------
int[] numbers5 = { 1, 2, 3, 4, 5 };
foreach (int i in numbers5)
{
    Console.WriteLine(i);
}
//------
int[] numbers6 = { 1, 2, 3, 4, 5 }; for (int i = 0; i < numbers6.Length; i++)
{
    Console.WriteLine(numbers6[i]);
}