package sounds;

public class BarkPitBull implements CanBark {
    @Override
    public void bark() {
        System.out.println("WOOF WOOF!");
    }
}