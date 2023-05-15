

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class PersonDetail
{
    List<string> list = new List<string>();
    public void entry()
    {
        list.Add("anand");  //adding the elements
        list.Add("ashish");
        list.Add("ani");

        foreach (var ctr in list)
        {
            Console.Write(ctr + " ");
            ;
        }
    }

    public void entry2()  //Inserting elments
    {
        list.Insert(2, "sandeep");
        list.Insert(1, "ankush");
        Console.WriteLine();

        foreach (var ctr in list)
        {
            Console.Write(ctr + " ");
        }
    }


    public void Delete()  //deleting elements
    {
        list.Remove("ankush");
        list.Remove("ashish");
        Console.WriteLine();

        foreach (var ctr in list)
        {
            Console.Write(ctr + " ");
        }
    }

    public void find(string ctr)  //searching for the elements
    {


        if (list.Contains(ctr))
        {

            Console.WriteLine("search found");
        }

        else
        {
            Console.WriteLine("search not found ");
        }


    }

    public void fetchAll()  //fetchuing the elmentes
    {
        foreach (var ctr in list)
        {
            Console.Write(ctr + " ");
        }
    }
}
class user
{
    public static void Main()
    {
        PersonDetail obj = new PersonDetail();
        obj.entry(); //calling add function
        obj.entry2();// calling insert function
        obj.Delete();// calling delete function
        Console.WriteLine("enter the name");// taking user input for searching elements 
        string temp = Console.ReadLine();
        obj.find(temp);//calling seatrch function
        obj.fetchAll(); //calling fetch function
    }
}
