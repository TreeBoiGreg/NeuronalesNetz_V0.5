﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using NeuronalesNetz_V0._5.KI_Sachen;

namespace NeuronalesNetz_V0._5
{
  
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 2;
            Console.WriteLine(Convert.ToInt32(Math.Round(Convert.ToDouble(a) / Convert.ToDouble(b),MidpointRounding.AwayFromZero)));

            double[,] arr = new double[5, 5] { { 0, 1, 2, 3, 4 }, { 5, 6, 7, 8, 9 }, { 10, 11, 12, 13, 14 }, { 15, 16, 17, 18, 19 }, { 20, 21, 22, 23, 24 } };
            double[,] arr2 = CNN2D.GetPice(arr, 1, 1, 5,5);
            CNN2D.InsertValue(arr, 1, 1, 2, 2, 30);

            Console.ReadLine();
        }

        public static void ArrayAusgeben(double[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
                Console.Write("{ 0:F4}\t", arr[i]);

            Console.WriteLine("\n");
        }

        public static void ArrayAusgeben(Array arr)
        {
            foreach(object item in arr)
            {
                Console.Write(item + "\t");
            }
        }


        public static void Serialize(object t, string path)
        {
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                BinaryFormatter bformatter = new BinaryFormatter();
                bformatter.Serialize(stream, t);
            }
        }
        //Could explicitly return 2d array, 
        //or be casted from an object to be more dynamic
        public static object Deserialize(string path)
        {
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                BinaryFormatter bformatter = new BinaryFormatter();
                return bformatter.Deserialize(stream);
            }
        }


    }


}
