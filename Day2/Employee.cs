namespace Emp;

public class Employee{
    private int empId;
    private String fullName;
    private string mobileNo;
    private String emailId;

    public Employee(){

    }
    public Employee(int empId,String fullName,String mobileNo,String emailId){
        this.empId=empId;
        this.fullName=fullName;
        this.mobileNo=mobileNo;
        this.emailId=emailId;
    }
   
   public int EmpId{
    get{
       return this.empId;
    }set{
        this.empId=value;
    }
   }

   public String FullName{
    get{
       return this.fullName;
    }set{
        this.fullName=value;
    }
   }
   public String MobileNo{
    get{
       return this.mobileNo;
    }set{
        this.mobileNo=value;
    }
   }
   public String EmailId{
    get{
        return this.emailId;
    }set{
         this.emailId=value;
    }
   }

   public override String ToString(){
       return "emailId :"+emailId+"\nmobileNo :"+mobileNo+"\nfullName :"+fullName+"\nempId :"+empId;
   }
}