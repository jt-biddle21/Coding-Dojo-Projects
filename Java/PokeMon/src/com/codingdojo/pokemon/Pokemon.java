package com.codingdojo.pokemon;
import java.lang.*;

class Pokemon implements PokeMonInterface {
    private String name;
    private Integer health;
    private String type;
    private static int count;

    public Pokemon(){
        name = "";
        health = 0;
        type = "";
    }

    public void createPokemon(String name, Integer health, String type) {
        this.name = name;
        this.health = health;
        this.type = type;
        count++;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getType() {
        return type;
    }

    public void setType(String type) {
        this.type = type;
    }

    public Integer getHealth() {

        return health;
    }

    public void setHealth(Integer health) {
        this.health = health;
    }

    public void attackPokemon(Pokemon pokemon){
    }
    public void pokemonInfo(Pokemon pokemon){
    }
    public Integer getCount(){
        System.out.println("Amount of Pokemon: " + count + "\n");
        return count;
    }
}