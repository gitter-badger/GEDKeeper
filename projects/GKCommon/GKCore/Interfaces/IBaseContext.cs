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

using System.Drawing;
using System.IO;

using GKCommon;
using GKCommon.GEDCOM;
using GKCommon.SmartGraph;
using GKCore.Types;

namespace GKCore.Interfaces
{
    public interface IBaseContext
    {
        GEDCOMTree Tree { get; }

        void Clear();
        void FileLoad(string fileName, string password = null);
        void FileSave(string fileName, string password = null);

        // Data search
        GEDCOMSourceRecord FindSource(string sourceName);
        void GetSourcesList(StringList sources);

        // Data manipulation
        GEDCOMCustomEvent CreateEventEx(GEDCOMRecordWithEvents aRec, string evSign, string evDate, string evPlace);
        GEDCOMIndividualRecord CreatePersonEx(string iName, string iPatronymic, string iSurname, GEDCOMSex iSex, bool birthEvent);

        // Individual utils
        bool IsChildless(GEDCOMIndividualRecord iRec);
        int FindBirthYear(GEDCOMIndividualRecord iRec);
        int FindDeathYear(GEDCOMIndividualRecord iRec);
        int GetRelativeYear(GEDCOMRecordWithEvents evsRec, string evSign);
        
        // Patriarchs search
        ExtList<PatriarchObj> GetPatriarchsList(int gensMin, bool datesCheck);
        ExtList<PatriarchObj> GetPatriarchsLinks(int gensMin, bool datesCheck, bool loneSuppress);
        Graph GetPatriarchsGraph(int gensMin, bool datesCheck, bool loneSuppress = true);
        
        // Multimedia support
        bool CheckBasePath();
        MediaStoreType GetStoreType(GEDCOMFileReference fileReference, ref string fileName);
        void MediaLoad(GEDCOMFileReference fileReference, out Stream stream, bool throwException);
        void MediaLoad(GEDCOMFileReference fileReference, ref string fileName);
        bool MediaSave(GEDCOMFileReference fileReference, string fileName, MediaStoreType storeType);
        Bitmap BitmapLoad(GEDCOMFileReference fileReference, int thumbWidth, int thumbHeight, bool throwException);
        Bitmap GetPrimaryBitmap(GEDCOMIndividualRecord iRec, int thumbWidth, int thumbHeight, bool throwException);
    }
}
