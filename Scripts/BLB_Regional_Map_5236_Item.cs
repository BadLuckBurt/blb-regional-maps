using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Shalgora
public class RegionalMap5236Item : DaggerfallUnityItem
{
    public const int templateIndex = 5236;
    public RegionalMap5236Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5236Item).ToString();
        return data;
    }
}