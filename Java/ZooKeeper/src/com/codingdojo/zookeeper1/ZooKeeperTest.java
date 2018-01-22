package com.codingdojo.zookeeper1;

import java.util.Scanner;

public class ZooKeeperTest {
    public static void main(String[] args) throws InterruptedException {
        String input;
        Scanner sc = new Scanner(System.in);
        System.out.println("You can create a Dragon or a Gorilla, Just type one.");
        input = sc.nextLine();
        if(input.equals("Dragon")){
            Dragon kavilik = new Dragon();
            kavilik.attackTown();
            kavilik.eatHumans();
            kavilik.fly();
        }
        else if(input.equals("Gorilla")){
            Gorilla hefe = new Gorilla();
            hefe.throwSomething();
            hefe.throwSomething();
            hefe.throwSomething();
            hefe.eatBananas();
            hefe.eatBananas();
            hefe.climb();
        }
        else{
            System.out.println("Invalid creature...");
        }
    }
}

