using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Koegria
public class RegionalMap5223Item : DaggerfallUnityItem
{
    public const int templateIndex = 5223;
    public RegionalMap5223Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5223Item).ToString();
        return data;
    }
}