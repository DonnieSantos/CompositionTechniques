import attributes.PetInfo;
import sounds.CanBark;

public class Dog implements PetInfo, CanBark
{
    protected CanBark canBark;
    protected PetInfo attributes;

    public Dog(CanBark canBark, PetInfo attributes)
    {
        this.canBark = canBark;
        this.attributes = attributes;
    }

    public void bark()
    {
        this.canBark.bark();
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