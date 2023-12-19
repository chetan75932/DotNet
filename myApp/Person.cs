namespace Person1;

public class Person{
    private int pid;
    private String fName;
    private String lName;

    public Person(){

    }
    public Person(int pid, String fName,String lName){
        this.pid=pid;
        this.fName=fName;
        this.lName=lName;
    }
     public void SetPid(int pid){
        this.pid=pid;
     }
     public int GetPid(){
        return this.pid;
     }
     //this is .net syntax for getter & setter
     public String LName{
        get{
          return this.lName;
        }
        set{
            this.lName=value;
        }
     }
     public String FName{
        get{
          return this.fName;
        }
        set{
            this.fName=value;
        }
     }
     //toString method
     public override String ToString(){
        return this.fName+" "+this.lName;
     }

}