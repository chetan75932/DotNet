using Emp;

namespace salEmp;

public class SalaredEmp : Employee{
    private double salary;
    private int hrs;

     public SalaredEmp(){

     }
     public SalaredEmp(int empId,String fullName,String mobileNo,String emailId,double salary,int hrs):base(empId,fullName,mobileNo,emailId){
         this.salary=salary;
         this.hrs=hrs;
     }
     public int Hrs{
        get{
              return this.hrs;
        }set{
            this.hrs=value;
        }
     }
     public double Salary{
        get{
            return this.salary;
        }set{
            this.salary=value;
        }
     }

     public override String ToString(){
        return base.ToString()+"\nSalary :"+salary+"\nHrs :"+hrs;
     }
}