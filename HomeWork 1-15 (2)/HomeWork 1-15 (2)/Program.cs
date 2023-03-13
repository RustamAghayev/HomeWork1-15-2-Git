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

/*
  verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati
 */
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

/*
 verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.
*/
#endregion
#region task 6
//l1:
//Console.WriteLine("8 reqemli ededi daxil edin:   ");
//string numain = Console.ReadLine();
//if (!int.TryParse(numain, out int mainnumber))
//{
//    goto l1;
//}
//int NumberLong = (int)Math.Log10(mainnumber) + 1;

//if (NumberLong != 8)
//{
//    goto l1;
//}
//int onenumber = mainnumber % 10000000;
//int threenumber = onenumber / 10;
//Console.WriteLine(threenumber);


/*
 verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et
*/

#endregion
#region task 7
//int mainnumber;
//int residue;
//int newresult = 0;
//l1:
//Console.WriteLine("4 reqemli ededi daxil edin:   ");
//string numain = Console.ReadLine();
//if (!int.TryParse(numain, out mainnumber))
//{
//    goto l1;
//}
//int NumberLong = (int)Math.Log10(mainnumber) + 1;

//if (NumberLong != 4)
//{
//    goto l1;
//}
//while (mainnumber > 0)
//{
//    residue = mainnumber % 10;
//    newresult = newresult * 10 + residue;

//    mainnumber /= 10;
//}

//int number = newresult + 80000;
//int finishnumber = number * 10 + 8;
//Console.WriteLine(finishnumber);

/*
 verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir
*/
#endregion
#region task 8
//int mainnumber;
//l1:
//Console.Write("6 reqemli ededi daxil edin: ");
//string numain = Console.ReadLine();
//if (!int.TryParse(numain, out mainnumber))
//{
//    goto l1;
//}
//int NumberLong = (int)Math.Log10(mainnumber) + 1;

//if (NumberLong != 6)
//{
//    goto l1;
//}


//int residue = mainnumber % 1000;
//int result = residue / 100;

//int resultwo = mainnumber % 10;

//int resultfinish = result + resultwo;
//Console.WriteLine(resultfinish);

/*
 Verilmis ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap  
 */

#endregion
#region task 9
//int mainnumber;
//int residue;

//l1:
//Console.WriteLine("ededi daxil edin:   ");
////string numain = Console.ReadLine();
//if (!int.TryParse(Console.ReadLine(), out mainnumber))
//{
//    goto l1;
//}
//int newresult = 0;


//while (mainnumber > 0)
//{
//    residue = mainnumber % 10;
//    mainnumber /= 10;
//    newresult = newresult * 10 + residue;

//}

//mainnumber = newresult;
//newresult = 0;

//bool going = true;

//while (mainnumber > 0)
//{
//    residue = mainnumber % 10;
//    mainnumber /= 10;


//    if (going == true)
//    {
//        going = !going;
//        continue;
//    }

//    going = !going;
//    newresult = newresult * 10 + residue;

//}

//Console.WriteLine(newresult);


/*
   9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389=12439
 */
#endregion
#region task 10
//int mainnumber;
//int residue;

//l1:
//Console.WriteLine("ededi daxil edin:   ");
////string numain = Console.ReadLine();
//if (!int.TryParse(Console.ReadLine(), out mainnumber))
//{
//    goto l1;
//}
//int newresult = 0;


//while (mainnumber > 0)
//{
//    residue = mainnumber % 10;
//    mainnumber /= 10;
//    newresult = newresult * 10 + residue;

//}

//mainnumber = newresult;
//int mainnumber2 = newresult;
//newresult = 0;
//int newresult2 = 0;

//bool going = true;

//while (mainnumber > 0)
//{
//    residue = mainnumber % 10;
//    mainnumber /= 10;


//    if (going == true)
//    {
//        going = !going;
//        continue;
//    }

//    going = !going;
//    newresult = newresult * 10 + residue;

//}
//while (mainnumber2 > 0)
//{
//    residue = mainnumber2 % 10;
//    mainnumber2 /= 10;


//    if (going == false)
//    {
//        going = !going;
//        continue;
//    }

//    going = !going;
//    newresult2 = newresult2 * 10 + residue;

//}
//int resultmain = newresult + newresult2;
//Console.WriteLine(resultmain);

/*
  9 reqemli ededdi tek yerde dayananlardan bir eded duzlet,
    sonra cut yerde dayanlarinda bir eded duzlet,
    sonra onlari topla
 */


#endregion
#region task 11
//int mainnumber;

//int remainderOne;
//int remainderTwo;
//int remainderThree;

//l1:
//Console.WriteLine("8 reqemli ededi daxil edin:   ");

//if (!int.TryParse(Console.ReadLine(), out mainnumber))
//{
//    goto l1;
//}
//int NumberLong = (int)Math.Log10(mainnumber) + 1;

//if (NumberLong != 8)
//{
//    Console.WriteLine("duzgun ededi daxil etmediniz");
//    goto l1;
//}

//int sumOne = mainnumber % 100;
//remainderOne = mainnumber / 100;
//int sumTwo = remainderOne % 100;
//remainderTwo = remainderOne / 100;
//int sumThree = remainderTwo % 100;
//remainderThree = remainderTwo / 100;
//int sumFour = remainderThree % 100;

//Console.WriteLine(sumOne);
//Console.WriteLine(sumTwo);
//Console.WriteLine(sumThree);
//Console.WriteLine(sumFour);

//int num = sumOne + sumTwo + sumThree + sumFour;
//Console.WriteLine(num);
//int result = num * 100 + 99;
//int mainresult = result * 18 / 100;
//Console.WriteLine(mainresult);

//int bezdimresult = result - mainresult;

//Console.WriteLine(bezdimresult);
//==========================================================
/*
 8 reqemli ededin reqemlerini iki -iki qruplashdir.
    Qruplarin cemini tap. Alinan cavabin axirina 99 artir.
    Sonra cavabin ozunden onun 18% ni cix;
 */
//==========================================================
#endregion
#region task 11 (v2)
//int mainnumber;

//int remainder;

//l1:
//Console.WriteLine("8 reqemli ededi daxil edin:   ");
////string numain = Console.ReadLine();
//if (!int.TryParse(Console.ReadLine(), out mainnumber))
//{
//    goto l1;
//}
//int NumberLong = (int)Math.Log10(mainnumber) + 1;

//if (NumberLong != 8)
//{
//    Console.WriteLine("duzgun ededi daxil etmediniz");
//    goto l1;
//}

//int sum = 0;
//while (mainnumber > 0)
//{
//    remainder = mainnumber % 100;
//    mainnumber /= 100;
//    sum += remainder;
//}
//int result = sum * 100 + 99;

//int residue = result * 18 / 100;

//int mainresult = result - residue;

//Console.WriteLine(mainresult);

//==========================================================
/*
 8 reqemli ededin reqemlerini iki -iki qruplashdir.
    Qruplarin cemini tap. Alinan cavabin axirina 99 artir.
    Sonra cavabin ozunden onun 18% ni cix;
 */

#endregion
#region task 12
//l1:
//Console.WriteLine("5 reqemli 1ci ededi daxil edin:   ");
//string numain1 = Console.ReadLine();
//if (!int.TryParse(numain1, out int num1))
//{
//    goto l1;
//}
//int NumberLong1 = (int)Math.Log10(num1) + 1;
//int lastOne = num1 % 10;
//if (NumberLong1 != 5)
//{
//    goto l1;
//}
//l2:
//Console.WriteLine("5 reqemli 2ci ededi daxil edin:   ");
//string numain2 = Console.ReadLine();
//if (!int.TryParse(numain2, out int num2))
//{
//    goto l2;
//}
//int NumberLong2 = (int)Math.Log10(num2) + 1;

//if (NumberLong2 != 5)
//{
//    goto l2;
//}
////=================================================================
//int remainder1;
//int sum1 = 0;
//while (num1 > 0)
//{
//    remainder1 = num1 % 10;
//    num1 /= 10;
//    sum1 += remainder1;
//}
////=================================================================
//int remainder2;
//int sum2 = 1;

//while (num2 > 0)
//{
//    remainder2 = num2 % 10;
//    num2 /= 10;
//    sum2 *= remainder2;
//}
//Console.WriteLine(sum1);
//Console.WriteLine(sum2);

//int result = sum1 + sum2;
//int result1 = result * 10;
//int resultmain = result1 + lastOne;

//Console.WriteLine(resultmain);
/*
 2 dene 5 reqemli eded daxil et.
    I ededin reqemleri ceminin usutne II ededin reqemleri hasilini gel.
    Neticenin axirina I ededin en axiinci reqemini artir.
 */
#endregion
#region task 13
//l1:
//Console.WriteLine("5 reqemli eded daxil edin:  ");
//string eded1 = Console.ReadLine();

//if (!int.TryParse(eded1, out int num1))
//{
//    goto l1;
//}
//int numLong1 = (int)Math.Log10(num1) + 1;

//if (numLong1 != 5)
//{
//    goto l1;
//}

//l2:
//Console.WriteLine("5 reqemli diger eded daxil edin:  ");
//string eded2 = Console.ReadLine();

//if (!int.TryParse(eded2, out int num2))
//{
//    goto l2;
//}
//int numLong2 = (int)Math.Log10(num2) + 1;

//if (numLong2 != 5)
//{

//    goto l2;
//}

//l3:
//Console.WriteLine("5 reqemli diger diger eded daxil edin:  ");
//string eded3 = Console.ReadLine();

//if (!int.TryParse(eded3, out int num3))
//{
//    goto l3;
//}
//int numLong3 = (int)Math.Log10(num3) + 1;

//if (numLong3 != 5)
//{

//    goto l3;
//}
//int result1 = num1 / 10000;
//int result2 = num1 % 10;
//int result1final = result1 * 10 + result2;
//Console.WriteLine(result1final);

//int resultand1 = num2 / 10000;
//int resultand2 = num2 % 10;
//int result2final = resultand1 * 10 + resultand2;
//Console.WriteLine(result2final);

//int resultor1 = num3 / 10000;
//int resultor2 = num3 % 10;
//int result3final = resultor1 * 10 + resultor2;
//Console.WriteLine(result3final);

//int resultMain1 = result1final + result2final + result3final;
//Console.WriteLine(resultMain1);

//int remainder = resultMain1 / 2;

//int mainresult = resultMain1 + remainder;
//Console.WriteLine(mainresult);

/*
 3 dene 5 reqemli eded var.
    Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet. Alinan neticeleri topla
    Yekunda alian cavabin 50%-ni hemin ededin uzerine gel.
 */
#endregion
#region task 14
//l1:
//Console.WriteLine("6 reqemli 1ci ededi daxil edin:  ");
//string eded1 = Console.ReadLine();

//if (!int.TryParse(eded1, out int num1))
//{
//    goto l1;
//}
//int numLong1 = (int)Math.Log10(num1) + 1;

//if (numLong1 != 6)
//{
//    goto l1;
//}

//l2:
//Console.WriteLine("6 reqemli 2 ci eded daxil edin:  ");
//string eded2 = Console.ReadLine();

//if (!int.TryParse(eded2, out int num2))
//{
//    goto l2;
//}
//int numLong2 = (int)Math.Log10(num2) + 1;

//if (numLong2 != 6)
//{

//    goto l2;
//}

//l3:
//Console.WriteLine("6 reqemli 3 cu eded daxil edin:  ");
//string eded3 = Console.ReadLine();

//if (!int.TryParse(eded3, out int num3))
//{
//    goto l3;
//}
//int numLong3 = (int)Math.Log10(num3) + 1;

//if (numLong3 != 6)
//{

//    goto l3;
//}

//l4:
//Console.WriteLine("7 reqemli diger diger eded daxil edin:  ");
//string eded4 = Console.ReadLine();

//if (!int.TryParse(eded4, out int num4))
//{
//    goto l4;
//}
//int numLong4 = (int)Math.Log10(num4) + 1;

//if (numLong4 != 7)
//{

//    goto l4;
//}
//int sum1 = num1 / 1000;
//Console.WriteLine(sum1);
//int sum2 = num2 / 1000;
//Console.WriteLine(sum2);
//int sum3 = num3 / 1000;
//Console.WriteLine(sum3);

//int result1 = sum1+sum2+sum3;
//int sum4 = num4 % 10000;

//Console.WriteLine(sum4);
//int remainder1 = num4 / 10000;
//int remainder2 = remainder1 % 10;
//int qaliq = remainder1 / 10;
//int remainder3 = qaliq % 10;
//int remainder4 = remainder1 / 100;
//int mainresult = remainder4 * remainder3 * remainder2;
//Console.WriteLine(remainder4);
//Console.WriteLine(mainresult);

//int result2 = result1 + sum4;
//Console.WriteLine(result2);

//int result10 = result2 - mainresult;
//Console.WriteLine(result10);
//int result11 = result10 * 60 / 100;
//Console.WriteLine(result11);
//int result12 = result11 * 100 + 60;
//Console.WriteLine(result12);
//int result13 = result12 * 18 / 100;
//Console.WriteLine(result13);
//Console.WriteLine(result2);
//int result20 = result2 - result13;
//Console.WriteLine(result20);


/*
 4 dene eded daxil et. Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
    6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
    Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel
    Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
    Neticenin 60 % tap. Cavabin axirina 60 artir.
    Neticeden 18% cix.
 */
#endregion
#region Task 15
//    Console.Write(" ededi daxil et: ");

//    if (!int.TryParse(Console.ReadLine(), out int fifthvalue))
//    {
//        Console.Write("ededi duzgun daxil edilmemisdir ");
//        goto l5;
//    }
//    if (((int)Math.Log10(fifthvalue) + 1) != 7)
//    {
//        Console.Write("ededi duzgun daxil edilmemisdir ");
//        goto l5;
//    }
//    int stepFirst = value + scndValue;
//    int stepTwo = (int)Math.Pow(stepFirst % 100, 2);
//    int stepThree = stepTwo + (value * 1000 + scndValue);
//    int stepFour = stepThree - fifthvalue % 100000;
//    int stepFive = (thirdvalue + valueFour) % 1000;
//    int stepSix = stepFour + stepFive;
//    int sum = 0;
//    int newnumber = fifthvalue;
//    while (fifthvalue > 0)
//    {
//        int remainder = fifthvalue % 10;
//        fifthvalue /= 10;
//        sum += remainder;

//    }
//    int sum2 = 0;
//    while (sum > 0)
//    {
//        int remainder = sum % 10;
//        sum /= 10;
//        sum2 = sum2 * 10 + remainder;
//    }
//    int stepSeven = stepSix + sum2;
//    int step = stepSeven * 100 + 11;
//    int sum3 = 0;
//    while (newnumber > 0)
//    {
//        int remainder = newnumber % 10;
//        newnumber /= 100;
//        sum3 = sum3 * 10 + remainder;

//    }
//    int sum4 = 0;
//    while (sum3 > 0)
//    {
//        int remainder = sum3 % 10;
//        sum3 /= 10;
//        sum4 = sum4 * 10 + remainder;
//    }
//    long lastStep = step - sum4;
//    long persent = (long)lastStep % 10;
//    long result = 1000 * (lastStep / 10) + 880 + persent;

//    Console.WriteLine(lastStep);
//    Console.WriteLine(result);
#endregion