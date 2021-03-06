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
using System.Windows.Forms;

using GKCommon.GEDCOM;
using GKCore;
using GKCore.Interfaces;
using GKCore.Lists;
using GKCore.Types;
using GKUI.Controls;

namespace GKUI.Dialogs
{
    /// <summary>
    /// 
    /// </summary>
    public partial class RecordSelectDlg : Form
    {
        private readonly IBaseWindow fBase;

        private GEDCOMRecordType fMode;
        private string fFilter;
        private TargetMode fTargetMode;
        private GKRecordsView fListRecords;

        public GEDCOMIndividualRecord Target { get; set; }
        public GEDCOMSex NeedSex { get; set; }
        public GEDCOMRecord ResultRecord { get; set; }


        public string Filter
        {
            get { return this.fFilter; }
            set { this.SetFilter(value); }
        }

        public GEDCOMRecordType Mode
        {
            get { return this.fMode; }
            set {
                this.fMode = value;
                this.DataRefresh();
            }
        }

        public TargetMode TargetMode
        {
            get { return this.fTargetMode; }
            set { this.fTargetMode = value; }
        }


        public RecordSelectDlg(IBaseWindow aBase)
        {
            this.InitializeComponent();
            
            this.fBase = aBase;
            this.fFilter = "*";
            
            // SetLang()
            this.Text = LangMan.LS(LSID.LSID_WinRecordSelect);
            this.btnCreate.Text = LangMan.LS(LSID.LSID_DlgAppend);
            this.btnSelect.Text = LangMan.LS(LSID.LSID_DlgSelect);
            this.btnCancel.Text = LangMan.LS(LSID.LSID_DlgCancel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }

        private void DataRefresh()
        {
            if (this.fListRecords != null)
            {
                this.fListRecords.Dispose();
                this.fListRecords = null;
            }
            
            this.fListRecords = GKUtils.CreateRecordsView(this.panList, this.fBase.Tree, this.fMode);
            this.fListRecords.ListMan.Filter.Clear();
            this.fListRecords.ListMan.QuickFilter = this.fFilter;

            if (this.fMode == GEDCOMRecordType.rtIndividual) {
                IndividualListFilter iFilter = (IndividualListFilter)this.fListRecords.ListMan.Filter;
                iFilter.Sex = this.NeedSex;
                
                if (this.fTargetMode == TargetMode.tmParent) {
                    this.fListRecords.ListMan.ExternalFilter = ChildSelectorHandler;
                }
            }

            this.fListRecords.UpdateContents(this.fBase.ShieldState, true, 1);
        }

        private static bool ChildSelectorHandler(GEDCOMRecord record)
        {
            GEDCOMIndividualRecord iRec = record as GEDCOMIndividualRecord;
            if (iRec == null) return false;

            return (iRec.ChildToFamilyLinks.Count == 0);
        }

        private void SetFilter(string value)
        {
            this.fFilter = value;
            if (this.fFilter == "") {
                this.fFilter = "*";
            } else if (this.fFilter != "*") {
                this.fFilter = "*" + this.fFilter + "*";
            }
            this.DataRefresh();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                this.ResultRecord = this.fListRecords.GetSelectedRecord();
                base.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                this.fBase.Host.LogWrite("TfmRecordSelect.btnSelect_Click(): " + ex.Message);
                this.ResultRecord = null;
                base.DialogResult = DialogResult.None;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                switch (this.fMode) {
                    case GEDCOMRecordType.rtIndividual:
                        {
                            GEDCOMIndividualRecord iRec = this.fBase.CreatePersonDialog(this.Target, this.fTargetMode, this.NeedSex);
                            if (iRec != null)
                            {
                                this.ResultRecord = iRec;
                                base.DialogResult = DialogResult.OK;
                            }
                            break;
                        }

                    case GEDCOMRecordType.rtFamily:
                        {
                            GEDCOMFamilyRecord famRec = null;

                            FamilyTarget famTarget;
                            famTarget = (this.fTargetMode == TargetMode.tmChildToFamily) ? FamilyTarget.Child : FamilyTarget.None;

                            if (this.fBase.ModifyFamily(ref famRec, famTarget, this.Target))
                            {
                                this.ResultRecord = famRec;
                                base.DialogResult = DialogResult.OK;
                            }
                            break;
                        }

                    case GEDCOMRecordType.rtNote:
                        {
                            GEDCOMNoteRecord noteRec = null;
                            if (this.fBase.ModifyNote(ref noteRec))
                            {
                                this.ResultRecord = noteRec;
                                base.DialogResult = DialogResult.OK;
                            }
                            break;
                        }

                    case GEDCOMRecordType.rtMultimedia:
                        {
                            GEDCOMMultimediaRecord mmRec = null;
                            if (this.fBase.ModifyMedia(ref mmRec))
                            {
                                this.ResultRecord = mmRec;
                                base.DialogResult = DialogResult.OK;
                            }
                            break;
                        }

                    case GEDCOMRecordType.rtSource:
                        {
                            GEDCOMSourceRecord sourceRec = null;
                            if (this.fBase.ModifySource(ref sourceRec))
                            {
                                this.ResultRecord = sourceRec;
                                base.DialogResult = DialogResult.OK;
                            }
                            break;
                        }

                    case GEDCOMRecordType.rtRepository:
                        {
                            GEDCOMRepositoryRecord repRec = null;
                            if (this.fBase.ModifyRepository(ref repRec))
                            {
                                this.ResultRecord = repRec;
                                base.DialogResult = DialogResult.OK;
                            }
                            break;
                        }

                    case GEDCOMRecordType.rtGroup:
                        {
                            GEDCOMGroupRecord groupRec = null;
                            if (this.fBase.ModifyGroup(ref groupRec))
                            {
                                this.ResultRecord = groupRec;
                                base.DialogResult = DialogResult.OK;
                            }
                            break;
                        }

                    case GEDCOMRecordType.rtTask:
                        {
                            GEDCOMTaskRecord taskRec = null;
                            if (this.fBase.ModifyTask(ref taskRec))
                            {
                                this.ResultRecord = taskRec;
                                base.DialogResult = DialogResult.OK;
                            }
                            break;
                        }

                    case GEDCOMRecordType.rtCommunication:
                        {
                            GEDCOMCommunicationRecord corrRec = null;
                            if (this.fBase.ModifyCommunication(ref corrRec))
                            {
                                this.ResultRecord = corrRec;
                                base.DialogResult = DialogResult.OK;
                            }
                            break;
                        }

                    case GEDCOMRecordType.rtLocation:
                        {
                            GEDCOMLocationRecord locRec = null;
                            if (this.fBase.ModifyLocation(ref locRec))
                            {
                                this.ResultRecord = locRec;
                                base.DialogResult = DialogResult.OK;
                            }
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                this.fBase.Host.LogWrite("TfmRecordSelect.btnCreate_Click(): " + ex.Message);
                this.ResultRecord = null;
                base.DialogResult = DialogResult.None;
            }
        }

        private void edFastFilter_TextChanged(object sender, EventArgs e)
        {
            this.SetFilter(this.txtFastFilter.Text);
        }
    }
}
