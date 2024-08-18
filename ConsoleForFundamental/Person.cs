namespace ABC;
class Person
{
    public Person ()
    {
    }
    public Person(string n, DateTime d, long i)
    {
        name = n;
        dob = d;
        nid = i;

    }
   public string name;
   public long nid;

   public DateTime dob;

    public void PrintDetails()
    {
        Console.WriteLine ($"Name: {this.name}\nNational Identifier: {this.nid}\nDate of Birth: {this.dob}"); // \n le naya line ma liyera janxa
        
    }
    public static string PrintDetails(Person person) =>
        $"Name: {person.name}\nNational Identifier: {person.nid}\nDate of Birth: {person.dob}"; 

    

}