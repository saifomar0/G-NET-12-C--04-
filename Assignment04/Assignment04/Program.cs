using System;
using System.Diagnostics;
using System.Text;
using static System.Formats.Asn1.AsnWriter;

namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01

            //string productlist = "";
            //for (int i = 0; i < 5000; i++)
            //{
            //    productlist += "PROD-" + i + ",";
            //}
            //Console.WriteLine(productlist);




            //a) every time i use += A new string object is created in memory


            #region B

            //b)


            //StringBuilder productListt = new StringBuilder();
            //for (int i = 0; i < 5000; i++)
            //{
            //    productListt.Append("PROD-");
            //    productListt.Append(i);
            //    productListt.Append(",");
            //}

            //string result = productListt.ToString();
            //Console.WriteLine(result);

            #endregion



            #region C

            //c)



            //var sw1 = Stopwatch.StartNew();

            //string productlist = "";
            //for (int i = 0; i < 5000; i++)
            //{
            //    productlist += "PROD-" + i + ",";
            //}

            //sw1.Stop();
            //Console.WriteLine("String Time: " + sw1.ElapsedMilliseconds + " ms");



            //var sw2 = Stopwatch.StartNew();

            //StringBuilder productList = new StringBuilder();
            //for (int i = 0; i < 5000; i++)
            //{
            //    productList.Append("PROD-");
            //    productList.Append(i);
            //    productList.Append(",");
            //}

            //string result = productList.ToString();

            //sw2.Stop();
            //Console.WriteLine("StringBuilder Time: " + sw2.ElapsedMilliseconds + " ms");

            //string builder is faster 




            #endregion



            #endregion


            #region Q02


            //Console.Write("Enter the age: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.Write("Enter the Day of week: ");
            //int dayofweek = int.Parse(Console.ReadLine());
            //Console.Write("Are you student?(Y/N): ");
            //string studentInput = Console.ReadLine().ToLower();

            //  bool hasStudentID = studentInput == "y";

            //bool weekEnd = (dayofweek == 6 || dayofweek == 7);
            //string message = "";



            //double price=0;

            //if (age < 5)
            //{
            //    price = 0;
            //    message = "Age Under 5  Free ";
            //}
            //else if (age >= 5 && age < 13)
            //{
            //    price = weekEnd ? 40 : 30;
            //    message = "Age (5-12) " + price;
            //}
            //else if(age >= 13 && age <= 59)
            //{
            //    price = weekEnd ? 60 : 50;
            //    message = "Age (13-59) " + price;
            //}
            //else if (age >= 60)
            //{
            //    price = weekEnd ? 35 : 25;
            //    message = "Age (60+) " + price;

            //}


            //if(hasStudentID&&price>0)
            //{
            //    double discount = price * 0.20;
            //    price -= discount;
            //    message += "\nStudent discount (20%) = -" + discount;
            //}






            //Console.WriteLine(message);
            //Console.WriteLine("Final Price = " + price + " LE");

            #endregion



            #region Q03

            #region Traditional Switch

            //string fileExtension = "pdf";
            //string fileType;

            //switch (fileExtension)
            //{
            //    case "pdf":
            //        fileType = "PDF Document";
            //        break;

            //    case "doc":
            //    case "docx":
            //        fileType = "Word Document";
            //        break;

            //    case "xls":
            //    case "xlsx":
            //        fileType = "Excel Spreadsheet";
            //        break;

            //    case "jpg":
            //    case "png":
            //    case "gif":
            //        fileType = "Image File";
            //        break;

            //    default:
            //        fileType = "Unknown File Type";
            //        break;
            //}

            //Console.WriteLine(fileType);


            #endregion

            #region modern switch
            //string fileExtension = "pdf";

            //string fileType = fileExtension switch
            //{
            //    "pdf" => "PDF Document",

            //    "doc" or "docx" => "Word Document",

            //    "xls" or "xlsx" => "Excel Spreadsheet",

            //    "jpg" or "png" or "gif" => "Image File",

            //    _ => "Unknown File Type"
            //};

            //Console.WriteLine(fileType);

            #endregion

            #endregion


            #region Q04
            //int temperature = 35;

            //string weatherAdvice =
            //    temperature < 0 ? "Freezing! Stay indoors." :
            //    temperature < 15 ? "Cold. Wear a jacket." :
            //    temperature < 25 ? "Pleasant weather." :
            //    temperature < 35 ? "Warm. Stay hydrated." :
            //    "Hot. Avoid sun exposure.";

            //Console.WriteLine(weatherAdvice);
            //Become hard to read- Harder to debug




            #endregion


            #region Q05



            //int attempts = 0;
            //bool isValid = false;

            //do
            //{
            //    Console.Write("Enter your password: ");
            //    string password = Console.ReadLine();

            //    attempts++;

            //    bool hasUpper = false;
            //    bool hasDigit = false;
            //    bool hasSpace = false;


            //    foreach (char c in password)
            //    {
            //        if (char.IsUpper(c))
            //            hasUpper = true;

            //        if (char.IsDigit(c))
            //            hasDigit = true;

            //        if (char.IsWhiteSpace(c))
            //            hasSpace = true;
            //    }


            //    if (password.Length < 8)
            //        Console.WriteLine(" Must be at least 8 characters.");

            //    if (!hasUpper)
            //        Console.WriteLine(" Must contain at least one uppercase letter.");

            //    if (!hasDigit)
            //        Console.WriteLine(" Must contain at least one digit.");

            //    if (hasSpace)
            //        Console.WriteLine(" Must NOT contain spaces.");


            //    if (password.Length >= 8 && hasUpper && hasDigit && !hasSpace)
            //    {
            //        isValid = true;
            //        Console.WriteLine(" Password accepted!");
            //    }
            //    else
            //    {
            //        if (attempts < 5)
            //            Console.WriteLine("Try again.\n");
            //    }

            //} while (!isValid && attempts < 5);

            //if (!isValid)
            //{
            //    Console.WriteLine(" Account locked.");
            //}


            #endregion

            #region 06
            int[] scores = [85, 42, 91, 67, 55, 78, 39, 88, 72, 95, 60, 48];

            #region A)
            //Console.WriteLine("scores below 50:");

            //foreach (int score in scores)
            //    if (score > 50)
            //    {
            //        Console.WriteLine(score);
            //    }
            #endregion

            #region B)
            //Console.WriteLine("First score above 90:");

            //foreach (int score in scores)
            //{
            //    if (score > 90)
            //    {
            //        Console.WriteLine(score);
            //        break;
            //    }
            //}
            #endregion

            #region C)
            //int sum = 0;
            //int count = 0;

            //foreach (int score in scores)
            //{
            //    if (score >= 40)
            //    {
            //        sum += score;
            //        count++;
            //    }
            //}

            //double average = (double)sum / count;

            //Console.WriteLine("Class Average (excluding <40): " + average);


            #endregion


            #region D)
            //int countA = 0, countB = 0, countC = 0,
            //    countD = 0, countF = 0;

            //foreach (int score in scores)
            //{
            //    if (score >= 90 && score <= 100)
            //        countA++;
            //    else if (score >= 80)
            //        countB++;
            //    else if (score >= 70)
            //        countC++;
            //    else if (score >= 60)
            //        countD++;
            //    else
            //        countF++;
            //}

            //Console.WriteLine("\nGrade Distribution:");
            //Console.WriteLine("A: " + countA);
            //Console.WriteLine("B: " + countB);
            //Console.WriteLine("C: " + countC);
            //Console.WriteLine("D: " + countD);
            //Console.WriteLine("F: " + countF);

            #endregion




            #endregion


        }
    }
}
