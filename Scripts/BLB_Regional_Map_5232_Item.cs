using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Pothago
public class RegionalMap5232Item : DaggerfallUnityItem
{
    public const int templateIndex = 5232;
    public RegionalMap5232Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5232Item).ToString();
        return data;
    }
}