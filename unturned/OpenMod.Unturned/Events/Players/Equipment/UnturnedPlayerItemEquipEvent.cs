﻿using OpenMod.Unturned.Entities;
using SDG.Unturned;

namespace OpenMod.Unturned.Events.Players.Equipment
{
    public class UnturnedPlayerItemEquipEvent : UnturnedPlayerEquipEvent
    {
        public UnturnedPlayerItemEquipEvent(UnturnedPlayer player, Item item) : base(player, item)
        {

        }
    }
}
