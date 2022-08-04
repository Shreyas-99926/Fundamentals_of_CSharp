//storing single int
int a = 10; //Scalar variable
Console.WriteLine("Enter the size of array:");
int size = int.Parse(Console.ReadLine());
int[] numbers = new int[size]; //store 10 integers //static allocation 

for(int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Enter number {i +1}:");//taking value to the user
    numbers[i] = int.Parse(Console.ReadLine());
}

//find the sum
int sum = 0;
for(int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}
Console.WriteLine($"sum of all numbers {sum} :");

//display all values
foreach(int i in numbers)
{
       Console.WriteLine($"the values in array are {i}:");
}

//average of all numbers 
double avg = numbers.Average();
//sum
sum = numbers.Sum();
//max value
int max = numbers.Max();
//min
int min = numbers.Min();    
//sort
Array.Sort(numbers);
//copy of array
int[] numbers2 = new int[numbers.Length];
Array.Copy(numbers, numbers2, numbers.Length);

//Storing words in array
String[] word = new string[5];//one type
word[0] = "one";
word[0] = "two";

//Array initialization //single dimension
string[] words1 = new string[3] { "one", "two", "three" };//second type
string[] words2 = new string[] { "one", "two", "three" };//third type
string[] words3 = {"one", "two", "three" };//fourth type 

//creating multidimensional array
int[,] twod = new int[3, 5];

//Jogged arrays (Array of Arrays)
int[][] score = new int[3][]; //first only declare no of rows 
score[0] = new int[5];//second step declare no of columns for each row
score[1] = new int[2];
score[2] = new int[10];



