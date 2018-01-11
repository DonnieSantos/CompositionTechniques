package sounds;

public class BarkLoud implements CanBark
{
    @Override
    public void bark()
    {
        System.out.println("WOOF WOOF!");
    }
}