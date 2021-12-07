namespace TheSphinx.Models
{
  public class Riddle
  {
    public string Question { get; set; }
    public string Answer { get; set; }

  public Riddle(string question, string answer)
  {
    Question = question;
    Answer = answer;
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