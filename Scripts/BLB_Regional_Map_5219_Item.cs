using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Ilessan Hills
public class RegionalMap5219Item : DaggerfallUnityItem
{
    public const int templateIndex = 5219;
    public RegionalMap5219Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5219Item).ToString();
        return data;
    }
}