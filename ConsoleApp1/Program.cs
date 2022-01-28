using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           //1. Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax + b = 0, unde a si b sunt date de intrare. 
            Console.WriteLine("{Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax + b = 0, unde a si b sunt date de intrare : }");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                if (b > 0)
                    Console.WriteLine("-" + b + "/" + a);
                else Console.WriteLine(b + "/" + a);
            }
            else
            {
                int x = -b / a;
                Console.WriteLine("{0}", x);
            }

            //2.Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. 
            Console.WriteLine("Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. ");

            int c = int.Parse(Console.ReadLine());
            double delta = b ^ 2 - (4 * a * c);
            if (delta > 0)
            {
                double x1 = -(b - Math.Sqrt(delta)) / a;
                double x2 = -(b + Math.Sqrt(delta)) / a;
                Console.WriteLine(x1 + ",  " + x2);
            }
            else
            {

                if (delta == 0)
                {
                    int x3 = -b / a;
                    Console.WriteLine("{0}", x3);

                }
            }

            //3.Determinati daca n se divide cu k, unde n si k sunt date de intrare. 
            Console.WriteLine("Determinati daca n se divide cu k, unde n si k sunt date de intrare. ");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if (n % k == 0) Console.WriteLine("true");
            else Console.WriteLine("fals");

            //4.Detreminati daca un an y este an bisect. 
            Console.WriteLine("4.Detreminati daca un an y este an bisect. ");
            int y = int.Parse(Console.ReadLine());
            if (y % 4 == 0 && y % 100 != 0 || y % 400 == 0)
            {
                Console.WriteLine("an bisect");
            }
            else Console.WriteLine("an obisnuit");


            //5.Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 
            Console.WriteLine("5.Extrageti si afisati a k - a cifra de la sfarsitul unui numar.Cifrele se numara de la dreapta la stanga.");

            int nrk = int.Parse(Console.ReadLine());
            int k1 = int.Parse(Console.ReadLine());
            int kontor = 0;
            int aux = 0;
            if (k1 != 0)
            {
                while (kontor != k1)
                {
                    aux = nrk % 10;
                    kontor++;
                    nrk /= 10;

                }
                Console.WriteLine(aux);

            }

            //6.Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
            Console.WriteLine("6.Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.");
            int a1 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int c1 = int.Parse(Console.ReadLine());
            if (a1 <= 0 || b1 <= 0 || c1 <= 0 || a1 >= b1 + c1 || b1 >= a1 + c1 || c1 >= a1 + b1)
                Console.WriteLine("Nu este triunghi");
            else if (a1 * a1 + b1 * b1 == c1 * c1 || b1 * b1 + c1 * c1 == a1 * a1 || c1 * c1 + a1 * a1 == b1 * b1)
                Console.WriteLine("triunghi dreptunghic");
            else if (a1 * a1 + b1 * b1 > c1 * c1 && b1 * b1 + c1 * c1 > a1 * a1 && c1 * c1 + a1 * a1 > b1 * b1)
                Console.WriteLine("triunghi ascutitunghic");
            else
                Console.WriteLine("triunghi obtuzunghic");

            //7. Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor.
            Console.WriteLine("Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor.");
            int aux2 = 0;
            int a3 = int.Parse(Console.ReadLine());
            int b3 = int.Parse(Console.ReadLine());
            aux2 = a3;
            a3 = b3;
            b3 = aux2;
            Console.WriteLine("{0},{1}", a3, b3);
            //8.Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  
            Console.WriteLine("Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.");
            int a2 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            int t = 10;
            bool ok = true;
            if (b2 < 10)
            {
                a2 = a2 * 10 + b2;
                b2 = a2 / 10;
                a2 %= 10;
                Console.WriteLine("{0},{1}", a2, b2);
            }
            else
            {
                while (ok == true)
                {
                    if (t <= b2 && b2 < t * 10)
                    {
                        a2 = a2 * t * 10 + b2;
                        b2 = a2 / (t * 10);
                        a2 %= (t * 10);
                        Console.WriteLine("{0},{1}", a2, b2);
                        ok = false;
                    }
                    else t *= 10;
                }
            }

            //9.Afisati toti divizorii numarului n. 
            Console.WriteLine("Afisati toti divizorii numarului n. ");
            int n1 = int.Parse(Console.ReadLine());
            for (int d = 1; d <= n1 / 2; d++)
                if (n1 % d == 0) Console.Write(d + ",");
            Console.WriteLine(n1);

            //10.Test de primalitate: determinati daca un numar n este prim.
            Console.WriteLine("Test de primalitate: determinati daca un numar n este prim.");

            int n2 = int.Parse(Console.ReadLine());
            for (int d = 2; d * d <= n2; d++)
                if (n2 % d != 0) Console.WriteLine(n2);
                else Console.WriteLine("nu este prim");


            //11.Afisati in ordine inversa cifrele unui numar n. 
            Console.WriteLine("11.Afisati in ordine inversa cifrele unui numar n. ");
            int numar = int.Parse(Console.ReadLine());
            int invers = 0;
            while (numar != 0)
            {
                invers *= 10;
                invers = invers + (numar % 10);
                numar /= 10;
            }
            Console.WriteLine(invers);

            //12.Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 
            Console.WriteLine("Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. ");
            Console.WriteLine("Dati doua numere; neaparat a<b si n<a");
            int g = int.Parse(Console.ReadLine());
            int a4 = int.Parse(Console.ReadLine());
            int b4 = int.Parse(Console.ReadLine());
            int k2 = 0;
            for (int d = a4; d <= b4; d++)
            {
                if (d % g == 0) { k2 += 1; }
            }
            Console.WriteLine(k2);

            //13.Determianti cati ani bisecti sunt intre anii y1 si y2.
            Console.WriteLine("13.Determianti cati ani bisecti sunt intre anii y1 si y2.");
            int y1 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int i = y1 + 1;
            k2 = 0;
            if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
            {
                k2++;
                while (i < y2)
                {
                    i = i + 4;
                    k2++;
                }
            }
            else for (i = y1 + 2; i < y2; i++)
                {
                    if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
                    {
                        k2++;
                        break;
                    }

                }
            while (i < y2)
            {
                i = i + 4;
                k2++;
            }
            Console.WriteLine(k2);

            //14.Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 
            Console.WriteLine("14.Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. ");
            int n3 = int.Parse(Console.ReadLine());
            aux = n3;
            invers = 0;
            while (n3 != 0)
            {
                invers *= 10;
                invers = invers + (n3 % 10);
                n3 /= 10;
            }
            if (invers == aux) Console.WriteLine("este palindrom");
            else Console.WriteLine("nu este palindrom");

            //15.Se dau 3 numere. Sa se afiseze in ordine crescatoare. 
            Console.WriteLine("15.Se dau 3 numere. Sa se afiseze in ordine crescatoare. ");
            int nr1 = int.Parse(Console.ReadLine());
            int nr2 = int.Parse(Console.ReadLine());
            int nr3 = int.Parse(Console.ReadLine());
            aux = 0;
            if (nr1 > nr2)
            {
                aux = nr1;
                nr1 = nr2;
                nr2 = aux;
            }
            if (nr1 > nr3)
            {
                aux = nr1;
                nr1 = nr3;
                nr3 = aux;
            }
            if (nr2 > nr3)
            {
                aux = nr2;
                nr2 = nr3;
                nr3 = aux;

            }
            Console.WriteLine(nr1+","+nr2+","+nr3);

            //16.Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)
            Console.WriteLine("16.Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)");
            int m1 = int.Parse(Console.ReadLine());
            int m2 = int.Parse(Console.ReadLine());
            int m3 = int.Parse(Console.ReadLine());
            int m4 = int.Parse(Console.ReadLine());
            int m5 = int.Parse(Console.ReadLine());
            aux = 0;
            ok = false;
            while (ok==false)
            {
                if (m1 > m2)
                {
                    aux = m1;
                    m1 = m2;
                    m2 = aux;
                }
                else if (m2 > m3)
                {
                    aux = m2;
                    m2 = m3;
                    m3 = aux;
                }
                else if (m3 > m4)
                {
                    aux = m3;
                    m3 = m4;
                    m4 = aux;
                }
                else if (m4 > m5)
                {
                    aux = m4;
                    m4 = m5;
                    m5 = aux;
                }
                if (m1 < m2 && m2 < m3 && m3 < m4 && m4 < m5) ok = true;
            }
            Console.WriteLine(m1 + " " + m2 + " " + m3 + " " + m4 + " " + m5);

            //17.Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid.
            Console.WriteLine("17.Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid");


            Console.ReadKey();
        }
    }
}
