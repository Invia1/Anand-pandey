﻿using System;
        public int CreateEmployee(Employee emp)
        {
        }

        public List<Employee> GetEmployeeList()
        {
        }
        {
            objList.Insert(0,emp);
            Console.WriteLine(" list after inserting elemnt at index '0' ");
            foreach (var data in objList)
            {
                Console.WriteLine(data.EID + " " + data.Ename + " " + data.Age);
            }
        }
        {
            objList.Remove(emp);
            Console.WriteLine("list after deleting elemnet");
            foreach (var data in objList)
            {

                Console.WriteLine(data.EID + " " + data.Ename + " " + data.Age);
            }
        }