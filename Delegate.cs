

class Practice
{
    public double salary()
    {
        return 12345.80;
    }

    public int WorkingHrs()
    {
        return 9;
    }

    public bool Attendence(int days)
    {

        if(WorkingHrs() == 9)
        return true;

        else
            return false;
    }

    public void EmpType(string str)
    {
        Console.WriteLine("he is an IT Employee");
    }
}

class MainApp
{
    public static void Main()
    {
        Practice obj = new Practice();
        Func<double> obj1 = obj.salary;  // Implementing func delegate returnig double type
        var res = obj1.Invoke();
        Console.WriteLine(res);

        Func<int> obj2 = obj.WorkingHrs;// Implementing func delegate returning int type
        var temp = obj2.Invoke();
        Console.WriteLine(temp);

        Action<string > obj3 = obj.EmpType;  //Implementing Action delegate
        obj3.Invoke("");

        Predicate<int> obj4 = obj.Attendence; // Implementing Predicate delegate
        bool attend = obj4.Invoke(9);
        Console.WriteLine(attend);


    }
}
