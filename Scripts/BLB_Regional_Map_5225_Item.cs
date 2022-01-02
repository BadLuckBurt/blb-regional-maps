using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Lainlyn
public class RegionalMap5225Item : DaggerfallUnityItem
{
    public const int templateIndex = 5225;
    public RegionalMap5225Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5225Item).ToString();
        return data;
    }
}