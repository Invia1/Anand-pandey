

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class PersonDetail
{
    List<string> list = new List<string>();
    public void entry()
    {
        list.Add("anand");
        list.Add("ashish");
        list.Add("ani");

        foreach (var ctr in list)
        {
            Console.Write(ctr + " ");
            ;
        }
    }

    public void entry2()
    {
        list.Insert(2, "sandeep");
        list.Insert(1, "ankush");
        Console.WriteLine();

        foreach (var ctr in list)
        {
            Console.Write(ctr + " ");
        }
    }


    public void Delete()
    {
        list.Remove("ankush");
        list.Remove("ashish");
        Console.WriteLine();

        foreach (var ctr in list)
        {
            Console.Write(ctr + " ");
        }
    }

    public void find(string ctr)
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

    public void fetchAll()
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
        obj.entry();
        obj.entry2();
        obj.Delete();
        Console.WriteLine("enter the name");
        string temp = Console.ReadLine();
        obj.find(temp);
        obj.fetchAll();
    }
}
