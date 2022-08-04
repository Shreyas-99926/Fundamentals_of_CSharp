////Dynamic Collection
////Storing n number of integers
////int[] n = new int[3];
////n[0] = 1;
////n[1] = 2; 
////n[2] = 3;


//DynamicIntArray numbers = new DynamicIntArray();

////store
//numbers.Add(10);
//numbers.Add(20);

////read
//for(int i = 0; i < numbers.count; i++)
//{
//    Console.WriteLine(numbers.Get(i));
//}

////create a class for dynamic int array
//public class DynamicIntArray
//{
//    internal void Add(int v)
//    {
//        if (count < data.Lenght)//its empty
//        {
//            data[count++] = n;
//        }
//        else//its full
//        {
//            int[] temp = new int[data.Length * 2];
//            //copy old data  into new array
//            Array.Copy(data, temp, data.Length);
//            temp[count++] = new;
//            data = temp;

//            Array.Resize(ref data, data.Length * 2);// use this code instead of that
//        }
//        //throw new NotImplementedException();
//    }
//    public int Get(int i)
//    {
//        throw new NotImplementedException();
//    }
//    public int count
//    {
//        get { return count; }
//    }
//}
//------------------------------------------------------------------------------------------------
//---------------------------------------------Sir Code-------------------------------------------
//------------------------------------------------------------------------------------------------
// store n number of ints
//declare
//DynamicIntArray numbers = new DynamicIntArray();

////store
//numbers.Add(101);
//numbers.Add(202);
//numbers.Add(203);
//numbers.Add(204);
//numbers.Add(205);
//numbers.Add(206);
//numbers.Add(207);
//numbers.Add(208);
//numbers.Add(209);
//numbers.Add(210);
//numbers.Add(211);
//numbers.Add(212);
//numbers.Add(213);

//numbers.Add(101);
//numbers.Add(202);
//numbers.Add(203);
//numbers.Add(204);
//numbers.Add(205);
//numbers.Add(206);
//numbers.Add(207);
//numbers.Add(208);
//numbers.Add(209);
//numbers.Add(210);
//numbers.Add(211);
//numbers.Add(212);
//numbers.Add(213);


////read
//for (int i = 0; i < numbers.Count; i++)
//{
//    Console.WriteLine(numbers.Get(i));
//}

//public class DynamicIntArray
//{
//    private int[] data = new int[10];
//    int count = 0;
//    public void Add(int n)
//    {
//        if (count < data.Length) // its empty
//        {
//            data[count++] = n;
//        }
//        else // its full
//        {
//            //// create a new array
//            //int[] temp = new int[data.Length * 2];
//            //// copy old data into new array
//            //Array.Copy(data, temp, data.Length);
//            //temp[count++] = n;
//            //data = temp;

//            Array.Resize(ref data, data.Length * 2);
//        }
//    }

//    public int Get(int i)
//    {
//        return data[i];
//    }

//    public int Count
//    {
//        get { return count; }

//    }
//}



//----------------------------------------------------------------------------------
//---------------------------------------Double Dynamic array-----------------------
//----------------------------------------------------------------------------------
// store n number of ints
//declare
//DynamicDoubleArray numbers = new DynamicDoubleArray();

////store
//numbers.Add(101);
//numbers.Add(202);
//numbers.Add(203);
//numbers.Add(204);
//numbers.Add(205);
//numbers.Add(206);
//numbers.Add(207);
//numbers.Add(208);
//numbers.Add(209);
//numbers.Add(210);
//numbers.Add(211);
//numbers.Add(212);
//numbers.Add(213);

//numbers.Add(101);
//numbers.Add(202);
//numbers.Add(203);
//numbers.Add(204);
//numbers.Add(205);
//numbers.Add(206);
//numbers.Add(207);
//numbers.Add(208);
//numbers.Add(209);
//numbers.Add(210);
//numbers.Add(211);
//numbers.Add(212);
//numbers.Add(213);


////read
//for (int i = 0; i < numbers.Count; i++)
//{
//    Console.WriteLine(numbers.Get(i));
//}

//public class DynamicDoubleArray
//{
//    private double[] data = new double[10];
//    int count = 0;
//    public void Add(double n)
//    {
//        if (count < data.Length) // its empty
//        {
//            data[count++] = n;
//        }
//        else // its full
//        {
//            //// create a new array
//            //int[] temp = new int[data.Length * 2];
//            //// copy old data into new array
//            //Array.Copy(data, temp, data.Length);
//            //temp[count++] = n;
//            //data = temp;

//            Array.Resize(ref data, data.Length * 2);
//        }
//    }

//    public double Get(int i)
//    {
//        return data[i];
//    }

//    public double Count
//    {
//        get { return count; }

//    }
//}


//------------------------------------------------------------------------------------
//-----------------------------------Generics-----------------------------------------
//------------------------------------------------------------------------------------

//store n integers
List<int> numbers = new List<int>();
numbers.Add(10);
numbers.Add(20);

for(int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}
foreach(int i in numbers)
{
    Console.WriteLine(i);
}
Console.WriteLine(numbers[1]);

//numbers.Insert(0, 10);// not effficient very slow instead use Add
//numbers.RemoveAt(10); 10 is a index position.
//numbers.Sort();

//Queue
Queue<int> queue = new Queue<int>();
//Add data
queue.Enqueue(10);
//to read and deletes
queue.Dequeue();
// to only read 
queue.Peek();

//Stack
Stack<int> stack = new Stack<int>();
//push to stack
stack.Push(10);
//reada and delete
stack.Pop();
//to only read
stack.Peek();

//Hashset
HashSet<int> hs = new HashSet<int>();//store unique data
hs.Add(10);
hs.Add(10); //does not read the duplicate value.

//Dictionary
Dictionary<int, string> result = new Dictionary<int, string>();
//write
result.Add(10, "pass");
result.Add(20, "fail");

//read
string r = result[222];
Console.WriteLine(r);






