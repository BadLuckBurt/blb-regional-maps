using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

public class RegionalMapItem : DaggerfallUnityItem
{
    public const int templateIndex = 5200;
    public RegionalMapItem(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMapItem).ToString();
        return data;
    }
}