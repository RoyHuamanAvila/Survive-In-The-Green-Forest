using UnityEngine;
using System.Collections;
public class PokeMove : ScriptableObject {
    public string nameMove;
    public int potencia;
    public float range;
    public CategoryMove category;
} 
public enum CategoryMove{
    inArea, melee, proyectil
}