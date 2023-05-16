using System;using SmallEmployeeApp.Models;using SmallEmployeeApp.Service;namespace SmallEmployeeApp.UI{    public class MainApp    {        public static void Main()        {
            Employee obj = new Employee();
            obj.EID = 102;
            obj.Ename = "Deep";
            obj.Age = 22;

            Employee obj1 = new Employee();
            obj1.EID = 103;
            obj1.Ename = "Deepa";
            obj1.Age = 23;

            Employee obj2 = new Employee();
            obj2.EID = 104;
            obj2.Ename = "Deepti";
            obj2.Age = 24;

            EmployeeService es = new EmployeeService();
            es.CreateEmployee(obj);
            es.CreateEmployee(obj1);
            es.CreateEmployee(obj2);
            Console.WriteLine("original list after adding element");
            List<Employee> objList = es.GetEmployeeList();
            foreach (var data in objList)
            {
              
                Console.WriteLine(data.EID + " " + data.Ename + " " + data.Age);
            }
            Employee obj3 = new Employee();
            obj3.EID = 105;
            obj3.Ename = "Anand";
            obj3.Age = 25;
            es.UpdateEmployee(obj3);

            

            es.DeleteEmployee(obj1);


        }

    }}
