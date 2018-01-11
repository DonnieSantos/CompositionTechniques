import attributes.PetInfo;
import sounds.CanMeow;

public class Cat implements PetInfo, CanMeow
{
    protected CanMeow canMeow;
    protected PetInfo attributes;

    public Cat(CanMeow canMeow, PetInfo attributes)
    {
        this.canMeow = canMeow;
        this.attributes = attributes;
    }

    @Override
    public void meow()
    {
        this.canMeow.meow();
    }

    @Override
    public int getAge()
    {
        return this.attributes.getAge();
    }

    @Override
    public String getName()
    {
        return this.attributes.getName();
    }
}