namespace Sorting
{
    using System.Diagnostics; 
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 100;
            int iterations = 10000000; //10,000,000
            int[] mainArray = RandomArray(arrayLength); //Our main array
            int[] tempArray = new int[arrayLength]; //Temproary array. because we will do sorting algorithms so many times so we dont want our mainarray to change or modified!
            Stopwatch timer = new Stopwatch(); //We need a timer for measure the time.


            Console.WriteLine("Measuring Started Please Wait...");
            Console.WriteLine();

    //---------------------------------------------------------------Measure For Bubble Sort---------------------------------------------------------------------------------------

            timer.Start(); //Start the timer
            for (int i = 0; i < iterations; i++)
            {
                Array.Copy(mainArray, tempArray, arrayLength); //copy the array in every iteration to the temproary array
                BubbleSort(tempArray);
            }  
            timer.Stop();  //Stop the timer
            Console.WriteLine("Bubble Sort: {0} ms ({1} s)" , timer.ElapsedMilliseconds , timer.Elapsed.TotalSeconds);

    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            timer.Reset();

     //---------------------------------------------------------------Measure For Insertion Sort------------------------------------------------------------------------------------

            timer.Start(); //Start the timer
            for (int i = 0; i < iterations; i++)
            {
                Array.Copy(mainArray, tempArray, arrayLength); //copy the array in every iteration to the temproary array
                InsertionSort(tempArray);
            }
            timer.Stop();  //Stop the timer
            Console.WriteLine("Insertion Sort: {0} ms ({1} s)", timer.ElapsedMilliseconds, timer.Elapsed.TotalSeconds);

            //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


            Console.WriteLine();
            Console.WriteLine("Test Finished!");
            Console.ReadLine();
        }




        //Bubble sort method:
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;


            for (int i = 0; i < n - 1; i++)  //iterate it n times
            {

                // last i numbers are already in the right place
                for (int j = 0 ; j < n - i - 1 ; j++)
                {
                    if (arr[j] > arr[j+1])  //swap the number at jth index and j+1th index
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        //Insertion sort method:
        public static void InsertionSort(int[] arr)
        {
            for (int i = 1;i < arr.Length;++i)
            {
                int toBeInserted = arr[i];
                int j = i - 1;


                while (j >= 0 && arr[j] > toBeInserted)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = toBeInserted;
            }
        }

        //Method for constructing array with random numbers in it:
        static int[] RandomArray(int len)
        {
            Random rand = new Random();
            int[] arr = new int[len];


            for (int i = 0 ; i < len; i++)
            {
                arr[i] = rand.Next(1, 1001); //random number from 1 to 1000:  [1,1000]
            }
            return arr;
        }
    }


    
    /*Theorically both of insertion sort and bubble sort have same complexity O(n^2) but we see that insertion sort is way way faster than bubble sort.
      Insertion Sort has more advantages over Bubble Sort (and occasionally over advanced algorithms) in scenarios where the dataset is small or already partially
      sorted.  Bubble Sort lags behind Insertion Sort in performance across almost all scenarios due to the excessive number of swap operations it requires,
      and it is generally preferred solely for educational purposes  */

    //Time Complexity:
    /* Bubble Sort:
      It consists of two nested loops. The inner loop decreases by one in each iteration (N-1, N-2...).
      Using the Gauss sum formula : the result is derived as n^2.
      

      Insertion Sort: 
      In the worst case scenario (if the array is reverse sorted), each element requires a backwards comparison with all preceding elements.
      Using the same formula: the result is also n^2.
      
      Extra Point:
      Remember the "Best Case" for Insertion Sort; if the array is already sorted, the complexity becomes O(n). 
      This mathematically supports why it is faster than Bubble Sort.*/

}
