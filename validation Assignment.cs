

using System.ComponentModel;

class EmployeeApp
{
   

    public int  EmployeeID { get; set; }
    public string EmployeName { get; set; }
    public int EmployeeAge { get; set; }
}
class hr
{
    public EmployeeApp employeeDetail()
    {
        EmployeeApp obj = new EmployeeApp();
        int Id;

    pool:
        try
        {
            Console.WriteLine("Enter the EmployeeId: ");
            Id = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Please use only digit value:");
            goto pool;
        }
        obj.EmployeeID = Id;

    loop:
        Console.WriteLine("Enter your name:");
        string name= Console.ReadLine();

        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Name cannot be blank:");
            goto loop;
        }
        foreach (var temp in name)
        {
            if (char.IsDigit(temp))
            {
                Console.WriteLine("Name should not be a digit:");
                goto loop;

            }
        }
        obj.EmployeName = name;
    prop:
        int age;
        try
        {
            Console.WriteLine("Enter the employeeAge:");
            age = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Enter the valid digit only:");
            goto prop;
        }

        obj.EmployeeAge = age;

        return obj;
    }
}
    
class director
{
    public static void Main()
    {
        hr obj = new hr();
        EmployeeApp temp = obj.employeeDetail();
        Console.WriteLine(temp.EmployeeID + " " + temp.EmployeName + " " + temp.EmployeeAge);
    }
   
}
