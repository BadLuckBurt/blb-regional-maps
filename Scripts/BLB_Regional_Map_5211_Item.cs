using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Daggerfall
public class RegionalMap5211Item : DaggerfallUnityItem
{
    public const int templateIndex = 5211;
    public RegionalMap5211Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5211Item).ToString();
        return data;
    }
}