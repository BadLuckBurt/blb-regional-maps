using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Tulune
public class RegionalMap5239Item : DaggerfallUnityItem
{
    public const int templateIndex = 5239;
    public RegionalMap5239Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5239Item).ToString();
        return data;
    }
}