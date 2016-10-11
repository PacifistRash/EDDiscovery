﻿
using Newtonsoft.Json.Linq;

namespace EDDiscovery.EliteDangerous.JournalEvents
{
//    When written: when requesting a module is transferred from storage at another station
//Parameters:
//•	StorageSlot
//•	StoredItem
//•	ServerId
//•	TransferCost
//•	Ship
//•	ShipId

    public class JournalFetchRemoteModule : JournalEntry
    {
        public JournalFetchRemoteModule(JObject evt) : base(evt, JournalTypeEnum.FetchRemoteModule)
        {
            StorageSlot = Tools.GetStringDef(evt["StorageSlot"]);
            StoredItem = Tools.GetStringDef(evt["StoredItem"]);
            TransferCost = Tools.GetInt(evt["TransferCost"]);
            Ship = Tools.GetStringDef(evt["Ship"]);
            ShipId = Tools.GetInt(evt["ShipID"]);
            ServerId = Tools.GetInt(evt["ServerId"]);
        }
        public string StorageSlot { get; set; }
        public string StoredItem { get; set; }
        public int TransferCost { get; set; }
        public string Ship { get; set; }
        public int ShipId { get; set; }
        public int ServerId { get; set; }


        public override string DefaultRemoveItems()
        {
            return base.DefaultRemoveItems() + ";ShipID;ServerID";
        }
        public static System.Drawing.Bitmap Icon { get { return EDDiscovery.Properties.Resources.modulesell; } }

    }
}
