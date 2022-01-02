using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Ayasofya
public class RegionalMap5205Item : DaggerfallUnityItem
{
    public const int templateIndex = 5205;
    public RegionalMap5205Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5205Item).ToString();
        return data;
    }
}