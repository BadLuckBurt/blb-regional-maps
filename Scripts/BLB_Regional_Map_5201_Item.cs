using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Alcaire
public class RegionalMap5201Item : DaggerfallUnityItem
{
    public const int templateIndex = 5201;
    public RegionalMap5201Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5201Item).ToString();
        return data;
    }
}