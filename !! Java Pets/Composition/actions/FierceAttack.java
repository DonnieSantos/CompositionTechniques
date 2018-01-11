package actions;

import attributes.PetInfo;

public class FierceAttack implements CanAttack
{
    @Override
    public void atttack(PetInfo target)
    {
        System.out.println(target.getName() + " says, 'OUCH!!!'");
    }
}
