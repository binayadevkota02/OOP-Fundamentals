// Data types
//Numbers: Integers and Floating points

byte? age = 34;              //? datatype ko paxadi ? means datatype is nullable;
short numberofPeopleInCompany = 23424;   //camel casing
int areaOfCountry = 123413434;
long distanceBetweenPlanets = 132323234252424;


//accuracy (precision)
float averageWeight = 65.5F;
double averageDistance = 23234.345243456;
decimal averageDistanceBetweenElectron = 233455.3435353535353535M;


//Text
string name = "Teksewa";
char gender = 'M';

//Boolean
bool isQA = true;

//Dates
DateTime dob = new(2000, 03, 06);

Console.WriteLine (averageWeight);
 string userInput = Console.Readline();
Console.WriteLine ("you enetered" + userInput.Length + "character");
Console.WriteLine ($"you enetered { userInput.Length} character");



//get username and convert it to uppercase

Console.WriteLine ("please enter you name");
string username= Console.ReadLine();
Console.WriteLine ($"your name is {userInput.ToUpper()}");