using System;
using System.Collections;
using System.Runtime.InteropServices;

class dataEntry

{
    ArrayList obj = new ArrayList();
    public void AddData()
    {
        obj.Add(10);
        obj.Add(20);
        obj.Add(30);
        obj.Add(40);
        obj.Add(50);


        foreach (var temp in obj)//adding the elements in arrayList

        {
            Console.Write(temp + " ");
        }

    }

    public void InserData()  //Inserting the element in  arrayList
    {
        obj.Insert(2, 70);
        obj.Insert(4, 80);
        Console.WriteLine();
        foreach (var temp in obj)
        {

            Console.Write(temp + " ");
        }
    }

    public void RemoveDta()  //Removing data from arrylist
    {
        obj.Remove(10);
        obj.Remove(20);
        Console.WriteLine();
        foreach (var temp in obj)
        {
            Console.Write(temp + " ");
            
        }
    }

       class  perform
    {
        public static void Main(string[] args)
        {
            dataEntry obj = new dataEntry();
            obj.AddData();
            obj.InserData();
            obj.RemoveDta();


        }
    }
}