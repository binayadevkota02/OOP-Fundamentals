class PersonBMI
{   
    public  PersonBMI (string n, double h, double w)
    {
        name = n;
        height = h;
        weight = w;
    }
    public string name;

    public double height;

    public double weight;


    double BMICalculator(double height, double weight)
    {
        double BMI = weight/Math.Pow((height * 0.3048),2);
        return  Math.Round(BMI,3);
    }


     public void PrintBMIDetails()
    {
        Console.WriteLine ($" The BMI Index of {name} having Height: {height} ft and Weight: {weight} kg is {BMICalculator(this.height, this.weight)}."); 
    }


}
