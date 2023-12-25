namespace deepcopy;
public class Stack:ICloneable{
   private int size;
   private int[] sArr;
    public Stack(int s){
        this.size=s;
        this.sArr=new int[size];

        this.sArr[0]=2;
        this.sArr[1]=2;
    }

    

    //Deep Copy implementation
    public object Clone(){
        Stack replica=new Stack(this.size);
        this.sArr.CopyTo(replica.sArr,0);
        this.sArr[0]=5;
        Console.WriteLine(replica.sArr[0]+" "+replica.sArr[3]);
        
        return replica;
    }

   /* public void display()
    {
        for(int i=0;i<sArr.Length;i++)
          Console.WriteLine(sArr[i]);
    }*/
}