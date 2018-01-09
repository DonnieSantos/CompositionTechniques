import attributes.HasPetAttributes;
import sounds.CanMeow;

public class Cat implements HasPetAttributes {

    protected CanMeow canMeow;
    protected HasPetAttributes attributes;

    public Cat(CanMeow canMeow, HasPetAttributes attributes) {
        this.canMeow = canMeow;
        this.attributes = attributes;
    }

    void meow() {
        this.canMeow.meow();
    }

    @Override
    public void introduce() {
        attributes.introduce();
    }
}