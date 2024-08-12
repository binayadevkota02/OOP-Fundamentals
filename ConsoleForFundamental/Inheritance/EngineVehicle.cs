public class EngineVehicle: Vehicle, IVehicle // adding IVehicle acts as multiple inheritance
{
    public EngineVehicle(string number ,float engineCC, float mileage) : base(number)
    {
        EngineCC = engineCC;
        Mileage = mileage;
    }
    public float EngineCC { get; set; }

    public float Mileage { get; set;}
    public float GetDistanecCovered (float oilUsed) => Mileage * oilUsed; 
  
}