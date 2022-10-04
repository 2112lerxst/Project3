namespace Project3
{
    internal class Program
    {


        //It doesn't work and I don't know how to fix it.
        static void Main(string[] args)
        {
            string uInput = methodman.Read("Enter file: ");//Take user input to look for file
            Console.WriteLine(uInput);//Write line to take user input
            int[][] jaggedArray = new int[20][];//Create new jagged array
            StreamReader sr = new StreamReader(Path.GetFullPath("inputJagged.csv")); //Look for file with streamreader(?)


        }

        //Sort method. Method is taken from: https://code-maze.com/csharp-merge-sort/ its the only one I understood how to do
        //Left side greater than right.
        //Middle is value looking for
        //Left is left boundary
        //Right is right boundary

        public int[] SortArray(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                SortArray(array, left, middle);  //Calls sort to sort left side
                SortArray(array, middle + 1, right); //Calls sort to right side
                MergeArray(array, left, middle, right);
            }
            return array;
        }


        //Method merges array.
        //Takes 4 values
        //Array is value needed to be sorted
        //left boundary
        //right boundary
        //middle pivot point
        public void MergeArray(int[] array, int left, int middle, int right) 
        {
            var leftArrayLength = middle - left + 1;

            var rightArrayLength = right - middle;

            var leftTempArray = new int[leftArrayLength]; //left

            var rightTempArray = new int[rightArrayLength]; // right array

            int i, j;
            for (i = 0; i < leftArrayLength; ++i) //Fill left array
                leftTempArray[i] = array[left + i];
           
            for (j = 0; j < rightArrayLength; ++j)        //Fill right array
               rightTempArray[j] = array[middle + 1 + j];
            
            i = 0; //i becomes left erray
           
            j = 0; //j becomes right
           
            int k = left; //
            while (i < leftArrayLength && j < rightArrayLength) //Left now gets compared to right
            {
                if (leftTempArray[i] <= rightTempArray[j]) //Left smaller
                {
                    array[k++] = leftTempArray[i++]; //Left added to sorted array
                }
                else //right
                {
                    array[k++] = rightTempArray[j++]; //right added to sorted array
                }
            }
           
            while (i < leftArrayLength)
            {
                array[k++] = leftTempArray[i++];
            }
           
            while (j < rightArrayLength)
            {
                array[k++] = rightTempArray[j++];
            }
        }

        //Merge sort result has to be printed
        //Runs through method in methodman
        static void printMerge(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                methodman.printArra(jaggedArray[i]);

            }
        }


        //https://www.tutorialspoint.com/Binary-search-in-Chash Used this as format for binary, replaced with min and max with left and right values
        //https://www.c-sharpcorner.com/blogs/binary-search-implementation-using-c-sharp1 also this
        //Binary search works by taking left boundary and comparing to right
        //If left is not greater than right, start in middle, then searches the right boundary
        //Array is what the user wants to search, key is the value looking for 
        //
        public static object BinarySearch(int[] arr, int key)
        {
            int index = arr[key]; //Binary has to return an index value, or a -1 if value is missing from array
            int left = 0; //Start at left value
            int right = arr.Length - 1;

            while (left <= right) //While left less than right
            {
                int mid = (left + right) / 2; //Go to middle and split array
                if (key == arr[mid]) //If key found in middle, return key
                {
                    return ++mid;
                }
                else if (key < arr[mid]) //If key not found in middle
                {
                    right = mid - 1; //Search right again
                }
                else //If key not found 
                {
                    left = mid + 1; //Search left side
                }
            }
            return index;
        }
        //Binary result has to be printed

    } }
