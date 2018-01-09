package sounds;

public class BarkPomeranian implements CanBark {
    @Override
    public void bark() {
        System.out.println("ruff!");
    }
}