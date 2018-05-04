using System;

namespace Question3
{
    //Create class
     class Person{
         //Get / sets
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Campus {get; set;}

          public int StudentID {get; set;}
          
      



        public Person(string firstName, string lastName, string campus) {
            FirstName = firstName;
            LastName = lastName;
            Campus = campus;    
        }

        public string EnrollStudent() {

            var rand = new Random();
            StudentID = rand.Next(0, 1000);

            return $"{StudentID}";
        }
            //Method
        public string GetFullName() {
            return $"{FirstName} {LastName}";
        }

       public string GetCampus(){
           return $"{Campus}";
       }
         // DisplayInfo method 
        public virtual string DInfo() {
            return $"Person: {GetFullName()} campus: {GetCampus()} with a student ID of {EnrollStudent()} ";
        }
    

  
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter name of student below");
            Console.WriteLine("Firstname:");
           var firstN = Console.ReadLine();

            Console.WriteLine("LastName:");
          var lastN = Console.ReadLine();
          Console.WriteLine("Enter your campus");
          var camp = Console.ReadLine();
          Console.WriteLine("\n Creating new person record... \n");

          
          
           //Create person and display
          var persons = new Person(firstN, lastN, camp);
          Console.WriteLine(persons.DInfo());



        }
     }
}