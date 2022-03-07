using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Move", menuName = "Content/Create New Move")]
public class Move : ScriptableObject
{
    [SerializeField] Rank requiredRank;
}