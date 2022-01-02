using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Antiphyllos
public class RegionalMap5204Item : DaggerfallUnityItem
{
    public const int templateIndex = 5204;
    public RegionalMap5204Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5204Item).ToString();
        return data;
    }
}