using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Storing an Array #1

            //Console.WriteLine("Input 10 elements in the array :");
            //int[] arr = new int[10];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Element - {0} : ",i);
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("\n\nElements stored in the Array are : ");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("{0} ", arr[i]);
            //}
            //Console.ReadLine();
            #endregion
            #region Reversing an Array #2
            //Console.WriteLine("Input the number of elements store in the array :");
            //int num01 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Input {0} elements in the arrar :", num01);
            //int[] arr2 = new int[num01];

            //for (int i = 0; i < num01; i++)
            //{
            //    Console.Write("Element - {0} : ", i);
            //    arr2[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("\n\nElements stored in the Array are : ");

            //for (int i = 0; i < num01; i++)
            //{
            //    Console.Write("{0} ", arr2[i]);
            //}

            //Console.WriteLine("\n\nElements reversed in the Array are : ");

            //for (int i = num01-1; i >= 0; i--)
            //{
            //    Console.Write("{0} ", arr2[i]);
            //}
            //Console.ReadLine();

            #endregion
            #region SUM of an Array #3
            //int sum = 0;
            //Console.WriteLine("Input the number of elements store in the array :");
            //int num01 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Input {0} elements in the arrar : \n", num01);
            //int[] arr3 = new int[num01];

            //for (int i = 0; i < num01; i++)
            //{
            //    Console.Write("Element - {0} : ", i);
            //    arr3[i] = int.Parse(Console.ReadLine());

            //}

            //for (int i = 0; i < num01; i++)
            //{
            //    sum += arr3[i];
            //}
            //Console.WriteLine("\n\nSum of all elements stored in array : {0} ",sum);

            //Console.ReadKey();
            #endregion
            #region Copy one Array to another Array #4

            //Console.WriteLine("Input the number of elements store in the array :");
            //int num01 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Input {0} elements in the arrar : \n", num01);
            //int[] arr4 = new int[num01];
            //int[] arrCopy = new int[arr4.Length];

            //for (int i = 0; i < num01; i++)
            //{
            //    Console.Write("Element - {0} : ", i);
            //    arr4[i] = int.Parse(Console.ReadLine());

            //}

            //for (int i = 0; i < num01; i++)
            //{
            //    arrCopy[i] = arr4[i];
            //}
            //Console.WriteLine("\n\nall elements stored in frist array");

            //for (int i = 0; i < num01; i++)
            //{
            //    Console.Write("{0} ", arr4[i]);
            //}
            //Console.WriteLine("\n\nelements copied into second array");

            //for (int i = 0; i < num01; i++)
            //{
            //    Console.Write("{0} ", arrCopy[i]);
            //}


            //Console.ReadKey();
            #endregion
            #region Find the number of duplicate elements in an Array #5

            //int count = 0;
            //Console.WriteLine("Input the number of elements store in the array :");
            //int num01 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Input {0} elements in the arrar : \n", num01);
            //int[] arr4 = new int[num01];

            //for (int i = 0; i < num01; i++)
            //{
            //    Console.Write("Element - {0} : ", i);
            //    arr4[i] = int.Parse(Console.ReadLine());

            //}
            //for (int i = 0; i < num01; i++)
            //{

            //    for (int j = i + 1; j < num01; j++)
            //    {
            //        for (int k = i - 1; k >= 0; k--)
            //        {
            //            if (arr4[i] == arr4[j])
            //            {
            //                count += 1;
            //            }
            //            if (arr4[i] == arr4[k])
            //            {
            //                count += 1;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine("\n\n The number of duplicate elements are {0}",count);


            //Console.ReadKey();
            #endregion
            #region Find the unique elements in an Array #6

          //  int count = 0;
          //  Console.WriteLine("Input the number of elements store in the array :");
          //  int num01 = int.Parse(Console.ReadLine());

          //  Console.WriteLine("Input {0} elements in the arrar : \n", num01);
          //  int[] arr6 = new int[num01];

          //  for (int i = 0; i < num01; i++)
          //  {
          //      Console.Write("Element - {0} : ", i);
          //      arr6[i] = int.Parse(Console.ReadLine());

          //  }


          //  Console.WriteLine("\n\n The unique elements in the array are are : ");
          //  for (int i = 0; i < num01; i++)
          //  {
          //      count = 0;
          //      for (int j = 0; j < i - 1; j++)
          //      {
          //          if (arr6[i] == arr6[j])
          //          {
          //              count++;
          //          }
          //      }
          //      for (int k = i+1; k < num01; k++)
          //      {
          //             if (arr6[i] == arr6[k])
          //              {
          //                  count += 1;
          //              }
          //          }
          //      if (count == 0)
          //      {
          //          Console.Write("{0} ",arr6[i]);
          //      }
          //}
            

          //  Console.ReadKey();
            #endregion

        }
    }
}
