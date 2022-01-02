using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Myrkwasa
public class RegionalMap5228Item : DaggerfallUnityItem
{
    public const int templateIndex = 5228;
    public RegionalMap5228Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5228Item).ToString();
        return data;
    }
}