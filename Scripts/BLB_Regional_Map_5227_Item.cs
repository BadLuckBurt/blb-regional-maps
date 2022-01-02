using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Mournoth
public class RegionalMap5227Item : DaggerfallUnityItem
{
    public const int templateIndex = 5227;
    public RegionalMap5227Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5227Item).ToString();
        return data;
    }
}