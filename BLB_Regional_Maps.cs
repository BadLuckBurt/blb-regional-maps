using System;
using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop.Game;
using DaggerfallWorkshop.Game.Utility.ModSupport;
using DaggerfallWorkshop.Utility.AssetInjection;
using DaggerfallWorkshop.Game.UserInterface;
using DaggerfallWorkshop.Game.UserInterfaceWindows;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Utility;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Serialization;
using DaggerfallConnect.Utility;

    //this class initializes the mod.
    public class RegionalMapModLoader : MonoBehaviour
    {
        public static Mod mod;
        static Mod HiddenMapLocations;
        public static GameObject go;

        //public const string HiddenMapLocationsGUID = "7e487a8a-71e9-4187-990f-22012c11a04e";

        //like in the last example, this is used to setup the Mod.  This gets called at Start state.
        [Invoke]
        public static void InitAtStartState(InitParams initParams)
        {
            mod = initParams.Mod;
            go = new GameObject(mod.Title);
            Debug.Log("Started setup of : " + mod.Title);

            //HiddenMapLocations = ModManager.Instance.GetModFromGUID(HiddenMapLocationsGUID);
            //if (HiddenMapLocations != null && HiddenMapLocations.Enabled)
            //{
                int startIndex = 5200;
                int index;
                for(int i = 0; i < 45; i++) {
                    index = startIndex + i;
                    DaggerfallUnity.Instance.ItemHelper.RegisterItemUseHandler(index, UseRegionalMap);
                    DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(index, ItemGroups.Maps);
                }   
            //}
            mod.IsReady = true;
        }

        [Invoke(StateManager.StateTypes.Game)]
        public static void InitAtGameState(InitParams initParams)
        {

        }

        private static bool UseRegionalMap(DaggerfallUnityItem item, ItemCollection collection)
        {
            string regionName = GetRegionNameFromTemplateIndex(item.TemplateIndex);
            int regionIndex = DaggerfallUnity.Instance.ContentReader.MapFileReader.GetRegionIndex(regionName);
            DFRegion region = DaggerfallUnity.Instance.ContentReader.MapFileReader.GetRegion(regionIndex);
            Debug.Log("Region location count: " + region.LocationCount.ToString());
            //Debug.Log("Retrieved region info for " + region.Name);
            for (int i = 0; i < region.LocationCount; i++)
            {
                DFLocation location = DaggerfallUnity.Instance.ContentReader.MapFileReader.GetLocation(regionIndex, i);
                Debug.Log("Region: " + regionName + " - Location: " + location.Name);
                GameManager.Instance.PlayerGPS.DiscoverLocation(regionName, location.Name);
                HiddenMapLocationsMod.AddMapSummaryFromLocation(location);
                //locBlocks[dfLoc.Name] = dfLoc.Exterior.ExteriorData.BlockNames;
            }
            return true;
        }

        private static string GetRegionNameFromTemplateIndex(int templateIndex)
        {
            string regionName = "";
            switch(templateIndex) {
                case 5200:
                    regionName = "Abibon-Gora";
                    break;
                case 5201:
                    regionName = "Alcaire";
                    break;
                case 5202:
                    regionName = "Alik'r Desert";
                    break;
                case 5203:
                    regionName = "Anticlere";
                    break;
                case 5204:
                    regionName = "Antiphyllos";
                    break;
                case 5205:
                    regionName = "Ayasofya";
                    break;
                case 5206:
                    regionName = "Bergama";
                    break;
                case 5207:
                    regionName = "Betony";
                    break;
                case 5208:
                    regionName = "Bhoriane";
                    break;
                case 5209:
                    regionName = "Cybiades";
                    break;
                case 5210:
                    regionName = "Daenia";
                    break;
                case 5211:
                    regionName = "Daggerfall";
                    break;
                case 5212:
                    regionName = "Dak'fron";
                    break;
                case 5213:
                    regionName = "Dragontail Mountains";
                    break;
                case 5214:
                    regionName = "Dwynnen";
                    break;
                case 5215:
                    regionName = "Ephesus";
                    break;
                case 5216:
                    regionName = "Gavaudon";
                    break;
                case 5217:
                    regionName = "Glenpoint";
                    break;
                case 5218:
                    regionName = "Glenumbra Moors";
                    break;
                case 5219:
                    regionName = "Ilessan Hills";
                    break;
                case 5220:
                    regionName = "Isle of Balfiera";
                    break;
                case 5221:
                    regionName = "Kairou";
                    break;
                case 5222:
                    regionName = "Kambria";
                    break;
                case 5223:
                    regionName = "Koegria";
                    break;
                case 5224:
                    regionName = "Kozanset";
                    break;
                case 5225:
                    regionName = "Lainlyn";
                    break;
                case 5226:
                    regionName = "Menevia";
                    break;
                case 5227:
                    regionName = "Mournoth";
                    break;
                case 5228:
                    regionName = "Myrkwasa";
                    break;
                case 5229:
                    regionName = "Northmoor";
                    break;
                case 5230:
                    regionName = "Orsinium Area";
                    break;
                case 5231:
                    regionName = "Phrygias";
                    break;
                case 5232:
                    regionName = "Pothago";
                    break;
                case 5233:
                    regionName = "Santaki";
                    break;
                case 5234:
                    regionName = "Satakalaam";
                    break;
                case 5235:
                    regionName = "Sentinel";
                    break;
                case 5236:
                    regionName = "Shalgora";
                    break;
                case 5237:
                    regionName = "Tigonus";
                    break;
                case 5238:
                    regionName = "Totambu";
                    break;
                case 5239:
                    regionName = "Tulune";
                    break;
                case 5240:
                    regionName = "Urvaius";
                    break;
                case 5241:
                    regionName = "Wayrest";
                    break;
                case 5242:
                    regionName = "Wrothgarian Mountains";
                    break;
                case 5243:
                    regionName = "Ykalon";
                    break;
            };
            return regionName;
        }
    }