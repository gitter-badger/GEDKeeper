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

using System;
using GKCommon.GEDCOM;
using GKCore.Interfaces;
using GKCore.Types;

namespace GKCore.Lists
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepositoryColumnType
    {
        rctName,
        rctChangeDate
    }

    /// <summary>
    /// 
    /// </summary>
    public sealed class RepositoryListColumns : ListColumns
    {
        protected override void InitColumnStatics()
        {
            this.AddStatic(LSID.LSID_Repository, DataType.dtString, 400, true);
            this.AddStatic(LSID.LSID_Changed, DataType.dtDateTime, 150, true);
        }

        public RepositoryListColumns() : base()
        {
            InitData(typeof(RepositoryColumnType));
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public sealed class RepositoryListMan : ListManager
    {
        private GEDCOMRepositoryRecord fRec;

        public override bool CheckFilter(ShieldState shieldState)
        {
            bool res = (this.QuickFilter == "*" || IsMatchesMask(this.fRec.RepositoryName, this.QuickFilter));

            res = res && base.CheckCommonFilter();

            return res;
        }

        public override void Fetch(GEDCOMRecord aRec)
        {
            this.fRec = (aRec as GEDCOMRepositoryRecord);
        }

        protected override object GetColumnValueEx(int colType, int colSubtype, bool isVisible)
        {
            switch (colType) {
                case 0:
                    return this.fRec.RepositoryName;
                case 1:
                    return this.fRec.ChangeDate.ChangeDateTime;
                default:
                    return null;
            }
        }

        public override Type GetColumnsEnum()
        {
            return typeof(RepositoryColumnType);
        }

        protected override ListColumns GetDefaultListColumns()
        {
            return new RepositoryListColumns();
        }

        public RepositoryListMan(GEDCOMTree tree) : base(tree)
        {
        }
    }
}
