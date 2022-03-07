using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Pokemon", menuName = "Content/Create New Pokemon")]
public class Pokemon : ScriptableObject
{
    [SerializeField] int dexNo = 0;
    [SerializeField] string pokeName = "Pikachu";
    [SerializeField] Sprite sprite;
    [SerializeField] float height = 0; // meters
    [SerializeField] float weight = 0; // pounds
    [SerializeField, TextArea(1, 5)] string description = "Cool";
    [SerializeField] Type[] type;
    [SerializeField] int baseHp = 0;
    [SerializeField] Rank rank;
    [SerializeField] Ability ability;

    // STATS
    [SerializeField] int str = 1;
    int str_l = 4;

    [SerializeField] int dex = 1;
    int dex_l = 4;

    [SerializeField] int vit = 1;
    int vit_l = 4;

    [SerializeField] int spe = 1;
    int spe_l = 4;

    [SerializeField] int ins = 1;
    int ins_l = 4;

    // TRACKERS
    int totalHp;
    int currentHp = 0;

    // MOVES LIST
    [SerializeField] Move[] moves;

    private void OnEnable()
    {
        totalHp = baseHp + vit;
        currentHp = totalHp;
    }
}
