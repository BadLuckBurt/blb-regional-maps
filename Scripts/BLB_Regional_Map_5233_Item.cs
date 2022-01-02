using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Santaki
public class RegionalMap5233Item : DaggerfallUnityItem
{
    public const int templateIndex = 5233;
    public RegionalMap5233Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5233Item).ToString();
        return data;
    }
}