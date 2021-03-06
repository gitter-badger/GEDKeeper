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

using System.IO;

namespace GKCommon.GEDCOM
{
    public sealed class GEDCOMMultimediaLink : GEDCOMPointer
    {
        private GEDCOMList<GEDCOMFileReference> fFileReferences;

        public GEDCOMList<GEDCOMFileReference> FileReferences
        {
            get { return this.fFileReferences; }
        }

        public bool IsPointer
        {
            get { return (!string.IsNullOrEmpty(base.XRef)); }
        }

        public string Title
        {
            get { return base.GetTagStringValue("TITL"); }
            set { base.SetTagStringValue("TITL", value); }
        }

        public bool IsPrimary
        {
            get {
                GEDCOMTag tag = base.FindTag("_PRIM", 0);
                return (tag != null) && (tag.StringValue == "Y");
            }
            set {
                if (value) {
                    GEDCOMTag tag = base.FindTag("_PRIM", 0);
                    if (tag == null) {
                        tag = this.AddTag("_PRIM", "", null);
                    }
                    tag.StringValue = "Y";
                } else {
                    base.DeleteTag("_PRIM");
                }
            }
        }

        protected override void CreateObj(GEDCOMTree owner, GEDCOMObject parent)
        {
            base.CreateObj(owner, parent);
            this.SetName("OBJE");
            this.fFileReferences = new GEDCOMList<GEDCOMFileReference>(this);
        }

        protected override string GetStringValue()
        {
            string result = this.IsPointer ? base.GetStringValue() : this.fStringValue;
            return result;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.fFileReferences.Dispose();
            }
            base.Dispose(disposing);
        }

        public override GEDCOMTag AddTag(string tagName, string tagValue, TagConstructor tagConstructor)
        {
            GEDCOMTag result;

            if (tagName == "FILE") {
                result = this.fFileReferences.Add(new GEDCOMFileReference(base.Owner, this, tagName, tagValue));
            } else {
                result = base.AddTag(tagName, tagValue, tagConstructor);
            }

            return result;
        }

        public override void Clear()
        {
            base.Clear();
            this.fFileReferences.Clear();
        }

        public override bool IsEmpty()
        {
            bool result;
            if (this.IsPointer) {
                result = base.IsEmpty();
            } else {
                result = (base.Count == 0 && (this.fFileReferences.Count == 0));
            }
            return result;
        }

        public override string ParseString(string strValue)
        {
            this.fStringValue = "";
            return base.ParseString(strValue);
        }

        public override void ResetOwner(GEDCOMTree newOwner)
        {
            base.ResetOwner(newOwner);
            this.fFileReferences.ResetOwner(newOwner);
        }

        public override void SaveToStream(StreamWriter stream)
        {
            base.SaveToStream(stream);
            this.fFileReferences.SaveToStream(stream);
        }

        public GEDCOMMultimediaLink(GEDCOMTree owner, GEDCOMObject parent, string tagName, string tagValue) : base(owner, parent, tagName, tagValue)
        {
        }

        public new static GEDCOMTag Create(GEDCOMTree owner, GEDCOMObject parent, string tagName, string tagValue)
        {
            return new GEDCOMMultimediaLink(owner, parent, tagName, tagValue);
        }
    }
}
