using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Bergama
public class RegionalMap5206Item : DaggerfallUnityItem
{
    public const int templateIndex = 5206;
    public RegionalMap5206Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5206Item).ToString();
        return data;
    }
}