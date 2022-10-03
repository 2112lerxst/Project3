namespace Project3
{
    internal class Program
    {


        //It doesn't work and I don't know how to fix it.
        //Take user input to look for file
        //Write line
        //Create new jagged array
        //Look for file with streamreader(?)
        static void Main(string[] args)
        {
            string uInput = methodman.Read("Enter file: ");
            Console.WriteLine(uInput);
            int[][] jaggedArray = new int[20][];
            StreamReader sr = new StreamReader(Path.GetFullPath("inputJagged.csv"));


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


    } }
