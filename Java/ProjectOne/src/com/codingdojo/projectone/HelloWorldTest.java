package com.codingdojo.projectone;

import java.lang.*;

public class HelloWorldTest {
    public static void main(String[] args) throws InterruptedException {
        System.out.println("Blast off in...");
        int x = 10;
        Thread.sleep(1000);
        while (x > 0){
            System.out.println(x);
            Thread.sleep(1000);
            x--;
        }
        System.out.println("BLAST OFF!");
        HelloWorld.sayAgain();
    }
}
