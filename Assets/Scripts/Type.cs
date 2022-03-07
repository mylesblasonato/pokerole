using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Type", menuName = "Content/Create New Pokemon Type")]
public class Type : ScriptableObject
{
    [SerializeField] List<Type> superEffectiveAgainst = new List<Type>();
    [SerializeField] List<Type> notEffectiveAgainst = new List<Type>();
    [SerializeField] List<Type> noDamageAgainst = new List<Type>();
}