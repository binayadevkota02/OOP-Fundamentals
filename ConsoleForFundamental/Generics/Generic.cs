public class Generics     //<> angle bracket means generics
{
    public void PrintDetails<T,U>(T x, U y)    // yeha yesari T rakhna le we dont have to define each data types seperatly

    {
        Console.WriteLine($"value of x: {x} and y :{y} resp.");
    }   

    //  public void PrintDetails(float x, float y)

    // {
    //     Console.WriteLine($"value of x: {x} and y :{y} resp.");
    // }   

    //  public void PrintDetails(byte x, float y)

    // {
    //     Console.WriteLine($"value of x: {x} and y :{y} resp.");
    // }   


}