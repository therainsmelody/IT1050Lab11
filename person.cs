using System;

class Person
{
	public string FirstName {get; set}
	public string LastName {get; set}
	public DOB DateofBirth {get; set}
  public string Title {get; set}



public Person()
{
FirstName = firstname;
LastName = lastname;
DOB DateofBirth = dob;
Console.WriteLine("Person constructor");
}

public virtual void Intro()
{
  Console.WriteLine("Hello my name is " + FirstName + " " + Lastname);
  
}
