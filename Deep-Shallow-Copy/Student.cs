namespace Students;

public class Student{
      public int PRN{set;get;}
      public String FullName{set;get;}
      public String Address{set;get;}

      public Student(){

      }
      public Student(int prn,String nm,String Address){
        this.PRN=prn;
        this.FullName=nm;
        this.Address=Address;
      }
      public override String ToString(){
        return this.PRN+" "+this.FullName+" "+this.Address;
      }
}