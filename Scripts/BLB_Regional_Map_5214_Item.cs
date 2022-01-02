using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Dwynnen
public class RegionalMap5214Item : DaggerfallUnityItem
{
    public const int templateIndex = 5214;
    public RegionalMap5214Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5214Item).ToString();
        return data;
    }
}