import java.util.LinkedList;
import java.util.Iterator;

public class Main {

    public static void main(String[] args) {

        Dog dog1 = new Pomeranian("Juju");
        Dog dog2 = new PitBull("Bailey");
        Cat cat1 = new Siamese("Alecto");
        Cat cat2 = new Snowshoe("Megaera");

        LinkedList<Pet> pets = new LinkedList<>();
        pets.add(dog1);
        pets.add(dog2);
        pets.add(cat1);
        pets.add(cat2);

        for (Iterator<Pet> i = pets.iterator(); i.hasNext();) {
            Pet pet = i.next();
            pet.introduce();
        }

        dog1.Bark();
        dog2.Bark();
        cat1.Meow();
        cat2.Meow();
    }
}