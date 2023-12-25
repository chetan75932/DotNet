namespace cart;
using cartdelegate;


public class AddtoCart{

    public event adddelegate reorder;

    public void orderadded()
    {
        Console.WriteLine("Order succesfully added!");
    }

    public void ordercancel()
    {
        Console.WriteLine("order cancelled!");
        reorder();
    }
}