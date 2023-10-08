
#region Datatypes & Operators
//int a = 5;
//int b = 7;
//int c = 0;
//c = a + b;
#endregion
#region Try-Catch & Array & Object
//try
//{
//    int i = 0;
//    int[] Array = { 0, 1, 2, 3, 4, 5, 6 };
//}
//catch (Exception)
//{
//    Console.WriteLine("Unhandled Exception");
//}

//var Obj = new {Name="Sona",Surname="Abbasova",Age="20",GroupNo="P237"};

#endregion
#region Task 1
//Tələbə İmtahan Qiymətini Daxil Edir. Daxil Edilən İmtahan Qiyməti 0 və 100 Aralığında Olmalıdır.
//Əgər Qiymət 91 və 100 Aralığındadırsa A Çap Etsin.
//Əgər Qiymət 81 və 90 Aralığındadırsa B Çap Etsin.
//Əgər Qiymət 71 və 80 Aralığındadırsa C Çap Etsin.
//Əgər Qiymət 61 və 70 Aralığındadırsa D Çap Etsin.
//Əgər Qiymət 51 və 60 Aralığındadırsa E Çap Etsin.
//Əgər Qiymət 51 -dən Kiçikdirsə Kəsildiniz Çap Etsin.


//string point= Console.ReadLine();
//int Point =int .Parse(point);   

// if(Point >= 0 && Point <= 100)
//{
//    if (Point > 90 && Point <= 100)
//    {
//        Console.WriteLine("A");
//    }
//    else if (Point > 80 && Point <= 90)
//    {
//        Console.WriteLine("B");
//    }
//    else if (Point > 70 && Point <= 80)
//    {
//        Console.WriteLine("C");
//    }
//    else if (Point > 60 && Point <= 70)
//    {
//        Console.WriteLine("D");
//    }
//    else if (Point > 50 && Point <= 60)
//    {
//        Console.WriteLine("E");
//    }
//    else
//    {
//        Console.WriteLine("Kəsildiniz");
//    }

//}

#endregion
#region Task 2
//Ədədlərdən ibarət olan arraydə neçə müsbət neçə mənfi
//ədəd olduğunu ekrana çıxardan alqoritm yazın.


//int[] Nums = { -3, -7, 2, 12, 5 };
//int PositiveNumsCount = 0;
//int NegativeNumsCount = 0;
//for (int i = 0; i < Nums.Length; i++)
//{
//    if (Nums[i] < 0)
//    {
//        NegativeNumsCount++;
//    } else if (Nums[i] > 0)
//    {
//        PositiveNumsCount++;
//    }
//}
//    Console.WriteLine("Müsbet ededlerin sayı = "+PositiveNumsCount);
//    Console.WriteLine("Menfi ededlerin sayı = " +NegativeNumsCount);

#endregion
#region Task 3
//Ədədlərdən ibarət olan bir array verilib həmin arraydə olan 
//ən böyük ədədi ekrana yazdıran alqoritm yazın.


//int[] Nums = { 7, 5, 6, 14, 77, 83};
//int Element = 0;
//int i = 0;

//    while (Nums.Length > i)
//    {
//        int j = i + 1;
//        while (Nums.Length > j)
//        {
//            if (Nums[i] > Nums[j])
//            {
//                Element = Nums[i];
//                Nums[i] = Nums[j];
//                Nums[j] = Element;
//            }
//              else { j++; }
//        } { i++; }
//    }
//Console.WriteLine(Nums[Nums.Length-1]);

#endregion