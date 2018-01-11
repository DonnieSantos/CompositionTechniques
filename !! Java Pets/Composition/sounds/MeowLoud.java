package sounds;

public class MeowLoud implements CanMeow
{
    @Override
    public void meow()
    {
        System.out.println("Meow Meow.");
    }
}