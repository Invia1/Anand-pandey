using System;using SmallEmployeeApp.Models;namespace SmallEmployeeApp.Service{    public class EmployeeService    {        List<Employee> objList = new List<Employee>();
        public int CreateEmployee(Employee emp)
        {            objList.Add(emp);            return 1;
        }

        public List<Employee> GetEmployeeList()
        {            return objList;
        }        public void UpdateEmployee(Employee emp)
        {
            objList.Insert(0,emp);
            Console.WriteLine(" list after inserting elemnt at index '0' ");
            foreach (var data in objList)
            {
                Console.WriteLine(data.EID + " " + data.Ename + " " + data.Age);
            }
        }        public void DeleteEmployee(Employee emp)
        {
            objList.Remove(emp);
            Console.WriteLine("list after deleting elemnet");
            foreach (var data in objList)
            {

                Console.WriteLine(data.EID + " " + data.Ename + " " + data.Age);
            }
        }    }}