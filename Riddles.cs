namespace TheSphinx
{
  public class Riddle
  {
    public string Question { get; set; }
    public string Answer { get; set; }

  public Riddle(string Question, string Answer)
  {
    Question = Question;
    Answer = Answer;
  }

  public bool CheckAnswer(string userAnswer)
  {
    if(userAnswer == Answer) {
      return true;
    }
    else
    {
      return false;
    }
  }
  }
}