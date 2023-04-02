// See https://aka.ms/new-console-template for more information
using Daythree.Model;
using System.Collections;
/*
Redmi redmi = new Redmi();
Console.WriteLine(redmi.InstallApp("Facebook"));
Console.WriteLine(redmi.Ring("Note 10 pro"));
*/
/*
 Bank bank = new Bank();
Console.WriteLine(bank.setAtmPin("pin1212"));*/
/*
Shape shape = new Shape();
int areaoflength = shape.Area(12);
Console.WriteLine("Area of length= " +areaoflength);

int areaofcircle = shape.Area(13,12,12);
Console.WriteLine("Area of circle= "+ areaofcircle);*/

/*Area area = new Area();
Console.WriteLine("Enter two value l and b");
*/
/*
Android andriod = new Android();

andriod.shutdown();
*/

/*
Car audi = new Audi();
Console.WriteLine(  audi.CarMovement());
Console.WriteLine(audi.CarBatteryCharge());

Ford ford = new Ford();
Console.WriteLine(ford.getCarMovement);
Console.WriteLine(ford.getBatterycharge);*/


//calling parameterized constructor with employee details
//CopyConstructor employee= new CopyConstructor("Suman","0000000000");
//calling copy constructor
//CopyConstructor EmployeeCopy = new CopyConstructor(employee);

//calling private constructor
// PrivateConstructor.getManagerDetails("Ram", "012012012");

class Foreach
{
    static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        list.Add("Sagar ");
        list.Add("Suman");
        list.Add("Abc");

        foreach(string name in list)
            Console.WriteLine( "list ");
        Console.ReadLine();
    }
}