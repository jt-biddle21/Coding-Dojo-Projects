package com.codingdojo.pokemon;

public class PokemonTest {
    public static void main(String[] args) {
        Pokedex poke1 = new Pokedex();
        Pokemon pokemon1 = new Pokemon();
        pokemon1.createPokemon("Pikachu", 100, "Electric");
        poke1.pokemonInfo(pokemon1);
        pokemon1.getCount();
        pokemon1.createPokemon("Squirtle", 75, "Water");
        poke1.pokemonInfo(pokemon1);
        pokemon1.getCount();
    }
}
