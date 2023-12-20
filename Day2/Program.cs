using car;
using vehicles;
using Emp;
using salEmp;

/*Vehicle v=new Vehicle("Two-Wheeler",1553);
Console.WriteLine(v);

Car c=new Car("four-Wheeler",152089,"Petrol-Engine","V-244","sus");
Console.WriteLine(c);

int a=(int)c.CalAverage();
Console.WriteLine(a);

Employee e1=new Employee(12,"Chetan Karnik","8888293604","ceetc444@gmail.com");
Console.WriteLine(e1);

//type casting .
Employee e2=new SalaredEmp();*/
/*SalaredEmp se1=(SalaredEmp)new Employee();
Console.WriteLine(se1);*/

Employee e1=new SalaredEmp(12,"Chetan Karnik","8888293604","ceetc444@gmail.com",70000,8);
Console.WriteLine(e1);