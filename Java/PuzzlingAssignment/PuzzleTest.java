public class PuzzleTest{
    public static void main(String[] args){
        Puzzle test = new Puzzle();
        int[] arr = {3,5,1,2,7,9,8,13,25,32};
        String[] names = {"Nancy", "Fujibayashi", "Momochi", "Ishikawa"};
        String[] alpha = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
        String randWord = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        test.randomStringArray(randWord);
        
    }
}