namespace Utility;
using System.IO;

public class FileIOManager{

     public  void ReadData( ){
        string data =File.ReadAllText(@"c:\test\products.json");

     }

    public void WriteData(){
        string data=" ";
        File.WriteAllText(@"c:\test\products.json",data);

    }
}