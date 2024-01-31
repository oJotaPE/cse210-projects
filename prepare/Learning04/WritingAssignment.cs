public class WritingAssignment : Assignment
{
    private string _tittle;


    public void SetTittle(string tittle)
    {
        _tittle = tittle;
    }
    public string GetWritingInformation()
    {
        return $"{_tittle} by {GetName()}";
    }
}