using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Dragontail Mountains
public class RegionalMap5213Item : DaggerfallUnityItem
{
    public const int templateIndex = 5213;
    public RegionalMap5213Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5213Item).ToString();
        return data;
    }
}