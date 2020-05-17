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
            int middleIndex = array.Length/2;
            int arraySerchLength = array.Length/2;

            do {
                Console.WriteLine("MiddleIndex: " + middleIndex + " / Length: " + arraySerchLength);

                if(middleIndex >= array.Length)
                    middleIndex = array.Length - 1;

                if(targetValue == array[middleIndex])
                    return middleIndex;

                if(arraySerchLength == 1)
                    break;

                arraySerchLength = (int)Decimal.Ceiling((decimal)arraySerchLength/(decimal)2);

                if(targetValue > array[middleIndex]) {
                    middleIndex += arraySerchLength;
                } else {
                    middleIndex -= arraySerchLength;
                }
            } while(arraySerchLength > 0);
            
            return -1;            
        }
    }
}
