class Student(string name, DateTime dob, string college, string program)
{
    public string name = name;
    public DateTime dob = dob;

    public string college = college;    

    public string program = program;   
    
    //calculate age of student in years and months e.g. 22 years and 2 months

    public string calculateAge() 
    {
        var ageSpan = DateTime.Now -  dob;
        var year = ageSpan.Days/ 365;
        var months = ageSpan.Days % 365 /30;
        return $"Your age is {year}years and {months}months";
    }
//get name initials of a student eg. Ram Thapa as RT
        public string getInitials()
        {
            var nameParts = name.Split(" ");
            char firstInitialName = nameParts[0][0];
            var lastInitialName = nameParts[nameParts.Length - 1][0];
            return $"{firstInitialName}{lastInitialName}";
        }
            public string capitalizeName() =>name.ToUpper();   //=> (arrow operator)paxi tesari garyo vaney we don't need to return
//             {
//                 return name.ToUpper();
//             }

          // Print details of the students. output format: BR is 22 years and 2 months old.
          
        public static string printDetails( string initial, string age) => $"{initial}  {age} old";
        // static is used in this context beacuse it is not depended on class object    



        public static string printDetails( string initial,string age, int ageDays - 0) =>
        $"{initial} is {age} old. Indays he/she is {ageDays}.";


}
