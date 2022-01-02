using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Wrothgarian Mountains
public class RegionalMap5242Item : DaggerfallUnityItem
{
    public const int templateIndex = 5242;
    public RegionalMap5242Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5242Item).ToString();
        return data;
    }
}