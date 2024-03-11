using System.Linq;

Random r=new Random();
string generatePassword ()
{
    String password = "";
    int x;
    for (int i = 0; i < 10; i++)
    {
        x = r.Next(65, 91);
        password += Char.ConvertFromUtf32(x);
    }
    return password;
}
Console.WriteLine(generatePassword());