public abstract class Pet {

    private String name;

    public Pet(String name) {
        this.name = name;
    }

    public void introduce() {
        System.out.println("This is '" + this.name  + "'.");
    }
}