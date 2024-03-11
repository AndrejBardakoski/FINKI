// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter r for random numbers or n for manualy entered numbers");
bool random = Console.ReadLine()=="r";
List<int> array = new List<int>();
int[] numbers=new int[1000];
int sum = 0;
int max=0,min=0;
bool flag = false;
int N;
if (!random) {
    N = int.Parse(Console.ReadLine());
    for (int i = 0; i < N; i++)
    {
        int num = int.Parse(Console.ReadLine());
        if (i == 0) { max = min = num; }
        numbers[i] = num;
        sum += num;
        array.Add(num);
        if (num > max) { max = num; }
        if (num < min) { min = num; }
    }
}
else {
    N = 1000;
    Random r = new Random();
    for (int i = 0; i < N; i++) {
        int num = r.Next(-700, 10000);
        if (i == 0) { max = min = num; }
        numbers[i] = num;
        array.Add(num);
        sum += num;
        if (num > max) { max = num; }
        if (num < min) { min = num; }

    }
}
Console.WriteLine("The average is {0}, the max element is {1} and the min element is {2}",
    array.Average(), array.Max(), array.Min());
Console.WriteLine("The average is {0}, the max element is {1} and the min element is {2}",    sum*1.0/N, max, min);



