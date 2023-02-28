using ChallengeApp;

Employee user1 = new Employee ("Damian" , "Nowak", "27");
Employee user2 = new Employee ("Ewelina" , "Nowak", "26");
Employee user3 = new Employee ("Alicja" , "Nowak", "13");

user1.AddScore(1);
user1.AddScore(2);
user1.AddScore(3);
user1.AddScore(5);
user1.AddScore(10);

user2.AddScore(10);
user2.AddScore(5);
user2.AddScore(3);
user2.AddScore(2);
user2.AddScore(1);

user3.AddScore(1);
user3.AddScore(2);
user3.AddScore(3);
user3.AddScore(9);
user3.AddScore(4);

List<Employee> users = new List <Employee>()
{ user1, user2, user3};

int maxResult = -1;

Employee userWithMaxResult = null;

foreach (var Employee in users)
{ 
    if (Employee.Result > maxResult)

    {
        userWithMaxResult = Employee;
        maxResult = Employee.Result;
            }
}

Console.WriteLine("Pracownik z najlepszym wynikiem: " + userWithMaxResult.Name +" "+userWithMaxResult.Surname);
  
    Console.WriteLine( "Ilość punktów: " + maxResult );

















