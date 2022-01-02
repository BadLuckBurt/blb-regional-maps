using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Satakalaam
public class RegionalMap5234Item : DaggerfallUnityItem
{
    public const int templateIndex = 5234;
    public RegionalMap5234Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5234Item).ToString();
        return data;
    }
}