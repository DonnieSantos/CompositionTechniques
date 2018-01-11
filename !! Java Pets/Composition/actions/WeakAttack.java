package actions;

import attributes.PetInfo;

public class WeakAttack implements CanAttack
{
    @Override
    public void atttack(PetInfo target)
    {
        System.out.println(target.getName() + " says, 'Ow.'");
    }
}