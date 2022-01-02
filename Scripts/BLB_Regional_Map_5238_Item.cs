using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Totambu
public class RegionalMap5238Item : DaggerfallUnityItem
{
    public const int templateIndex = 5238;
    public RegionalMap5238Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5238Item).ToString();
        return data;
    }
}