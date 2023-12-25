using cartdelegate;
using cart;
using reorder;

AddtoCart ac=new AddtoCart();
Reorder re=new Reorder();
//register the function in delegate
/*adddelegate ad=new adddelegate(ac.orderadded);



//chaining or Attach
ad+=ac.ordercancel;

//dechaining or dettach
ad-=ac.ordercancel;

//calling delegate
ad();*/

//ac.ordercancel();//exception throws o/p-->order cancel. reorder method will not called

adddelegate ad=new adddelegate(re.reorder);

ac.reorder+=re.reorder;

ac.ordercancel();

//Console.WriteLine("Running");