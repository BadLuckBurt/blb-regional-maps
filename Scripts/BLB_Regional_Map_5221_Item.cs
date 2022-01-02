using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Kairou
public class RegionalMap5221Item : DaggerfallUnityItem
{
    public const int templateIndex = 5221;
    public RegionalMap5221Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5221Item).ToString();
        return data;
    }
}