
using System;
class Student
{
private string ? _name;
private DateTime _dateofbirth;
private string? _rollnumber;

//private  field properties
public string Name{
  get{return _name ;}
  set {  
    if(value==null){
      throw new ArgumentException("null value have no return type mean its invalid.");
    }
  }
}
public DateTime Dateofbirth{
  get{return _dateofbirth ;}
  set{
    if(value > DateTime.Now)
    {
throw new ArgumentException("Dateofbirth can't be in future time.");
    }
    _dateofbirth = value ;
  }
}

public string Rollnumber{
  get{return _rollnumber ;}
  set { _rollnumber= value ;}
}


//create a constructor

public Student(string name , DateTime dateofbirth , string rollnumber)
{
Name = name;
Dateofbirth = dateofbirth;
Rollnumber = rollnumber;



}
//Create a Method for calculate age

private int CalculateAge()
{
int age =DateTime.Now.Year - Dateofbirth.Year;
return age;
}                                                    //well Maintain Encapsulation
public int Age{
  get{ return CalculateAge() ;}

}

public  void PrintDetails(string Name, DateTime dateofbirth, string rollnumber){

  
Console.WriteLine($"student Name: {Name}");
Console.WriteLine($"Student Dateof Birth: {dateofbirth.ToShortDateString()}");
Console.WriteLine($"Student roll: {rollnumber}");
Console.WriteLine($"Age :{Age}");
}

    internal void PrintDetails()
    {
        throw new NotImplementedException();
    }
}
class Program{

      public static void Main(){
  
try

{
 Student s1 = new Student("Miraj" ,new DateTime(1990 , 5 ,15),"cse101" );
  Student s2 = new Student("sajida" ,new DateTime(2000 , 6 ,9), "cse101");

//student Details
  Console.WriteLine($"Student details :");
Console.WriteLine($"----------------------");
s1.PrintDetails();

Console.WriteLine($"Next Student: ");

s2.PrintDetails();

}
catch(System.NotImplementedException)
{
Console.WriteLine($"occured: not implement exception");

}
catch(Exception ex)
{
  Console.WriteLine($"{ex}");
  
Console.WriteLine($"Eror occured: {ex.Message}");

}



  }
}