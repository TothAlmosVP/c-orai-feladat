//int abs_max(int a, int b)
//{
//    if (a>b)
//    {
//        return Math.Abs(a);
//    }
//    if (b > a)
//    {
//        return Math.Abs(b);
//    }
//}

//Console.WriteLine(abs_max(-15,12));


//fibonacci

List<int> fibo = new() {0,1};

Console.WriteLine("Szam: ");
int szam = int.Parse(Console.ReadLine());

for (int i=0;i<=szam;i++)
{
    fibo.Add(fibo[i] + fibo[i + 1]);
}

Console.WriteLine(fibo[szam-1]);