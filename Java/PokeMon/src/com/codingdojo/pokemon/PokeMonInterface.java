package com.codingdojo.pokemon;

public interface PokeMonInterface {
    void createPokemon(String name, Integer health, String type);
    void attackPokemon(Pokemon pokemon);
    void pokemonInfo(Pokemon pokemon);
}
