using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Urvaius
public class RegionalMap5240Item : DaggerfallUnityItem
{
    public const int templateIndex = 5240;
    public RegionalMap5240Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5240Item).ToString();
        return data;
    }
}