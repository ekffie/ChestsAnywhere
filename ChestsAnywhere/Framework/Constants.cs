﻿using StardewModdingAPI;
using StardewValley;

namespace Pathoschild.Stardew.ChestsAnywhere.Framework
{
    /// <summary>Constant mod values.</summary>
    internal static class Constant
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The minimum supported version of SMAPI.</summary>
        public static readonly Version MinimumApiVersion = new Version(1, 3, 0, null);

        /// <summary>The number of rows in an inventory grid.</summary>
        public const int SlotRows = 3;

        /// <summary>The number of columns in an inventory grid.</summary>
        public const int SlotColumns = 12;

        /// <summary>The maximum number of elements in an inventory.</summary>
        public const int SlotCount = Constant.SlotRows * Constant.SlotColumns;

        /// <summary>The inventory slot size for the current zoom level.</summary>
        public static int SlotSize => Game1.tileSize;
    }
}
