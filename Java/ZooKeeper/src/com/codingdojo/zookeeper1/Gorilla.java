package com.codingdojo.zookeeper1;

public class Gorilla extends Mammal {
    int x = getEnergyLevel();
    public void throwSomething()  throws InterruptedException {
        System.out.println("Mr. Gorilla is throwing some 'stinky' fit...");
        if (x <= 5){
            System.out.println("Gorilla is now dead. Too bad...");

        }
        else {
            x -= 5;
            setEnergyLevel(x);
            Thread.sleep(1000);
            System.out.println("Took a lot out him. His energy level is at " + x);
        }
    }
    public void eatBananas()  throws InterruptedException {
        System.out.println("Mr. Gorilla eats some bananas, and loves it.");
        if (x >= 90){
            x = 100;
            setEnergyLevel(x);
            System.out.println("Back to 100! Mr. Gorilla is ready to rock and roll!");
        }
        else{
            x += 10;
            setEnergyLevel(x);
            Thread.sleep(1000);
            System.out.println("He's super satisfied! +10... Energy level at " + x);
        }
    }
    public void climb(){
        System.out.println("Mr. Gorilla starts climbing a tree!");
        if (x <= 10){
            System.out.println("Gorilla is now dead. Too bad...");
        }
        else {
            x -= 10;
            setEnergyLevel(x);
            System.out.println("That was a tall tree. -10... Energy level at " + x);
        }
    }

}
