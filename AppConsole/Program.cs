using System.Linq;
using System;

namespace AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iniciando...!");
            int[] arr = new int[]{ 1, 5, 8, 9, 12, 14, 16 };
            int[] arr2 = new int[]{ 1, 5, 8, 9, 12, 14, 16, 18, 19, 20 };
            int[] arr3 = new int[]{ 1, 2,3,4,5 };

            foreach(int targetValue in arr) {
                int positionResult = BinarySearch.Search(targetValue, arr);
                Console.WriteLine($"Search in [{ String.Join(',', arr) }] { targetValue } -> " + positionResult);
            }

            foreach(int targetValue in arr2) {
                int positionResult = BinarySearch.Search(targetValue, arr2);
                Console.WriteLine($"Search in [{ String.Join(',', arr2) }] { targetValue } -> " + positionResult);
            }

            foreach(int targetValue in arr3) {
                int positionResult = BinarySearch.Search(targetValue, arr3);
                Console.WriteLine($"Search in [{ String.Join(',', arr3) }] { targetValue } -> " + positionResult);
            }
        }
    }

    public class BinarySearch 
    {
        public static int Search(int targetValue, int[] array)
        {
            int rightEdge = array.Length -2;
            int leftEdge = 0;

            do {
                int middleIndex = leftEdge + (rightEdge-leftEdge)/2;
    
                if(targetValue == array[middleIndex])
                    return middleIndex;

                if(targetValue > array[middleIndex]) {
                    leftEdge = middleIndex +1;
                } else {
                    rightEdge = middleIndex -1;
                }
            } while(leftEdge <= rightEdge);
            
            return -1;            
        }
    }
}
