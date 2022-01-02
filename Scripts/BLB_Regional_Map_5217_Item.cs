using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Glenpoint
public class RegionalMap5217Item : DaggerfallUnityItem
{
    public const int templateIndex = 5217;
    public RegionalMap5217Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5217Item).ToString();
        return data;
    }
}