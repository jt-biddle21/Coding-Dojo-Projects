public class StringManipulatorTest {
    public static void main(String[] args) {
        StringManipulator manipulator = new StringManipulator();
        String word = manipulator.concatSubstring("Hello", 1, 2, "world");
        System.out.println(word); // eworld        
    }
}