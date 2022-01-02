using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Kozanset
public class RegionalMap5224Item : DaggerfallUnityItem
{
    public const int templateIndex = 5224;
    public RegionalMap5224Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5224Item).ToString();
        return data;
    }
}