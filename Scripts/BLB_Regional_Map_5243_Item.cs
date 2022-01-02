using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Ykalon
public class RegionalMap5243Item : DaggerfallUnityItem
{
    public const int templateIndex = 5243;
    public RegionalMap5243Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5243Item).ToString();
        return data;
    }
}