using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Treasure : CollectibleBase
{
    [SerializeField] TMP_Text _treasureCount;

    protected override void Collect(Player player)
    {
        player.IncreaseTreasureCount(1);
        _treasureCount.text = player.GetTreasureCount().ToString();
    }
}
