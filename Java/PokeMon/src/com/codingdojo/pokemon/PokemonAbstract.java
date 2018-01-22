package com.codingdojo.pokemon;

public abstract class PokemonAbstract implements PokeMonInterface{
    public void createPokemon(String name, Integer health, String type){
    }
    public void attackPokemon(Pokemon pokemon){
        int x = pokemon.getHealth();
        x -= 10;
        pokemon.setHealth(x);
    }
}
