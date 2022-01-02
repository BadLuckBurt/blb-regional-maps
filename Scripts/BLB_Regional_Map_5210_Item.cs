using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Daenia
public class RegionalMap5210Item : DaggerfallUnityItem
{
    public const int templateIndex = 5210;
    public RegionalMap5210Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5210Item).ToString();
        return data;
    }
}