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

using System.Windows.Forms;

using GKCommon.GEDCOM;
using GKCore.Interfaces;
using GKUI.Controls;

namespace GKUI.Sheets
{
    public abstract class GKCustomSheet : GKSheetList
    {
        private readonly IBaseEditor fBaseEditor;
        private IGEDCOMListEnumerator fDataList;

        public IGEDCOMListEnumerator DataList
        {
            get { return this.fDataList; }
            set {
                this.fDataList = value;
                this.UpdateSheet();
            }
        }

        public IBaseEditor Editor
        {
            get { return this.fBaseEditor; }
        }
        
        protected GKCustomSheet(IBaseEditor baseEditor, Control owner) : base(owner)
        {
            this.fBaseEditor = baseEditor;
            this.fDataList = null;
        }

        public abstract void UpdateSheet();
    }
}
