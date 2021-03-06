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

using System;

namespace GKCommon.GEDCOM
{
    public sealed class GEDCOMChangeDate : GEDCOMTag
    {
        public GEDCOMDateExact ChangeDate
        {
            get {
                return base.TagClass("DATE", GEDCOMDateExact.Create) as GEDCOMDateExact;
            }
        }

        public GEDCOMTime ChangeTime
        {
            get {
                GEDCOMTag dateTag = this.ChangeDate;
                return dateTag.TagClass("TIME", GEDCOMTime.Create) as GEDCOMTime;
            }
        }

        public DateTime ChangeDateTime
        {
            get {
                return this.ChangeDate.Date + this.ChangeTime.Value;
            }
            set {
                this.ChangeDate.Date = value.Date;
                this.ChangeTime.Value = value.TimeOfDay;
            }
        }

        public GEDCOMNotes Notes
        {
            get { return base.TagClass("NOTE", GEDCOMNotes.Create) as GEDCOMNotes; }
        }

        protected override void CreateObj(GEDCOMTree owner, GEDCOMObject parent)
        {
            base.CreateObj(owner, parent);
            this.SetName("CHAN");
        }

        public override GEDCOMTag AddTag(string tagName, string tagValue, TagConstructor tagConstructor)
        {
            GEDCOMTag result;

            if (tagName == "DATE")
            {
                result = base.AddTag(tagName, tagValue, GEDCOMDateExact.Create);
            }
            else if (tagName == "NOTE")
            {
                result = base.AddTag(tagName, tagValue, GEDCOMNotes.Create);
            }
            else
            {
                result = base.AddTag(tagName, tagValue, tagConstructor);
            }

            return result;
        }

        public override string ToString()
        {
            DateTime cdt = this.ChangeDateTime;
            string result = ((cdt.Ticks == 0) ? "" : cdt.ToString("yyyy.MM.dd HH:mm:ss", null));
            return result;
        }

        public GEDCOMChangeDate(GEDCOMTree owner, GEDCOMObject parent, string tagName, string tagValue) : base(owner, parent, tagName, tagValue)
        {
        }

        public new static GEDCOMTag Create(GEDCOMTree owner, GEDCOMObject parent, string tagName, string tagValue)
        {
            return new GEDCOMChangeDate(owner, parent, tagName, tagValue);
        }
    }
}
