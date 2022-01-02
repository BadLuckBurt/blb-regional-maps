using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Betony
public class RegionalMap5207Item : DaggerfallUnityItem
{
    public const int templateIndex = 5207;
    public RegionalMap5207Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5207Item).ToString();
        return data;
    }
}