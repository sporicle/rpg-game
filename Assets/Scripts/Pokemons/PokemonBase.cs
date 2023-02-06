using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemon", menuName = "Pokemon/Create new pokemon")]
public class PokemonBase : ScriptableObject
{
    [SerializeField] string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;

    [SerializeField] PokemonType type1;
    [SerializeField] PokemonType type2;

    // Base Stats
    [SerializeField] int maxHP;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int spAttack;
    [SerializeField] int spDefense;
    [SerializeField] int speed;

    public string Name {
        get { return name;}
    }

    public string Description {
        get { return description;}
    }

    public string FrontSprite {
        get { return frontSprite;}
    }

    public string BackSprite {
        get { return backSprite;}
    }

    public string Type1 {
        get { return type1;}
    }

    public string Type2 {
        get { return type2;}
    }

    public string MaxHP {
        get { return maxHP;}
    }

    public string Attack {
        get { return attack;}
    }

    public string Defense {
        get { return defense;}
    }

    public string SpAttack {
        get { return spAttack;}
    }

    public string SpDefense {
        get { return spDefense;}
    }

    public string Speed {
        get { return speed;}
    }

}

public enum PokemonType
{
    None,
    Normal,
    Fire,
    Water,
    Electric,
    Grass,
    Ice,
    Fighting,
    Poison, 
    Ground,
    Flying,
    Psychic,
    Bug,
    Rock,
    Ghost,
    Dragon
}