using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Northmoor
public class RegionalMap5229Item : DaggerfallUnityItem
{
    public const int templateIndex = 5229;
    public RegionalMap5229Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5229Item).ToString();
        return data;
    }
}