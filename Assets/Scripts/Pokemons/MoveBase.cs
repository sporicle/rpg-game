using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Move/Create new move")]
public class MoveBase : ScriptableObject
{
    [SerializeField] string name;

    [TextArea]
    [SerializeField] string description;
    [SerializeField] PokemonType type;
    [SerializeField] int power;
    [SerializeField] int accuracy;
    [SerializeField] int pp;

    public string Name
    {
        get => name;
    }
    public string Description
    {
        get => description;
    }

    public PokemonType Type
    {
        get => type;
    }

    public int Power 
    {
        get => power;
    }

    public int Accuracy 
    {
        get => accuracy;
    }
    public int Pp 
    {
        get => pp;
    }

}
