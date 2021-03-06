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

using GKCommon;
using GKCommon.GEDCOM;
using GKCore;
using GKCore.Interfaces;
using GKCore.Types;
using GKUI.Charts;
using GKUI.Controls;

namespace GKUI.Dialogs
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TreeFilterDlg : Form
    {
        private readonly IBaseWindow fBase;
        private readonly GKSheetList fPersonsList;
        
        private ChartFilter fFilter;
        private string fTemp;

        public IBaseWindow Base
        {
            get	{ return this.fBase; }
        }

        public ChartFilter Filter
        {
            get	{ return this.fFilter; }
            set	{ this.fFilter = value;	}
        }

        private void ListModify(object sender, ModifyEventArgs eArgs)
        {
            if (sender == this.fPersonsList) {
                GEDCOMIndividualRecord iRec = eArgs.ItemData as GEDCOMIndividualRecord;

                switch (eArgs.Action)
                {
                    case RecordAction.raAdd:
                        iRec = this.Base.SelectPerson(null, TargetMode.tmNone, GEDCOMSex.svNone);
                        if (iRec != null) {
                            this.fTemp = this.fTemp + iRec.XRef + ";";
                        }
                        break;

                    case RecordAction.raDelete:
                        if (iRec != null) {
                            this.fTemp = this.fTemp.Replace(iRec.XRef + ";", "");
                        }
                        break;
                }
            }

            this.UpdateControls();
        }

        private void UpdateControls()
        {
            switch (this.fFilter.BranchCut) {
                case ChartFilter.BranchCutType.Persons:
                    this.rbCutPersons.Checked = true;
                    break;

                case ChartFilter.BranchCutType.Years:
                    this.rbCutYears.Checked = true;
                    break;

                case ChartFilter.BranchCutType.None:
                    this.rbCutNone.Checked = true;
                    break;
            }

            this.edYear.Enabled = (this.fFilter.BranchCut == ChartFilter.BranchCutType.Years);
            this.fPersonsList.Enabled = (this.fFilter.BranchCut == ChartFilter.BranchCutType.Persons);
            this.edYear.Text = this.fFilter.BranchYear.ToString();
            this.fPersonsList.ClearItems();

            if (!string.IsNullOrEmpty(this.fTemp)) {
                string[] tmpRefs = this.fTemp.Split(';');

                int num = tmpRefs.Length;
                for (int i = 0; i < num; i++)
                {
                    string xref = tmpRefs[i];
                    GEDCOMIndividualRecord p = this.Base.Tree.XRefIndex_Find(xref) as GEDCOMIndividualRecord;
                    if (p != null) this.fPersonsList.AddItem(p.GetNameString(true, false), p);
                }
            }

            if (this.fFilter.SourceMode != FilterGroupMode.Selected) {
                this.cmbSource.SelectedIndex = (sbyte)this.fFilter.SourceMode;
            } else {
                GEDCOMSourceRecord srcRec = this.Base.Tree.XRefIndex_Find(this.fFilter.SourceRef) as GEDCOMSourceRecord;
                this.cmbSource.Text = srcRec.FiledByEntry;
            }
        }

        private void rbCutNoneClick(object sender, EventArgs e)
        {
            if (this.rbCutNone.Checked)
            {
                this.fFilter.BranchCut = ChartFilter.BranchCutType.None;
            }
            else
            {
                if (this.rbCutYears.Checked)
                {
                    this.fFilter.BranchCut = ChartFilter.BranchCutType.Years;
                }
                else
                {
                    if (this.rbCutPersons.Checked)
                    {
                        this.fFilter.BranchCut = ChartFilter.BranchCutType.Persons;
                    }
                }
            }
            this.UpdateControls();
        }

        private void AcceptChanges()
        {
            if (this.rbCutNone.Checked)
            {
                this.fFilter.BranchCut = ChartFilter.BranchCutType.None;
            }
            else
            {
                if (this.rbCutYears.Checked)
                {
                    this.fFilter.BranchCut = ChartFilter.BranchCutType.Years;
                    this.fFilter.BranchYear = int.Parse(this.edYear.Text);
                }
                else
                {
                    if (this.rbCutPersons.Checked)
                    {
                        this.fFilter.BranchCut = ChartFilter.BranchCutType.Persons;
                        this.fFilter.BranchPersons = this.fTemp;
                    }
                }
            }

            int selectedIndex = this.cmbSource.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < 3)
            {
                this.fFilter.SourceMode = (FilterGroupMode)this.cmbSource.SelectedIndex;
                this.fFilter.SourceRef = "";
            }
            else
            {
                GKComboItem item = (GKComboItem)this.cmbSource.Items[this.cmbSource.SelectedIndex];
                GEDCOMRecord rec = item.Data as GEDCOMRecord;
                if (rec != null)
                {
                    this.fFilter.SourceMode = FilterGroupMode.Selected;
                    this.fFilter.SourceRef = rec.XRef;
                }
                else
                {
                    this.fFilter.SourceMode = FilterGroupMode.All;
                    this.fFilter.SourceRef = "";
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                AcceptChanges();
                base.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                this.fBase.Host.LogWrite("TfmTreeFilter.btnAccept_Click(): " + ex.Message);
                base.DialogResult = DialogResult.None;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.fFilter.Reset();
        }

        private void TfmTreeFilter_Load(object sender, EventArgs e)
        {
            GEDCOMTree tree = this.Base.Tree;
            this.fTemp = this.fFilter.BranchPersons;

            this.cmbSource.Sorted = true;
            int num = tree.RecordsCount - 1;
            for (int i = 0; i <= num; i++) {
                GEDCOMRecord rec = tree[i];
                if (rec is GEDCOMSourceRecord) {
                    this.cmbSource.Items.Add(new GKComboItem((rec as GEDCOMSourceRecord).FiledByEntry, rec));
                }
            }
            this.cmbSource.Sorted = false;

            this.cmbSource.Items.Insert(0, LangMan.LS(LSID.LSID_SrcAll));
            this.cmbSource.Items.Insert(1, LangMan.LS(LSID.LSID_SrcNot));
            this.cmbSource.Items.Insert(2, LangMan.LS(LSID.LSID_SrcAny));

            this.UpdateControls();
        }

        public TreeFilterDlg(IBaseWindow aBase)
        {
            this.InitializeComponent();

            this.fBase = aBase;
            this.fPersonsList = new GKSheetList(this.Panel1);
            this.fPersonsList.Buttons = EnumSet<SheetButton>.Create(SheetButton.lbAdd, SheetButton.lbDelete);
            this.fPersonsList.OnModify += this.ListModify;
            this.fPersonsList.AddColumn(LangMan.LS(LSID.LSID_RPIndividuals), 350, false);

            // SetLang()
            this.btnAccept.Text = LangMan.LS(LSID.LSID_DlgAccept);
            this.btnCancel.Text = LangMan.LS(LSID.LSID_DlgCancel);
            this.Text = LangMan.LS(LSID.LSID_MIFilter);
            this.rgBranchCut.Text = LangMan.LS(LSID.LSID_BranchCut);
            this.rbCutNone.Text = LangMan.LS(LSID.LSID_Not);
            this.rbCutYears.Text = LangMan.LS(LSID.LSID_BCut_Years);
            this.lblYear.Text = LangMan.LS(LSID.LSID_Year);
            this.rbCutPersons.Text = LangMan.LS(LSID.LSID_BCut_Persons);
            this.lblRPSources.Text = LangMan.LS(LSID.LSID_RPSources);
        }
    }
}
