using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Wayrest
public class RegionalMap5241Item : DaggerfallUnityItem
{
    public const int templateIndex = 5241;
    public RegionalMap5241Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5241Item).ToString();
        return data;
    }
}