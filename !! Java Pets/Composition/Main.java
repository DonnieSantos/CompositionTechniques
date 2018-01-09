import attributes.*;
import sounds.*;

import java.util.LinkedList;
import java.util.Iterator;

public class Main {

    public static void main(String[] args) {

        Dog dog1 = new Dog(new BarkPitBull(), new PetAttributes("Bailey"));
        Dog dog2 = new Dog(new BarkPomeranian(), new PetAttributes("Juju"));
        Cat cat1 = new Cat(new MeowSiamese(), new PetAttributes("Alecto"));
        Cat cat2 = new Cat(new MeowSnowshoe(), new PetAttributes("Megaera"));

        LinkedList<HasPetAttributes> pets = new LinkedList<>();
        pets.add(dog1);
        pets.add(dog2);
        pets.add(cat1);
        pets.add(cat2);

        for (Iterator<HasPetAttributes> i = pets.iterator(); i.hasNext();) {
            HasPetAttributes pet = i.next();
            pet.introduce();
        }

        dog1.bark();
        dog2.bark();
        cat1.meow();
        cat2.meow();
    }
}