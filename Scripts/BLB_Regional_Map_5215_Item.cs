using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Ephesus
public class RegionalMap5215Item : DaggerfallUnityItem
{
    public const int templateIndex = 5215;
    public RegionalMap5215Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5215Item).ToString();
        return data;
    }
}