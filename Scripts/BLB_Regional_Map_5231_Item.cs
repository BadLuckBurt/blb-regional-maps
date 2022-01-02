using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Phrygias
public class RegionalMap5231Item : DaggerfallUnityItem
{
    public const int templateIndex = 5231;
    public RegionalMap5231Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5231Item).ToString();
        return data;
    }
}