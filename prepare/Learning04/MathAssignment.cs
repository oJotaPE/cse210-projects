public class MathAssignment : Assignment
{
    private float _textbook;
    private string _problems;

    public MathAssignment()
    {
        _problems = "no problems";
        _textbook = 0;
    }

    public void SetTextbook(float textbook)
    {
        _textbook = textbook;
    }

    public void SeProblems(int firstProblem, int lastProblem)
    {
        string problem1 = firstProblem.ToString();
        string problem2 = lastProblem.ToString();

        _problems = $"{problem1}-{problem2}";
    }

    public string GetHomework()
    {
        return $"Section {_textbook} Problems{_problems}";
    }

}