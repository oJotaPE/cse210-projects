public class Display
{
    int teste = 0;
    public void _DisplayCurrent(List<string> answerList)
    {
        foreach (string entry in answerList)
        {
            Console.WriteLine(entry);
            teste = teste + 1;
            Console.WriteLine(teste);
        }

    }
}