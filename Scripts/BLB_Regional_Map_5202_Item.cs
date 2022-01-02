using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Alik'r Desert
public class RegionalMap5202Item : DaggerfallUnityItem
{
    public const int templateIndex = 5202;
    public RegionalMap5202Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5202Item).ToString();
        return data;
    }
}