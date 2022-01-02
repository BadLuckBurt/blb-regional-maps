using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Abibon-Gora
public class RegionalMap5200Item : DaggerfallUnityItem
{
    public const int templateIndex = 5200;
    public RegionalMap5200Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5200Item).ToString();
        return data;
    }
}