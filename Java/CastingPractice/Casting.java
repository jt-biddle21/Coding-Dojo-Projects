class Casting {
    public static void main(String[] args) {
        double d = 35.25;
        double dd = 35.99;

        // casting the double d into a int
        int i = (int) d;

        // casting the double dd into a int
        int ii = (int) dd;
        System.out.println(i);
        System.out.println(ii);
//Above is explicit casting. Meaning we are physically casting the variables
        //--\\
//Below is implicit casting. Meaning java will cast it for us
        int x = 35;
        float f = x;
        System.out.println("The number is: " + f);
        //Output is 35.0
    }
}
