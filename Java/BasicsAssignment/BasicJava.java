import java.util.*;
public class BasicJava {
    public static void main(String[] args){

    }
    public static void count(){
        for(int x = 0; x < 256; x++){
            System.out.println(x);
        }
    }
    public static void countOdd(){
        for(int x = 0; x < 256; x++){
            if (x % 2 == 1){
                System.out.println(x);
            }
        }
    }
    public static void sum255(){
        int sum = 0;
        for(int x = 0; x < 256; x++){
            sum += x;
            System.out.println("New Number: " + x + " Sum: " + sum);
        }
    }
    public void iterateArray(int[] arr){
        for(int x = 0; x < arr.length; x++){
            System.out.println(arr[x]);
        }
    }
    public Integer findMax(int[] arr){
        int max = arr[0];
        for(int x = 0; x < arr.length; x++){
            if(max < arr[x]){
                max = arr[x];
            }
        }
        return max;
    }
    public Float findAverage(int[] arr){
        float avg = 0;
        float sum = 0;
        for(int x = 0; x < arr.length; x++){
            sum += arr[x];
            System.out.println(sum);
        }
        avg = sum / arr.length;
        return avg;
    }
    public ArrayList oddArray(int[] arr){
        ArrayList<Integer> oddArr = new ArrayList<Integer>();
        for(int x = 0; x < arr.length; x++){
            if(x % 2 == 1){
                oddArr.add(x);
            }
        }
        return oddArr;
    }
    public Integer greaterThanY(int[] arr, int y){
        int counter = 0;
        for(int x = 0; x < arr.length; x++){
            if(arr[x] > y){
                counter++;
            }
        }
        System.out.println(counter);
        return counter;
    }
    public int[] squareValues(int[] arr){
        for(int x = 0; x < arr.length; x++){
            arr[x] *= arr[x];
        }
        for(int x : arr){
            System.out.println(x);
        }
        return arr;
    }
    public int[] removeNegatives(int[] arr){
        for(int x = 0; x < arr.length; x++){
            if(arr[x] < 0){
                arr[x] = 0;
            }
        }
        for(int x : arr){
            System.out.println(x);
        }
        return arr;
    }
    public ArrayList minMaxAvg(int[] arr){
        ArrayList<Integer> finalArray = new ArrayList<Integer>();
        int max = arr[0];
        float avg = 0;
        int sum = 0;
        int min = arr[0];
        for(int x = 0; x < arr.length; x++){
            if(max < arr[x]){
                max = arr[x];
            }
            if(min > arr[x]){
                min = arr[x];
            }
            sum += arr[x];
        }
        avg = sum / arr.length;
        finalArray.add(max);
        finalArray.add(min);
        finalArray.add(Math.round(avg));
        System.out.println(finalArray);
        return finalArray;
    }
    public int[] shiftArray(int[] arr){
        for(int x = 0; x < arr.length -1; x++){
            arr[x] = arr[x + 1];
        }
        arr[arr.length - 1] = 0;
        for(int v : arr){
            System.out.println(v);
        }
        return arr;
    }
}