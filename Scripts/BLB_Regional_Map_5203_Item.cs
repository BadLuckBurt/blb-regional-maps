using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Anticlere
public class RegionalMap5203Item : DaggerfallUnityItem
{
    public const int templateIndex = 5203;
    public RegionalMap5203Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5203Item).ToString();
        return data;
    }
}