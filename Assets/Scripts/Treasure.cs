using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Treasure : CollectibleBase
{
    //[SerializeField] Text _treasureText = null;
    protected override void Collect(Player player)
    {
        player.IncreaseTreasureCount(1);
        //_treasureText.text = player.GetTreasureCount().ToString();
    }
}
