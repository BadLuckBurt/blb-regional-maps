using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Tigonus
public class RegionalMap5237Item : DaggerfallUnityItem
{
    public const int templateIndex = 5237;
    public RegionalMap5237Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5237Item).ToString();
        return data;
    }
}