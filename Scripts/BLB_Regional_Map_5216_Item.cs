using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Gavaudon
public class RegionalMap5216Item : DaggerfallUnityItem
{
    public const int templateIndex = 5216;
    public RegionalMap5216Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5216Item).ToString();
        return data;
    }
}