using System.Collections.Generic;

namespace Pokemon{
    public class Pokemon{
        public string name;
        public int weight;
        public List<PokeTypes> types;
    }

    public class PokeTypes{
        public TypePropertiss type;
    }

    public class TypePropertiss{
        public string url;
        public string name;
    }
}