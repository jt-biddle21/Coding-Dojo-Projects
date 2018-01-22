package com.codingdojo.zookeeper1;

public class Mammal {
    private int energyLevel;

    public Mammal() {
        energyLevel = 100;
    }
    public Integer getEnergyLevel(){
        return energyLevel;
    }

    public void setEnergyLevel(int energyLevel) {
        this.energyLevel = energyLevel;
    }
}
