import actions.FierceAttack;
import attributes.*;
import sounds.*;

import java.util.LinkedList;
import java.util.Iterator;

public class Main
{
    public static void main(String[] args)
    {
        Dog dog1 = new Dog(new BarkLoud(), new PetModel("Bailey", 9));
        Dog dog2 = new Dog(new BarkSoft(), new PetModel("Juju", 7));
        Cat cat1 = new Cat(new MeowLoud(), new PetModel("Alecto", 5));
        Cat cat2 = new Cat(new MeowSoft(), new PetModel("Megaera", 3));

        LinkedList<PetInfo> pets = new LinkedList<>();
        pets.add(dog1);
        pets.add(dog2);
        pets.add(cat1);
        pets.add(cat2);

        for (Iterator<PetInfo> i = pets.iterator(); i.hasNext();)
        {
            PetInfo pet = i.next();
            System.out.println(pet.getName() + " - " + pet.getAge());
        }

        dog1.bark();
        dog2.bark();
        cat1.meow();
        cat2.meow();

        new Wolf()
            .setCanAttack(new FierceAttack())
            .setCanBark(new BarkLoud())
            .setPetInfo(new PetInfo()
            {
                @Override public int getAge() { return 12; }
                @Override public String getName() { return "Ghost"; }
            })
            .atttack(dog1);
    }
}