using System.Security.Cryptography.X509Certificates;

class MainClass
{
    static void Main(String[] args)
    {
        Console.WriteLine("Masukkan Satu Huruf: ");
        char userInput = Convert.ToChar(Console.ReadLine());
        Console.WriteLine(cekVokal(userInput));
        arrayAngka();
    }
    static string cekVokal(char abjad)
    {
        char[] vokal = { 'A', 'I', 'U', 'E', 'O' };
        foreach (char v in vokal)
        {
            if (abjad == v)
            {
                return "Huruf " + abjad + " Merupakan huruf vokal";
            }
        }
        return "Huruf " + abjad + " Merupakan huruf konsonan";
    }

    static void arrayAngka()
    {
        int[] angkaGenap = { 2, 4, 6, 8, 10 };
        for (int i = 0; i < angkaGenap.Length; i++)
        {
            Console.WriteLine("Angka genap " + (i+1) + ": " + angkaGenap[i]);
        }
    }
}
