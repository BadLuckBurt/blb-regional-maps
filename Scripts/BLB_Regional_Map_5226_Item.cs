using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Menevia
public class RegionalMap5226Item : DaggerfallUnityItem
{
    public const int templateIndex = 5226;
    public RegionalMap5226Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5226Item).ToString();
        return data;
    }
}