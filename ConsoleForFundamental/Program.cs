// Data types
//Numbers: Integers and Floating points

// byte? age = 34;              //? datatype ko paxadi ? means datatype is nullable;
// short numberofPeopleInCompany = 23424;   //camel casing
// int areaOfCountry = 123413434;
// long distanceBetweenPlanets = 132323234252424;


// //accuracy (precision)
// float averageWeight = 65.5F;
// double averageDistance = 23234.345243456;
// decimal averageDistanceBetweenElectron = 233455.3435353535353535M;


// //Text
// string name = "Teksewa";
// char gender = 'M';

// //Boolean
// bool isQA = true;

// //Dates
// DateTime dob = new(2000, 03, 06);

//Console.WriteLine (averageWeight);
//string userInput = Console.Readline();
//Console.WriteLine ("you enetered" + userInput.Length + "character");
// Console.WriteLine ($"you enetered { userInput.Length} character");



//get username and convert it to uppercase

//Console.WriteLine ("please enter you name");
//string userName= Console.ReadLine();
//Console.WriteLine ($"your name is {userName.ToUpper()}");

/*Person Binaya = new Person("Binaya R. Devkota", new DateTime (2000, 03, 06), 12345);
//Binaya.name = "Binaya R. Devkota";
//Binaya.dob = new DateTime(2000, 03, 06);
//Binaya.nid = 13245;

Binaya.PrintDetails();
//Console.WriteLine ($"Name: {Binaya.name}\nNational Identifier: {Binaya.nid}\nDate of Birth: {Binaya.dob}"); // \n le naya line ma liyera janxa


Person male = new();
male.name = "B Devkota";
male.dob = new DateTime(2010, 03, 06);
male.nid = 13245;
male.PrintDetails();
*/


//class work
// create a class called "Page"
// with fields height (inch), width (inch) and title
// page should have parameterized constructor which assigns each fields
// create a method that prints height and width of that page in pixels
// create instance of this class and display details in console.


//page web = new page(50, 15, "First Page");
//web.printwebpage();


Student bin = new ("Binaya Raj Devkota", new DateTime(2000, 3, 6), "Teksewa", "CSIT");
var a = bin.calculateAge();
var b = bin.getInitials();

var output = Student.printDetails(initial: b, age:a);
Console.WriteLine(output);  