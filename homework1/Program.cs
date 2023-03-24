using System;

class Homework1
{
   static void Main(string[] args)
    {
        // 1) დაწერეთ პროგრამა რომელიც გამოთვლის კონსოლიდან შეყვანილი ორი რიცხვის ნამრავლს.
        Console.WriteLine(" please enter number x");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" please enter number y");
        int y = Convert.ToInt32(Console.ReadLine());

        int Mult = x * y;
        Console.WriteLine("The result is:" + Mult);
        

        // 2) დაწერეთ პროგრამა, რომელიც კონსოლზე გამოიტანს თქვენ სახელს, გვარს და ასაკს.
        Console.WriteLine("please enter your name");
        Console.ReadLine();

        Console.WriteLine("please enter your surname");
        Console.ReadLine();

        Console.WriteLine("please enter your age");
        int age = Convert.ToInt32(Console.ReadLine());
        
        // 3) დაწერეთ პროგრამა რომელიც გამოიტანს ნაშთს, კონსოლიდან გადაცემული ორი რიცხვის გაყოფის შედეგად.
        Console.WriteLine("please enter number one");
        int one = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" please enter number two");
        int two = Convert.ToInt32(Console.ReadLine());

        int div = one / two;
        Console.WriteLine("the result is" + div);
        
        // 4) შედარების ლოგიკური ოპერატორების საშუალებით შეადარეთ რიცხვები და დაწერეთ პროგრამა,რომელიც გამოიტანს true ან false;
        Console.WriteLine(" please enter number a");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("please enter number b");
        int b = Convert.ToInt32(Console.ReadLine());

        bool answer = a == b;
        Console.WriteLine(" the result is" + answer);
        Console.ReadLine();

        // 5) ჩაწერეთ შემდეგი პირობა Boolean ლოგიკური ოპერატორის გამოყენებით: A>B და A>C, A>B ან A>C. როცა A=5,B=4,C=7
        int A = 5;
        int B = 4;
        int C = 7;

        bool number = true;

        Console.WriteLine(A > B && A > C);
        Console.WriteLine(A > B || A > C);

        Console.ReadLine();

        // 6) შექმენით რიცხვითი ტიპის, 10 ელემენტისაგან შემდგარი მასივი. კონსოლზე გამოიტანეთ პირველი და მეშვიდე ელემენტი.

        int[] nums = new int[10] { 3, 5, 7, 77, 24, 2, 1, 33, 18, 19 };

        Console.WriteLine(nums[0] + "," + nums[6]);
        Console.ReadLine();






















    }




}