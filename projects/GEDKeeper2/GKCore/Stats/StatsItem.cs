﻿/*
 *  "GEDKeeper", the personal genealogical database editor.
 *  Copyright (C) 2009-2016 by Serg V. Zhdanovskih (aka Alchemist, aka Norseman).
 *
 *  This file is part of "GEDKeeper".
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace GKCore.Stats
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class StatsItem
    {
        public string Caption;
        public int Value;

        public bool IsCombo;
        public int ValF;
        public int ValM;

        public StatsItem(string caption, bool isCombo)
        {
            this.Caption = caption;
            this.Value = 0;
            this.IsCombo = isCombo;
        }

        public StatsItem(string caption, int value)
        {
            this.Caption = caption;
            this.Value = value;
            this.IsCombo = false;
        }

        public override string ToString()
        {
            return this.Caption;
        }
    }
}
