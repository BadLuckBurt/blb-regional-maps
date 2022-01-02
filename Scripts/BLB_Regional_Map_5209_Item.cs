using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Cybiades
public class RegionalMap5209Item : DaggerfallUnityItem
{
    public const int templateIndex = 5209;
    public RegionalMap5209Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5209Item).ToString();
        return data;
    }
}