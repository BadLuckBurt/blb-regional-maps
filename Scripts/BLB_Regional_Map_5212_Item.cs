using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Dak'fron
public class RegionalMap5212Item : DaggerfallUnityItem
{
    public const int templateIndex = 5212;
    public RegionalMap5212Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5212Item).ToString();
        return data;
    }
}