package sounds;

public class BarkSoft implements CanBark
{
    @Override
    public void bark()
    {
        System.out.println("ruff!");
    }
}