using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Glenumbra Moors
public class RegionalMap5218Item : DaggerfallUnityItem
{
    public const int templateIndex = 5218;
    public RegionalMap5218Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5218Item).ToString();
        return data;
    }
}