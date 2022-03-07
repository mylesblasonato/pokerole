using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Rank", menuName = "Content/Create New Level Rank")]
public class Rank : ScriptableObject
{
    [SerializeField] int extraPointsToDistributeOnStats = 2;
    [SerializeField] int extraPointsToDistributeOnSocial = 2;
    [SerializeField] int extraSkillPointsToDistribute = 4;
    [SerializeField] int skillLimitIncrease = 2;
    [SerializeField] int maxTargetOfPokemon = 2; // including itself
    [SerializeField, TextArea(1, 5)] string description = "please enter...";

    // ACHIEVEMENTS
    [SerializeField, TextArea(1, 5)] string[] achievements;
    [SerializeField] List<bool> achievementsCompleted = new List<bool>();

    private void OnValidate()
    {
        
    }

    [ContextMenu("Set Achievements")]
    void SetAchievements()
    {
        achievementsCompleted.Clear();
        foreach (var achievement in achievements)
        {
            achievementsCompleted.Add(false);
        }
    }
}