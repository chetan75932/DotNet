using vehicles;
namespace car;

public class Car : Vehicle{
    private String typeOfEngine;
    private String modelOfCar;
    private String typeOfCar;
 
    public Car(){

    }
    public Car(String typeOfVehicle,int vehicleId,String typeOfEngine,String modelOfCar,String typeOfCar):base(typeOfVehicle,vehicleId){
       
        this.typeOfEngine=typeOfEngine;
        this.modelOfCar=modelOfCar;
        this.typeOfCar=typeOfCar;
    }

    public String TypeOfEngine{
        get{
             return this.typeOfEngine;
        }set{
              this.typeOfEngine=value;
        }
    }
    public String ModelOfCar{
        get{
          return this.modelOfCar;
        }set{
            this.modelOfCar=value;
        }
    }
    public String TypeOfCar{
        get{
           return this.typeOfCar;
        }set{
           this.typeOfCar=value;
        }
    }
    public override double CalAverage(){
        double Average=45;
         return Average;
    }
    public override String ToString(){
        return base.ToString()+"\n typeOfEngine :----\n"+typeOfEngine+"\n modelOfCar :----\n"+modelOfCar+"\ntypeOfCar :----\n"+typeOfCar;
    }
}