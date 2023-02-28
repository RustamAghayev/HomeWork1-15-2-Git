#region task 1
//int result = 0;
//l1:
//Console.WriteLine("4 reqemli ededi daxil edin:   ");
//string numain = Console.ReadLine();
//if (!int.TryParse(numain, out int num1))
//{

//    goto l1;

//}
//int numLong1 = (int)Math.Log10(num1) + 1;
//if (numLong1 != 4)
//{
//    goto l1;
//}
//while (num1 > 0)
//{
//    result += num1 % 10;
//    num1 = num1 / 10;
//}
//Console.WriteLine(result);

// verilmish 4 reqemli ededin reqemlerinin cemini tap
#endregion
#region task 2
//int result = 0;
//l1:
//Console.WriteLine("6 reqemli ededi daxil edin:   ");
//string numain = Console.ReadLine();
//if (!int.TryParse(numain, out int num1))
//{
//    goto l1;
//}
//int NumberLong = (int)Math.Log10(num1) + 1;

//int onenumber = num1 / 1000;

//if (NumberLong != 6)
//{
//    goto l1;
//}
//while (onenumber > 0)
//{
//    result += onenumber % 10;
//    onenumber = onenumber / 10;
//}
//Console.WriteLine(result);

//verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: example: 123600 = 1 + 2 + 3

#endregion
#region task 3
//int result = 0;
//l1:
//Console.WriteLine("9 reqemli ededi daxil edin:   ");
//string numain = Console.ReadLine();
//if (!int.TryParse(numain, out int num1))
//{
//    goto l1;
//}
//int NumberLong = (int)Math.Log10(num1) + 1;

//int onenumber = num1 % 1000000; //  or / 1000 netice eynidir
//int twonumber = onenumber / 1000;

//if (NumberLong != 9)
//{
//    goto l1;
//}
//while (twonumber > 0)
//{
//    result += twonumber % 10;
//    twonumber = twonumber / 10;
//}
//Console.WriteLine(result);


// verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi


#endregion
#region task 4
//l1:
//Console.WriteLine("5 reqemli ededi daxil edin:   ");
//string numain = Console.ReadLine();
//if (!int.TryParse(numain, out int num1))
//{
//    goto l1;
//}
//int NumberLong = (int)Math.Log10(num1) + 1;
//if (NumberLong != 5)
//{
//    goto l1;
//}

//int onenumber = num1 / 10000;
//int twonumber = num1 % 10;
//int threenumber = onenumber + twonumber;
//int fournumber = (int)Math.Pow(threenumber, 2);

//Console.WriteLine(fournumber);
#endregion
#region task 5
//l1:
//Console.WriteLine("6 reqemli ededi daxil edin:   ");
//string numain = Console.ReadLine();
//if (!int.TryParse(numain, out int num1))
//{
//    goto l1;
//}
//int NumberLong = (int)Math.Log10(num1) + 1;

//if (NumberLong != 6)
//{
//    goto l1;
//}
//int onenumber = num1 / 100000;
//int threenumber = num1 * 10;
//int fournumber = threenumber + onenumber;
//Console.WriteLine(fournumber);
#endregion