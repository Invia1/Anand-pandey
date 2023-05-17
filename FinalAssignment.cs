using System;
class HospitalDetails
{
 public int Registerid;
 public string Firstname;
public string Lastname;
 public string Phoneno;
 public string Gender;
  public int Age;
  public string Address;
  public string Adharno;
  public int Specialties;
  

public void Details()
{
Console.WriteLine("WELCOME To RIM HOSPITAL");
Console.WriteLine("Enter Patient Details");
Random unique =new Random();
 Registerid=unique.Next();
 Console.WriteLine(" Register id : "+Registerid);
 Console.WriteLine("Enter Patient First Name:");
 Firstname=Console.ReadLine();
 Console.WriteLine("Enter your Last Name:");
 Lastname=Console.ReadLine();
Console.WriteLine("Patient Phone no:");
 Phoneno=Console.ReadLine();
 Console.WriteLine("Patient Gender:");
 Gender=Console.ReadLine();
 Console.WriteLine("Patient Age:");
 Age=Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Patient Address:");
Address=Console.ReadLine();
 Console.WriteLine("Patient Adharno:");
Adharno=Console.ReadLine();

Console.WriteLine("Select the Specialties: \n 1. General Medicine \n 2. Orthopaedics \n 3. Dental");
 Specialties = Convert.ToInt32(Console.ReadLine());
}
public void Display()
{
Console.WriteLine(" Patient Details");
Console.WriteLine("Patient Register id: "+Registerid);
 Console.WriteLine("Patient First Name : "+Firstname);
 Console.WriteLine("Patient First Name : "+Lastname);
 Console.WriteLine("Patient Phone No : "+Phoneno);
 Console.WriteLine("Patient Gender : "+Gender);
Console.WriteLine("Patient Age : "+Age);
Console.WriteLine("Patient Address : "+Address);
Console.WriteLine("Patient Adharno : "+Adharno);
switch (Specialties)
 {
 case 1: Console.WriteLine("Patient Specialties : Orthopaedics");
  break;
 case 2: Console.WriteLine("Patient Specialties : Orthopaedics");
  break;
case 3: Console.WriteLine("Patient Specialties : Dental");
 break;
 }
}
    public static void Main()
    {
         Console.WriteLine("Number of Patient :");
                    int number = Convert.ToInt32(Console.ReadLine());
                   HospitalDetails[] arr = new HospitalDetails[number];
                   char cont = 'c';
        while (Char.ToLower(cont) == 'c')
        {
         Console.WriteLine("Choose an options :\n1: Register \n2: View Details");
            int cases = Convert.ToInt32(Console.ReadLine());
             switch (cases)
    {
                case 1:
                   
                    for (int i = 0; i < number; i++)
                    {
                        arr[i] = new HospitalDetails();
                        arr[i].Details();
                        Console.WriteLine(" Inserted successfully : ");
                    }
                    break;
                case 2:
                    foreach (HospitalDetails patient in arr)
                    {
                        patient.Display();
                    Console.WriteLine("New Record : ");
                    }
                    break;
                default:
                    Console.WriteLine("Thankyou");
                    break;  
        }
          Console.WriteLine("Press c to continue; Press any other key to exit......................");
            cont = Convert.ToChar(Console.ReadLine());
            }
        }
}
