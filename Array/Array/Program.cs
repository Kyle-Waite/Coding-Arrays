using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
<<<<<<< HEAD
  class Program
  {
    static void Main(string[] args)
    {
      /*To See any of the arrays function simply uncomment them below:*/
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
      #region Merge two arrays & sort in ascending order. #7

      //int i,j,k ;

      //Console.WriteLine("Input the number of elements to be stored in the first array: ");
      //int firstInput = int.Parse(Console.ReadLine());
      //int[] first_arr = new int[firstInput];

      //Console.WriteLine("\nInput {0} elemets in the array : \n",firstInput);

      //for(i = 0; i < firstInput; i++)
      //{
      //  Console.Write("Element - {0} : ",i);
      //  first_arr[i] = int.Parse(Console.ReadLine());  
      //}

      //Console.WriteLine("\nInput the number of elements to be stored in the second array: ");
      //int secondInput = int.Parse(Console.ReadLine());
      //int[] second_arr = new int[secondInput];

      //Console.WriteLine("\nInput {0} elemets in the array : \n", secondInput);

      //for (i = 0; i < secondInput; i++)
      //{
      //  Console.Write("Element - {0} : ", i);
      //  second_arr[i] = int.Parse(Console.ReadLine());
      //}

      //int mergedLength = firstInput + secondInput;

      //int[] merged_arr = new int[mergedLength];

      //for (i = 0; i < firstInput; i++)
      //{
      //  merged_arr[i] += first_arr[i];
      //}
      //for (j = 0; j < secondInput; j++)
      //  {
      //    merged_arr[i] += second_arr[j];
      //  i++;
      //  }

      //for (i = 0; i < mergedLength; i++)
      //{
      //  for (j = 0;  j< mergedLength-1; j++)
      //  {
      //    if (merged_arr[j] >= merged_arr[j + 1])
      //    {
      //      k = merged_arr[j + 1];
      //      merged_arr[j + 1] = merged_arr[j];
      //      merged_arr[j] = k;
      //    }
      //    }
      //  }

      //Console.WriteLine("\nThe merged_Array elements in ascending order are: \n");

      //for (i = 0; i < mergedLength; i++)
      //{
      //  Console.WriteLine("Element  {0} : {1}",i,merged_arr[i]);
      //}
      //Console.ReadKey();

      #endregion
      #region Count the Frequnecy of an Element in an Array #8

      //  int count, i,j;


      //  Console.WriteLine("Input the number of elements to store in the array: ");

      //  int firstInput = Convert.ToInt32(Console.ReadLine());

      //  int[] _arr = new int[firstInput];
      //  int[] _frq = new int[firstInput];

      //  Console.WriteLine("\nInput {0} elements into the array : \n",firstInput);

      //  for (i = 0; i < firstInput; i++)
      //  {
      //    Console.Write("Element - {0} : ",i);
      //    _arr[i] = Convert.ToInt32(Console.ReadLine());
      //    _frq[i] = -1;
      //  }

      //  for (i = 0; i < firstInput; i++)
      //  {
      //    count = 1;
      //    for (j = i + 1; j < firstInput ; j++)
      //    {
      //      if (_arr[i] == _arr[j])
      //      {
      //        count++;
      //        _frq[j] = 0;
      //      }
      //    }
      //    if (_frq[i] != 0)
      //    {
      //      _frq[i] = count;
      //    }
      //  }
      //  Console.WriteLine("\nThe number of times elements occur in the array :\n");

      //  for (i = 0; i < firstInput; i++)
      //  {
      //    if (_frq[i] != 0)
      //    {
      //      Console.WriteLine("{0} occurs {1} times in the array",_arr[i],_frq[i]);
      //    }
      //  }
      //  Console.ReadKey();

      #endregion
      #region Finding the Max\Min Element in an Array #9
      //  int firstInput, i, max, min;

      //  Console.WriteLine("Input number of elements to store in the array :");
      //  firstInput = int.Parse(Console.ReadLine());

      //  Console.WriteLine("\nInput {0} elements into the array :\n",firstInput);

      //  int[] arr = new int[firstInput];

      //  for (i = 0; i < firstInput; i++)
      //  {
      //    Console.Write("Element - {0} : ", i);
      //    arr[i] = int.Parse(Console.ReadLine());
      //  }
      //  Console.WriteLine("\n\nElements stored in the Array are : \n");

      //  for (i = 0; i < arr.Length; i++)
      //  {
      //    Console.WriteLine("Element - {0} : {1} ",i, arr[i]);
      //  }

      //  max = arr[0];
      //  min = arr[0];

      //  for (i = 0; i < firstInput; i++)
      //  {
      //    if (arr[i] >max)
      //    {
      //      max = arr[i];
      //    }

      //    if (arr[i] < min)
      //    {
      //      min = arr[i];
      //    }
      //  }
      //  Console.WriteLine("\nMaximum element is : {0}",max);
      //  Console.WriteLine("\nMinimum element is : {0}", min);

      //  Console.ReadLine();

      #endregion
      #region Separate Odd an Even integers in Separate arrays #10
      //int firstInput, i, j=0, k=0, oddCount=0, evenCount=0;

      //Console.WriteLine("Input number of elements to store in the array :");
      //firstInput = int.Parse(Console.ReadLine());

      //Console.WriteLine("\nInput {0} elements into the array :\n", firstInput);

      //int[] arr = new int[firstInput];
      //int[] evenArr = new int[firstInput];
      //int[] oddArr = new int[firstInput];

      //for (i = 0; i < firstInput; i++)
      //{
      //  Console.Write("Element - {0} : ", i);
      //  arr[i] = int.Parse(Console.ReadLine());
      //}
      //Console.WriteLine("\n\nElements stored in the Array are : \n");

      //for (i = 0; i < arr.Length; i++)
      //{
      //  Console.WriteLine("Element - {0} : {1} ", i, arr[i]);
      //}

      //for (i = 0; i < firstInput; i++)
      //{
      //  if (arr[i]%2 == 0)
      //  {
      //    evenCount += 1;
      //    evenArr[j] = arr[i];
      //    j++;
      //  }
      //  else
      //  {
      //    oddCount += 1;
      //    oddArr[k] = arr[i];
      //    k++;
      //  }
      //}
      //int evenArrLength = firstInput - oddCount;
      //int oddArrLength = firstInput - evenCount;

      //Console.Write("\nThe Even elements are : \n");
      //for (i = 0; i < evenArrLength; i++)
      //{
      //  Console.Write("{0} ",evenArr[i]);
      //}

      //Console.Write("\nThe Odd elements are :\n");
      //for (i = 0; i < oddArrLength; i++)
      //{
      //  Console.Write("{0} ", oddArr[i]);
      //}


      //Console.ReadKey();
      #endregion 
    }
  }
}

