namespace ASSIGNMENT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //double d = 9.99;
            //int x = (int)d;
            //Console.WriteLine(x);
            ///// The result is 9: because EXPLICIT CAST was obtained from DOUBLE to INT

            #endregion

            #region Q2
            //int n = 5;
            //double d2 =(double) n / 2;
            //Console.WriteLine(d2);
            #endregion
            #region Q3
            //string? age = null;
            //Console.WriteLine("Enter your age:");
            //Console.ReadLine();
            //int ageAfter = Convert.ToInt32(age);
            //Console.WriteLine(ageAfter.GetType());
            #endregion
            #region Q4
            //string s = "12a";
            //int x = int.Parse(s);
            //Console.WriteLine(x);
            ////Convert String type into Int Type,and in case of conversion failure will throw exception
            #endregion
            #region Q5
            //try
            //{
            //    string s = "12a";
            //    int x = int.Parse(s);
            //    Console.WriteLine( x );
            //}
            //catch (FormatException)
            //{

            //    Console.WriteLine("Invalid Conversion");
            //}

            #endregion
            #region Q6
            //object o = 10;
            //int a = (int)o;
            //Console.WriteLine(a + 1);
            ////Will print 11=> Unboxing cast :convert from Obj to int
            #endregion
            #region Q7
            //object o = 10;
            //int a = (int)o;
            //long x = (long)a;
            //Console.WriteLine(x);
            //InvaildCastException:It's trying to convert OBJ of type int to type long; we need to  do unboxing first.
            #endregion
            #region Q8
            //try
            //{
            //    object o = 10;
            //    long x = (long)o;
            //    Console.WriteLine(x);

            //}
            //catch (InvalidCastException)
            //{

            //    Console.WriteLine(-1);
            //}
            #endregion
            #region Q9
            //string? name = null;
            //Console.WriteLine(name?.Length);
            ////won't print anything=>Null-condtional operator handles the null value (NullReferenceException)  
            #endregion
            #region Q10
            //string? name2 = null;
            //int length = name2?.Length ?? 0;
            //Console.WriteLine(length);
            //Null-coalescing operator Check if (name2?.Length) equal null,Returns the value on the left 0
            #endregion
            #region Q11
            //try
            //{
            //    string? s = Console.ReadLine();
            //    int x = int.Parse(s ?? "0");
            //    Console.WriteLine(x);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine(0);
            //}
            #endregion
            #region Q12
            //string? s = null;
            //Console.WriteLine(s?.Length);
            // TROW EXCEPTION =>(Null-forgiving operator):telling the compiler that the value is not NULL, and it is NULL
            #endregion
            #region Q13
            //string? s = null;
            //int x = Convert.ToInt32(s);
            //Console.WriteLine(x);
            //The conver() function converts from String to int, and if the value is null, it returns the default value (0).
            #endregion
        }
    }
}
