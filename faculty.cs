using System;

class Faculty : Person
{
	public string ID {get; set}
	public DateTime DateofEmployement {get; set}
	public string Employer {get; set}
	public decimal YearlySalary {get; set}
	public bool Tenured {get; set}

  public overide string Title {
    get{return base.Title;}
    
    set{
      string title ="Instructor"
    }
  }


public Faculty() : base()
{



}

//with paramenters

public Faculty(string firstname, string lastname) : base (firstname, lastname)
  {
 
  }

public void IsTenured()
{
    if ((Date.Time.Today.Month - DateofEmployment.Day.Month) >= 5)
    tenured = true; 
    else
      tenured = false; 
}

public void Promote()
{
  if (Title=Instructor && (Date.Time.Today.Month - DateofEmployment.Day.Month) > 2))
    title = AssistantProfessor
    Console.WriteLine("Faculty promoted to Assistant Professor rank")
  else if (Title=AssistantProfessor && (Date.Time.Today.Month - DateofEmployment.Day.Month) > 5))
    title = AssociateProfessor
    Console.WriteLine("Faculty promoted to Associate Professor rank")
  else if (Title=AssociateProfessor && (Date.Time.Today.Month - DateofEmployment.Day.Month) > 10))
    title = Professor
    Console.WriteLine("Faculty promoted to Professor rank")
  else if (Title=Professor)
    Console.WriteLine("No more promotion possible")
}

public override void Intro()
{
  base.Intro();
  Console.WriteLine("I've worked as a" + Title + " at " + Employer + "since " +DateofEmployment);
}
}