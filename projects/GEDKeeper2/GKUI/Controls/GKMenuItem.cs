/*
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

using System.Windows.Forms;

namespace GKUI.Controls
{
    /// <summary>
    /// 
    /// </summary>
    public class GKMenuItem : MenuItem
    {
        public new int Tag;

        public GKMenuItem(string text, int tag) : base(text)
        {
            this.Tag = tag;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class GKToolStripMenuItem : ToolStripMenuItem
    {
        public new int Tag;

        public GKToolStripMenuItem(string text, int tag) : base(text)
        {
            this.Tag = tag;
        }
    }
}
