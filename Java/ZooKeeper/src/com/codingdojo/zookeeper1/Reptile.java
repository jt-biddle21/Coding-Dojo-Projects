package com.codingdojo.zookeeper1;

public class Reptile {
    private int energyLevel;
    private String type;

    public Reptile(){
        energyLevel = 300;
    }

    public int getEnergyLevel() {
        return energyLevel;
    }

    public void setEnergyLevel(int energyLevel) {
        this.energyLevel = energyLevel;
    }

    public void setType(String type){
        this.type = type;
    }

    public String getType(){
        return type;
    }
}
