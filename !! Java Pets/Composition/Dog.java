import attributes.HasPetAttributes;
import sounds.CanBark;

public class Dog implements HasPetAttributes {

    protected CanBark canBark;
    protected HasPetAttributes attributes;

    public Dog(CanBark canBark, HasPetAttributes attributes) {
        this.canBark = canBark;
        this.attributes = attributes;
    }

    public void bark() {
        this.canBark.bark();
    }

    @Override
    public void introduce() {
        attributes.introduce();
    }
}