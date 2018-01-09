package attributes;

public class PetAttributes implements HasPetAttributes {

    private String name;

    public PetAttributes(String name) {
        this.name = name;
    }

    @Override
    public void introduce() {
        System.out.println("This is '" + this.name  + "'.");
    }
}