using ClassLibrary1;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTestProject1
{
    [TestClass]
    public class Testtest
    {
        //задание 1
        [TestMethod]
        public void GetSum_ReturnsCorrectSum_10_20_15_5_25_30()
        {
            double[,] matrix = { { 1, 0, 3, 0, 5 }, { 0, 2, 0, 4, 0 }, { 0, 0, 0, 0, 0 }, { 6, 7, 8, 9, 10 } };
            double[,] expected = { { 1, 500, 3, 500, 5 }, { 500, 2, 500, 4, 500 }, { 500, 500, 500, 500, 500 }, { 6, 7, 8, 9, 10 } };
            double[,] actual = Variant_0.Task1(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSum_ReturnsCorrectSum_16_18_20_22_24_26()
        {
            double[,] matrix = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 } };
            double[,] expected = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 } };
            double[,] actual = Variant_0.Task1(matrix);
            CollectionAssert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GetSum_ReturnsCorrectSum_2_16_6_18_10_12()
        {
            double[,] matrix = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 0, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 } };
            double[,] expected = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 500, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 } };
            double[,] actual = Variant_0.Task1(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }


        //2
        [TestMethod]
        public void Zadanie2()
        {
            double[,] matrix = { { 1, 2, 3, 4, -5 }, { 6, -7, 8, 9, 10 }, { 11, 12, -13, 14, 15 }, { -16, 17, 18, 19, 20 } };
            double[,] expected = { { 1, 2, 3, 4, -5 }, { 6, -7, 8, 9, 10 }, { 11, 12, -13, 14, 15 }, { -16, 17, 18, 19, 20 } };
            double[,] actual = Variant_0.Task2(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zadanie2_2()
        {
            double[,] matrix = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 } };
            double[,] expected = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 } };
            double[,] actual = Variant_0.Task2(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zadanie2_2_3()
        {
            double[,] matrix = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { -16, -17, -18, -19, -20 } };
            double[,] expected = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { -16, -17, -18, -19, -20 } };
            double[,] actual = Variant_0.Task2(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zadanie2_2_3_4()
        {
            double[,] matrix = { { -1, -2, -3, -4, -5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 } };
            double[,] expected = { { -1, -2, -3, -4, -5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 } };
            double[,] actual = Variant_0.Task2(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zadanie2_2_3_4_5()
        {
            double[,] matrix = { { -1, 2, 3, 4, 5 }, { -6, 7, 8, 9, 10 }, { -11, 12, 13, 14, 15 }, { -16, 17, 18, 19, 20 } };
            double[,] expected = { { -1, 2, 3, 4, 5 }, { -6, 7, 8, 9, 10 }, { -11, 12, 13, 14, 15 }, { -16, 17, 18, 19, 20 } };
            double[,] actual = Variant_0.Task2(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }



        //3
        [TestMethod]
        public void Task3Enter_1_Return()
        {
            double[,] P = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { -16, -17, -18, -19, -20 } };
            double[] exp = { 5, 5, 5, 0 };
            double[] act = Variant_0.Task3(P);
            CollectionAssert.AreEqual(exp, act);
        }
        [TestMethod]
        public void Task3Enter_1_2Return()
        {
            double[,] matrix = { { 1, 2, 3, 4, 5 }, { -6, -7, -8, -9, -10 }, { -11, -12, -13, -14, -15 }, { -16, -17, -18, -19, -20 } };
            double[] expected = { 5, 0, 0, 0 };
            double[] actual = Variant_0.Task3(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task3Enter_1_2_3Return()
        {
            double[,] matrix = { { -1, -2, -3, -4, -5 }, { -6, -7, -8, -9, -10 }, { -11, -12, -13, -14, -15 }, { -16, -17, -18, -19, -20 } };
            double[] expected = { 0, 0, 0, 0 };
            double[] actual = Variant_0.Task3(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task3Enter_1_2_3_4Return()
        {
            double[,] matrix = { { 1, -2, -3, -4, -5 }, { 6, -7, -8, -9, -10 }, { 11, -12, -13, -14, -15 }, { 16, -17, -18, -19, -20 } };
            double[] expected = { 1, 1, 1, 1 };
            double[] actual = Variant_0.Task3(matrix);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task3Enter_1_2_3_4_5Return()
        {
            double[,] matrix = { { -1, -2, -3, -4, -5 }, { -6, -7, -8, -9, -10 }, { -11, -12, -13, -14, -15 }, { 16, 17, 18, 19, 20 } };
            double[] expected = { 0, 0, 0, 5 };
            double[] actual = Variant_0.Task3(matrix);
            CollectionAssert.AreEqual(expected, actual);

        }


        //4
        [TestMethod]
        public void TestTask4_1()
        {
            double[,] P = {
        { 1, -2, 3, 4, -5 },
        { -6, 7, -8, 9, -10 },
        { 11, -12, 13, -14, 15 },
        { -16, 17, -18, 19, -20 }
    };
            double[] expected = { -2, -5, -6, -8, -10, -12, -14, -16, -18, -20 };
            double[] actual = Variant_0.Task4(P);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTask4_2()
        {
            double[,] P = {
        { -1, -2, -3, -4, -5 },
        { -6, -7, -8, -9, -10 },
        { -11, -12, -13, -14, -15 },
        { -16, -17, -18, -19, -20 }
    };
            double[] expected = { -1, -2, -3, -4, -5, -6, -7, -8, -9, -10 };
            double[] actual = Variant_0.Task4(P);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTask4_3()
        {
            double[,] P = {
        { 0, 0, 0, 0, 0 },
        { 0, 0, 0, 0, 0 },
        { 0, 0, 0, 0, 0 },
        { 0, 0, 0, 0, 0 }
    };
            double[] expected = new double[10];
            double[] actual = Variant_0.Task4(P);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTask4_4()
        {
            double[,] P = {
        { 1.5, -2.7, 3.1, 4.2, -5.3 },
        { -6.4, 7.5, -8.6, 9.7, -10.8 },
        { 11.9, -12.2, 13.4, -14.5, 15.6 },
        { -16.7, 17.8, -18.9, 19.1, -20.2 }
    };
            double[] expected = { -2.7, -5.3, -6.4, -8.6, -10.8, -12.2, -14.5, -16.7, -18.9, -20.2 };
            double[] actual = Variant_0.Task4(P);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTask4_5()
        {
            double[,] P = {
        { -1, 2, -3, 4, -5 },
        { 6, -7, 8, -9, 10 },
        { -11, 12, -13, 14, -15 },
        { 16, -17, 18, -19, 20 }
    };
            double[] expected = { -1, -3, -5, -7, -9, -11, -13, -15, -17, -19 };
            double[] actual = Variant_0.Task4(P);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}



