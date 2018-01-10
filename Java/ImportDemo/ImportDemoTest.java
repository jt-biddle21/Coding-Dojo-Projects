public class ImportDemoTest {
    public static void main(String[] args) {
        ImportDemo iD = new ImportDemo(); //Grabs info from the importdemo.java file and uses it here.
        String currentDate = iD.getCurrentDate();
        System.out.println(currentDate);
    }
}
