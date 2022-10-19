using System.Xml.Linq;

namespace QuickSort
{
    class program
    {
        //array of integers to hold values
        private int[] arr = new int[20];
        private int cmp_count = 0; //array of number comparasion
        private int mov_count = 0; //array of data movements

        //Number of elements in array
        private int n;

        void input()
        {
            while (true)
            {
                Console.WriteLine("Enter the number of elements in array : ");
                string s = Console.ReadLine();
                n = 0;
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 20 elements \n");
            }
            Console.WriteLine("\n=====================");
            Console.WriteLine("\nEnter Array Elements");
            Console.WriteLine("\n=====================");

            //Get Array Elements
            for (int i =0;i <n;i++)
            {
                Console.Write("<" + (i+1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        //swap the element at index x with the elemnt at index y

        void swap(int x, int y)
        {
            int temp = arr[x]; 
            arr[x] = arr[y];
            arr[y] = temp;
        }
        public void q_sort(int low, int high)
        {
            int pivot, i, j;
            if (low > high)
                return;

            //Partition the list into two part
            //one containing elements less that or equal to pivot
            //Outher conntaining elements greather than pivot

            i = low + 1;
            j = high;

            pivot = arr[low];

            while (i <= j)
            {
                //Search for an element grater than pivot
                while ((arr[i] <= pivot) && (i <= high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;

                //Search for an element less than or equal to pivot
                while ((arr[j] > pivot) && (j >= low))
                {
                    j--;
                    cmp_count++;
                }
                cmp_count++;

                if (i < j)//if the grater element is on the left of element
                {

                }
            }
        }
    }
}