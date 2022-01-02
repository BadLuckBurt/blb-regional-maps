using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

//Map for Isle of Balfiera
public class RegionalMap5220Item : DaggerfallUnityItem
{
    public const int templateIndex = 5220;
    public RegionalMap5220Item(){}

    public override ItemData_v1 GetSaveData()
    {
        ItemData_v1 data = base.GetSaveData();
        data.className = typeof(RegionalMap5220Item).ToString();
        return data;
    }
}