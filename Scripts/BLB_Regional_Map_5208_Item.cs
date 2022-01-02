using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Bhoriane
public class RegionalMap5208Item : DaggerfallUnityItem
{
    public const int templateIndex = 5208;
    public RegionalMap5208Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5208Item).ToString();
        return data;
    }
}