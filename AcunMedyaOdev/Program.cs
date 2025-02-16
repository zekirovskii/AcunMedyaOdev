using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("1: Sayının Pozitif, Negatif veya Sıfır Olduğunu Belirleme");
        CheckNumber();

        Console.WriteLine("\n2: Gün İsmi Belirleme");
        GetDayName();

        Console.WriteLine("\n3: Basit Hesap Makinesi");
        SimpleCalculator();

        Console.WriteLine("\n4: Üç Sayının En Büyüğünü Bulma");
        FindLargestNumber();

        Console.WriteLine("\n5: Şifre Güçlülüğünü Kontrol Etme");
        CheckPasswordStrength();
    }

    static void CheckNumber()
    {
        Console.WriteLine("Bir sayı giriniz: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
            Console.WriteLine("Pozitif");
        else if (num < 0)
            Console.WriteLine("Negatif");
        else
            Console.WriteLine("Sıfır");
    }

    static void GetDayName()
    {
        int day;

        while (true)
        {
            Console.Write("1-7 arasında bir sayı girin: ");
            if (int.TryParse(Console.ReadLine(), out day) && day >= 1 && day <= 7)
            {
                break;
            }
            Console.WriteLine("Geçersiz giriş! Lütfen 1 ile 7 arasında bir sayı girin.");

        }

        switch (day)
        {
            case 1: Console.WriteLine("Pazartesi"); break;
            case 2: Console.WriteLine("Salı"); break;
            case 3: Console.WriteLine("Çarşamba"); break;
            case 4: Console.WriteLine("Perşembe"); break;
            case 5: Console.WriteLine("Cuma"); break;
            case 6: Console.WriteLine("Cumartesi"); break;
            case 7: Console.WriteLine("Pazar"); break;
        }
    }

    static void SimpleCalculator()
    {
        Console.WriteLine("İlk sayıyı girin: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("İkinci sayıyı girin: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İşlemi girin (+, -, *, /): ");
        char operation = Convert.ToChar(Console.ReadLine());


        switch (operation)
        {
            case '+': Console.WriteLine($"Sonuç: {num1 + num2}"); break;
            case '-': Console.WriteLine($"Sonuç: {num1 - num2}"); break;
            case '*': Console.WriteLine($"Sonuç: {num1 * num2}"); break;
            case '/':
                if (num2 != 0)
                    Console.WriteLine($"Sonuç: {num1 / num2}");
                else
                    Console.WriteLine("Sıfıra bölme hatası!");
                break;
            default: Console.WriteLine("Geçersiz işlem!"); break;

        }
    }


    static void FindLargestNumber()
    {
        Console.Write("Birinci sayıyı girin: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Üçüncü sayıyı girin: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int largest;
        if (num1 > num2 && num1 > num3)
        {
            largest = num1;
        }
        else if (num2 > num1 && num2 > num3)
        {
            largest = num2;
        }
        else
        {
            largest = num3;
        }

        Console.WriteLine($"En büyük sayı: {largest}");
    }
    

    static void CheckPasswordStrength()
    {
        while (true)
        {
            Console.WriteLine("Şifrenizi giriniz: ");
            string password = Console.ReadLine();

            bool hasMinimumLength = password.Length >= 8;
            bool hasUpperCase = Regex.IsMatch(password, "[A-Z]");
            bool hasSpecialChar = Regex.IsMatch(password, "[^a-zA-Z0-9]"); // belirtilen karakterlerin dışındaki herhangi bir şeyi arar (özel karakter).

            if (hasMinimumLength && hasUpperCase && hasSpecialChar)
            {
                Console.WriteLine("Güçlü şifre!");
                break;
            }
            else
            {
                Console.WriteLine("Zayıf şifre! Şifre en az 8 karakter, bir büyük harf ve özel karakter(@,#,$,%, etc.) içermelidir. Tekrar deneyin.");
            }
        }
    }


}