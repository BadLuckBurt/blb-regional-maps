using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Sentinel
public class RegionalMap5235Item : DaggerfallUnityItem
{
    public const int templateIndex = 5235;
    public RegionalMap5235Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5235Item).ToString();
        return data;
    }
}