package com.codingdojo.pokemon;

public class Pokedex extends PokemonAbstract{
    public void pokemonInfo(Pokemon pokemon) {
        System.out.println("Name: " + pokemon.getName() + "\nHealth: " + pokemon.getHealth() + "\nType: " + pokemon.getType());
    }
}