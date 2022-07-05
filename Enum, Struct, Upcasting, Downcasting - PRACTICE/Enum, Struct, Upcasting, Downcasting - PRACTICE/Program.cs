using Enum__Struct__Upcasting__Downcasting___PRACTICE.Models;
using System;

namespace Enum__Struct__Upcasting__Downcasting___PRACTICE
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Params
            //GetElements(1, 2, 3, 4, 5);
            #endregion

            #region Enum
            //CheckRole(0);
            #endregion

            #region Nullable
            //Test test = new Test();
            //Console.WriteLine(test.Number);

            //string name = null;
            //int? age = null;

            //var result = age == null ? 55 : 60;

            //var result = age ?? 60;

            //Console.WriteLine(result);

            //Test test = null;
            //Console.WriteLine(test.Word.Tostring());
            #endregion

            #region Struct
            //Test1 test = new Test1("Emil");
            //Console.WriteLine(test.Num);

            //Test2 test2 = new Test2();
            #endregion

            #region Upcasting, Boxing, Implicit
            //Camry camry1 = new Camry();
            //Camry camry3 = new Camry();
            //Sonata sonata1 = new Sonata();
            //Car sonata2 = new Sonata();

            //Car camry2 = camry1;

            //Car[] cars = { camry1, camry2, camry3, sonata1, sonata2 };

            //foreach (var item in cars)
            //{
            //    item.Speed();
            //}
            #endregion

            #region Downcasting, Unboxing, Explicit
            //Sonata sonata1 = new Sonata();
            //Car sonata2 = new Sonata();

            //Sonata sonata3 = (Sonata)sonata2;

            //object[] objects = { 2, 5, "P130", sonata2 };

            //foreach (var item in objects)
            //{
            //    Sonata sonata = item as Sonata;

            //    if (sonata != null)
            //    {
            //        Console.WriteLine(sonata.HorsePower);
            //    }
            //    if (item is Sonata)
            //    {
            //        ((Sonata)item).HorsePower = 290;

            //        Console.WriteLine(((Sonata)item).HorsePower);
            //    }
            //}
            #endregion
        }

        #region Params
        //public static void GetElements(params int[] nums)
        //{
        //    foreach (var item in nums)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        #endregion

        #region Enum
        //static void CheckRole(int roleId)
        //{
        //    switch (roleId)
        //    {
        //        case (int)Roles.Mudur:
        //            Console.WriteLine("Mudur");
        //            break;

        //        case (int)Roles.Muavin:
        //            Console.WriteLine("Muavin");
        //            break;

        //        case (int)Roles.Ishci:
        //            Console.WriteLine("Ishci");
        //            break;

        //        default:
        //            Console.WriteLine("Role Id tapilmadi");
        //            break;
        //    }
        //}
        #endregion
    }

    #region Enum
    //enum Roles
    //{
    //    Mudur,
    //    Muavin,
    //    Ishci
    //}
    #endregion

    #region Nullable
    //class Test
    //{
    //    public int? Number { get; set; }
    //    public string Word { get; set; }
    //}
    #endregion

    #region Struct
    //struct Test1
    //{
    //    public int Num { get; set; }

    //    public Test1(string name)
    //    {
    //        Num = 66;
    //        Console.WriteLine(Num);
    //    }
    //}

    //class Test2
    //{
    //    public int MyProperty { get; set; } = 66;

    //    public Test2()
    //    {
    //        Console.WriteLine("Bosh");
    //    }
    //    public Test2(int b)
    //    {
    //        Console.WriteLine("Dolu");
    //    }
    //}
    #endregion
}
