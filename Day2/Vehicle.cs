namespace vehicles;

public abstract class Vehicle{
    private String typeOfVehicle;
    private int vehicleId;
      
    public Vehicle(){
          
    }
    public Vehicle(String typeOfVehicle,int vehicleId){
        this.typeOfVehicle=typeOfVehicle;
        this.vehicleId=vehicleId;
    }

    public void SetTypeOfEngine(String typeOfVehicle){
          this.typeOfVehicle=typeOfVehicle;
    }
    public String GetTypeOfEngine(){
        return this.typeOfVehicle;
    }

    public int VehicleId{
        get{
            return this.vehicleId;
        }
        set{
            this.vehicleId=value;
        }
    }
// abstract method
   public abstract double CalAverage();

    public override String ToString(){
        return this.typeOfVehicle+" "+this.vehicleId;
    }
}