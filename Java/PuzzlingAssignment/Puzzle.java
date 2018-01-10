import java.util.*;

public class Puzzle{
    public static void main(String[] args){
    }
    public ArrayList sumGreater10(int[] arr){
        ArrayList<Integer> greaterArr = new ArrayList<Integer>();
        int sum = 0;
        for(int x = 0; x < arr.length; x++){
            sum += arr[x];
            if(arr[x] > 10){
                greaterArr.add(arr[x]);
            }
        }
        System.out.println(sum + "\n" + greaterArr);
        return greaterArr;
    }
    public List shuffleArray(String[] names){
        List<String> shufName = Arrays.asList(names);
        ArrayList<String> greater5 = new ArrayList<String>();
        for(String x : names){
            if(x.length() > 5){
                greater5.add(x);
            }
        }
        Collections.shuffle(shufName);
        System.out.println(shufName);
        System.out.println(greater5);
        return shufName;
    }
    public List shuffleAlpha(String[] alpha){
        List<String> shufAlpha = Arrays.asList(alpha);
        Collections.shuffle(shufAlpha);
        String last = shufAlpha.get(shufAlpha.size() - 1);
        System.out.println(shufAlpha);
        System.out.println(last);
        return shufAlpha;
    }
    public static ArrayList getRandomArray(){
        ArrayList<Integer> arrRand = new ArrayList<Integer>();
        Random rand = new Random();
        int x = 0;
        while (x < 10){
            arrRand.add(rand.nextInt((100 - 55) + 1) + 55);
            x++;
        }
        System.out.println(arrRand);
        return arrRand;
    }
    public static ArrayList getRandomSortedArray(){
        ArrayList<Integer> arrRand = new ArrayList<Integer>();
        Random rand = new Random();
        int x = 0;
        while (x < 10){
            arrRand.add(rand.nextInt((100 - 55) + 1) + 55);
            x++;
        }
        Collections.sort(arrRand);
        int z = 0;
        for(int p : arrRand){
            if (z == 0){
                System.out.println(p);
            }
            if (z == 9){
                System.out.println(p);
            }
            z++;
        }
        System.out.println(arrRand);
        return arrRand;
    }
    public String randomString(String word){
        StringBuilder builder = new StringBuilder();
        Random rand = new Random();
        for(int x = 0; x < 5; x++){
            builder.append(word.charAt(rand.nextInt(word.length())));
        }
        String finalString = builder.toString();
        System.out.println(finalString);
        return finalString;
    }
    public ArrayList randomStringArray(String word){
        StringBuilder builder = new StringBuilder();
        Random rand = new Random();
        String finalString;
        ArrayList<String> wordArray = new ArrayList<String>();
        for(int z = 0; z < 10; z++){
            for(int x = 0; x < 5; x++){
                builder.append(word.charAt(rand.nextInt(word.length())));
            }
            finalString = builder.toString();
            wordArray.add(finalString);
            finalString = "";
            builder.delete(0, 5);
        }
        System.out.println(wordArray);
        return wordArray;
    }
}