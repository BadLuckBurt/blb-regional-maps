using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Kambria
public class RegionalMap5222Item : DaggerfallUnityItem
{
    public const int templateIndex = 5222;
    public RegionalMap5222Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5222Item).ToString();
        return data;
    }
}