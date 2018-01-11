import actions.CanAttack;
import attributes.*;
import sounds.CanBark;

public class Wolf implements CanAttack
{
    private PetInfo petInfo;
    private CanAttack canAttack;
    private CanBark canBark;

    public Wolf setPetInfo(PetInfo petInfo)
    {
        this.petInfo = petInfo;
        return this;
    }

    public Wolf setCanAttack(CanAttack canAttack)
    {
        this.canAttack = canAttack;
        return this;
    }

    public Wolf setCanBark(CanBark canBark)
    {
        this.canBark = canBark;
        return this;
    }

    @Override
    public void atttack(PetInfo target) {
        System.out.println(this.petInfo.getName() + " is attacking!");
        this.canBark.bark();
        this.canAttack.atttack(target);
    }
}
