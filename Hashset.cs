

using System;
using System.Collections.Generic;

class practice
{
    public static void Main()
    {
        HashSet<String> countries= new HashSet<String>();
        //ading elements in hashset 1
        countries.Add("India");
        countries.Add("Austrilia");
        countries.Add("UK");
        countries.Add("USA");

        //adding duplicate element in hashset

        countries.Add("Austrilia");
        countries.Add("UK");

        Console.WriteLine("elemnts count:" +countries.Count);// counting the elements

        Console.WriteLine("diplaying all the added elemnts in hashset 1");

        foreach(var item in countries)
        {
            Console.WriteLine(item);
        }

        //removing the elements from hashset
        countries.Remove("UK");
        Console.WriteLine("element count after removing from hashset :" + countries.Count);
        Console.WriteLine("hashset after removing elements");
        foreach(var item in countries)
        {
            Console.WriteLine(item);
        }

        // checking that elements are present in the sets or not

        Console.WriteLine("is india exists: " + countries.Contains("india"));
        Console.WriteLine("is Austrelia exists: " + countries.Contains("austrelia"));

        //creating hashset 2 and adding some element for doing set operation       
        HashSet<String> countries2 = new HashSet<String>();
        countries2.Add("india");
        countries2.Add("srilanka");
        countries2.Add("Austrelia");
        countries2.Add("bangladesh");
        Console.WriteLine("elemnts count:" + countries2.Count);

        Console.WriteLine("diplaying all the added elemnts in hashset 2");

        foreach (var item in countries2)
        {
            Console.WriteLine(item);
        }

        //Doing set operation

        //unoion opertaion
        countries.UnionWith(countries2);
        Console.WriteLine("hashset after doing unionoperation:");
            foreach(var item in countries)
        {
            Console.WriteLine(item);
        }

        //Intersection Opeeration

            countries.IntersectWith(countries2);
        Console.WriteLine("hashset after doing intersection operation the common element to be displayed");
        foreach( var item in countries)
        {
            Console.WriteLine(item);
        }




    }
}