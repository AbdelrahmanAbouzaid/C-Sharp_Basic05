namespace Demo
{
    enum Season
    {
        Summer,
        Winter,
        Spring,
        Autumn
    }
    [Flags]
    enum Permissions
    {
        Read = 8,
        Write = 4,
        Delete = 2,
        Execute = 1
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Boxing & UnBoxing
            //Boxing : Converting (Casting) From DataType (Value Type) to DataType (Reference Type)
            //UnBoxing : Converting (Casting) From DataType (Reference Type) to DataType (Value Type)

            //Boxing
            //object obj;
            //obj can refere to instance from type 'object' 

            //obj = 1; //casting from int[value type] to object[Reference type]
            //implicit casting
            //safe casting
            //Parent => Child
            //Base => Drived

            //UnBoxing
            //object obj2 = 1;

            //int x = (int)obj2;
            //Wxplicit casting
            //unsafe casting
            //Child => Parent
            //Drived => Base

            #endregion

            #region Nullable Value Type
            //Nullable Value Type : Allow null as valid value
           // int? age = null;
            //age can store int values + null as a valid value

            //int? x = 30;
            //int y;

            //if (x != null)
            //{
            //    y = (int)x;
            //}
            //else
            //{
            //    y = 0;
            //}
            ////=========================
            //if (x is not null)
            //{
            //    y = (int)x;
            //}
            //else
            //{
            //    y = 0;
            //}
            ////=========================

            //if (x.HasValue)
            //{
            //    y = x.Value;
            //}else
            //{
            //    y = 0;
            //}
            ////=========================

            //y = x.HasValue ? y : 0;

            ////=========================


            ////Null Coalescing operator
            //y = x ?? 0;  //Syntax Sugar


            //=========================

            #endregion

            #region Nullable Reference Type
            //Nullable Reference Type (c# 10.0, dotnet 6.0)

            string message01 = "text"; //Required
            string? message02 = null; //Optional
            #endregion

            #region Null-Propagation Operator

            //int[] arr = default; //null

            //for (int i = 0; (arr is not null) && i < args.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //// Best Practice
            //if (arr is not null)
            //{
            //    for (int i = 0;  i < args.Length; i++)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //}


            //for (int i = 0; i < args?.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            #endregion

            #region Exception Handling
            //Exception handling
            //Exception: runtime error 

            //try { } catch (Exception e) { }

            //try { } catch (Exception e) { }finally { }

            //Exception
            // 1. SystemException
            //      1.1. FormatException
            //      1.2. IndexOutOfRangeException
            //      1.3. NullReferenceException
            //      1.4. ArithmaticException
            //          1.4.1. OverflowException
            //          1.4.2. DividedByZeroException
            // 2. ApplicationException


            //throw new Exception();
            #endregion

            #region Access Modifiers
            // Access Modifiers: C# Keywords Indicate Accessibility Scope
            // 1. Peivate
            // 2. private protected
            // 3. protected
            // 4. internal
            // 5. internal protected
            // 6. public


            // What can Write inside the namespase
            // 1. class
            // 2. struct
            // 3. interface
            // 4. enum

            // Access Modifiers inside the namespace
            // 1. internal  -> Default
            // 2. public


            // What can Write inside the class or struct
            // 1. Attributes [Field , Member Variable]
            // 1. Methods [Fuctions]
            // 1. Properties [Full Properties, Automatic Properties, Special Properties[indexer]]
            // 1. Events

            // Access Modifiers inside the class
            // 1. Peivate
            // 2. private protected
            // 3. protected
            // 4. internal
            // 5. internal protected
            // 6. public

            // Access Modifiers inside the struct
            // 1. Peivate
            // 2. internal
            // 3. public 
            #endregion

            #region Enum
            //Enum : Value Type 
            // STACK

            //Season season = Season.Summer;
            //Console.WriteLine(season);
            //Console.WriteLine((int)season); 


            //Permissions permissions = Permissions.Read;
            //permissions ^= Permissions.Write; // toggel 
            //Console.WriteLine(permissions);
            //permissions ^= Permissions.Write; 
            //Console.WriteLine(permissions);

            #endregion

        }
    }
}
