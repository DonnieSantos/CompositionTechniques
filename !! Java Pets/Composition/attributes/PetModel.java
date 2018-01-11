package attributes;

public class PetModel implements PetInfo
{
    private String name;
    private int age;

    public PetModel(String name, int age)
    {
        this.name = name;
        this.age = age;
    }

    @Override
    public int getAge()
    {
        return this.age;
    }

    @Override
    public String getName()
    {
        return this.name;
    }
}