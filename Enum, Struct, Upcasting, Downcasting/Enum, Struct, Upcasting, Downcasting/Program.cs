using Enum__Struct__Upcasting__Downcasting.Models;
using System;

namespace Enum__Struct__Upcasting__Downcasting
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
            //byte m = 5;
            //int n = m;

            //Eagle eagle1 = new Eagle();
            //Eagle eagle3 = new Eagle();
            //Shark shark1 = new Shark();
            //Animal shark2 = new Shark();

            //Animal eagle2 = eagle1;

            //Animal[] animals = { eagle1, eagle2, eagle3, shark1, shark2 };

            //foreach (var item in animals)
            //{
            //    item.Eat();
            //}
            #endregion
            
            #region Downcasting, Unboxing, Explicit
            //int m = 15;
            //byte n = (byte)m;
            //Console.WriteLine(n);

            //Shark shark1 = new Shark();
            //Animal shark2 = new Shark();

            //Shark shark3 = (Shark)shark2;

            //object[] objects = { 2, 5, "P130", shark2 };

            //foreach (var item in objects)
            //{
            //    Shark shark = item as Shark;

            //    if (shark != null)
            //    {
            //        Console.WriteLine(shark.Weight);
            //    }
            //    if (item is Shark)
            //    {
            //        ((Shark)item).Weight = 500;

            //        Console.WriteLine(((Shark)item).Weight);
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
        //        case (int)Roles.SuperAdmin:
        //            Console.WriteLine("Super admin");
        //            break;

        //        case (int)Roles.Admin:
        //            Console.WriteLine("Admin");
        //            break;

        //        case (int)Roles.Member:
        //            Console.WriteLine("Member");
        //            break;

        //        default:
        //            Console.WriteLine("Not founded role Id");
        //            break;
        //    }
        //}
        #endregion
    }

    #region Enum
    //enum Roles
    //{
    //    SuperAdmin,
    //    Admin,
    //    Member
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
