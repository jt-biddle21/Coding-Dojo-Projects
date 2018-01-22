package com.codingdojo.zookeeper1;

public class Dragon extends Reptile {
    private int x = getEnergyLevel();
    private String type = getType();

    public void eatHumans() {
        System.out.println("Oh... Just munchin' on some humans...");
        if (x >= 275) {
            x = 300;
            setEnergyLevel(x);
            System.out.println("the so- well, never mind, just increase its energy by 25. Energy back to 100!");
        } else {
            x += 25;
            setEnergyLevel(x);
            System.out.println("the so- well, never mind, just increase its energy by 25. +25... Energy now at " + x);
        }
    }

    public void fly() {
        if (x <= 50) {
            System.out.println("Woosh, Woosh, Woosh, Woosh, *splat*");
            x = 0;
            setEnergyLevel(x);
            System.out.println("That took all the dragon had left... Literally all... *dragon dies*");
        } else {
            System.out.println("Woosh, Woosh, Woosh, Woosh! And away it goes!");
            x -= 50;
            setEnergyLevel(x);
            System.out.println("Successfull take-off! -50... Energy now at " + x);
        }
    }

    public void attackTown() {
        System.out.println("Hey");
        System.out.println("There goes another town, burnt up in flames.");
        if (x <= 100) {
            x = 0;
            System.out.println("Attacking that town killed the dragon.");
        } else {
            x -= 100;
            System.out.println("Energy level now at " + x);
        }

    }
}
