using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Orsinium Area
public class RegionalMap5230Item : DaggerfallUnityItem
{
    public const int templateIndex = 5230;
    public RegionalMap5230Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5230Item).ToString();
        return data;
    }
}