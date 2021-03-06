﻿using System;
using GKUI.Controls;

namespace GKUI
{
	partial class MainWin
	{
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.StatusBar StatusBar;
		private System.Windows.Forms.ToolStrip ToolBar1;
		private System.Windows.Forms.ToolStripButton tbFileNew;
		private System.Windows.Forms.ToolStripButton tbFileLoad;
		private System.Windows.Forms.ToolStripButton tbFileSave;
		private System.Windows.Forms.ToolStripSeparator TBS1;
		private System.Windows.Forms.ToolStripButton tbRecordAdd;
		private System.Windows.Forms.ToolStripButton tbRecordEdit;
		private System.Windows.Forms.ToolStripButton tbRecordDelete;
		private System.Windows.Forms.ToolStripSeparator TBS2;
		private System.Windows.Forms.ToolStripButton tbFilter;
		private System.Windows.Forms.ToolStripButton tbTreeAncestors;
		private System.Windows.Forms.ToolStripButton tbTreeDescendants;
		private System.Windows.Forms.ToolStripSeparator TBS4;
		private System.Windows.Forms.ToolStripDropDownButton tbPedigree;
		private System.Windows.Forms.ToolStripSeparator TBS6;
		private System.Windows.Forms.ToolStripButton tbStats;
		private System.Windows.Forms.ToolStripSeparator TBS5;
		private System.Windows.Forms.ToolStripButton tbPrev;
		private System.Windows.Forms.ToolStripButton tbNext;
		private System.Windows.Forms.ToolStripSeparator TBS8;
		private System.Windows.Forms.ToolStripButton tbDocPrint;
		private System.Windows.Forms.ToolStripButton tbDocPreview;
		private System.Windows.Forms.MenuStrip MainMenu1;
		private System.Windows.Forms.ToolStripMenuItem miFile;
		private System.Windows.Forms.ToolStripMenuItem miFileNew;
		private System.Windows.Forms.ToolStripMenuItem miFileLoad;
		private System.Windows.Forms.ToolStripMenuItem miMRUFiles;
		private System.Windows.Forms.ToolStripMenuItem miFileSave;
		private System.Windows.Forms.ToolStripMenuItem miFileClose;
		private System.Windows.Forms.ToolStripSeparator N1;
		private System.Windows.Forms.ToolStripMenuItem miFileProperties;
		private System.Windows.Forms.ToolStripSeparator N2;
		private System.Windows.Forms.ToolStripMenuItem miExportToExcelFile;
		private System.Windows.Forms.ToolStripMenuItem miExportToFamilyBook;
		private System.Windows.Forms.ToolStripSeparator N3;
		private System.Windows.Forms.ToolStripMenuItem miTreeTools;
		private System.Windows.Forms.ToolStripMenuItem miExit;
		private System.Windows.Forms.ToolStripMenuItem miEdit;
		private System.Windows.Forms.ToolStripMenuItem miRecordAdd;
		private System.Windows.Forms.ToolStripMenuItem miRecordEdit;
		private System.Windows.Forms.ToolStripMenuItem miRecordDelete;
		private System.Windows.Forms.ToolStripSeparator N15;
		private System.Windows.Forms.ToolStripMenuItem miSearch;
		private System.Windows.Forms.ToolStripSeparator N6;
		private System.Windows.Forms.ToolStripMenuItem miFilter;
		private System.Windows.Forms.ToolStripSeparator N7;
		private System.Windows.Forms.ToolStripMenuItem miOptions;
		private System.Windows.Forms.ToolStripMenuItem miPedigree;
		private System.Windows.Forms.ToolStripMenuItem miTreeAncestors;
		private System.Windows.Forms.ToolStripMenuItem miTreeDescendants;
		private System.Windows.Forms.ToolStripSeparator N8;
		private System.Windows.Forms.ToolStripMenuItem miPedigree_dAboville;
		private System.Windows.Forms.ToolStripMenuItem miPedigree_Konovalov;
		private System.Windows.Forms.ToolStripSeparator N9;
		private System.Windows.Forms.ToolStripMenuItem miMap;
		private System.Windows.Forms.ToolStripSeparator N10;
		private System.Windows.Forms.ToolStripMenuItem miStats;
		private System.Windows.Forms.ToolStripMenuItem miWindow;
		private System.Windows.Forms.ToolStripMenuItem miWinCascade;
		private System.Windows.Forms.ToolStripMenuItem miWinHTile;
		private System.Windows.Forms.ToolStripMenuItem miWinVTile;
		private System.Windows.Forms.ToolStripMenuItem miWinMinimize;
		private System.Windows.Forms.ToolStripMenuItem miWinArrange;
		private System.Windows.Forms.ToolStripMenuItem miHelp;
		private System.Windows.Forms.ToolStripMenuItem miContext;
		private System.Windows.Forms.ToolStripMenuItem miLogSend;
		private System.Windows.Forms.ToolStripMenuItem miLogView;
		private System.Windows.Forms.ToolStripSeparator N13;
		private System.Windows.Forms.ToolStripMenuItem miAbout;
		private System.Windows.Forms.ContextMenuStrip MenuMRU;
		private System.Windows.Forms.ContextMenuStrip MenuPedigree;
		private System.Windows.Forms.ToolStripMenuItem miPedigree_dAboville2;
		private System.Windows.Forms.ToolStripMenuItem miPedigree_Konovalov2;
		private System.Windows.Forms.ToolStripSeparator TBS7;
		private System.Windows.Forms.ToolStripMenuItem miOrganizer;
		private System.Windows.Forms.ToolStripMenuItem miService;
		private System.Windows.Forms.ToolStripSeparator N12;
		private System.Windows.Forms.ToolStripMenuItem miScripts;
		private System.Windows.Forms.ToolStripMenuItem miExport;
		private System.Windows.Forms.ToolStripMenuItem miTreeBoth;
		private System.Windows.Forms.ToolStripMenuItem miAncestorsCircle;
		private System.Windows.Forms.ToolStripButton tbTreeBoth;
		private System.Windows.Forms.StatusBarPanel StatusBarPanel1;
		private System.Windows.Forms.StatusBarPanel StatusBarPanel2;
		private System.Windows.Forms.ToolTip ToolTip1;
		private System.Windows.Forms.ToolStripMenuItem miPlugins;
		private System.Windows.Forms.ToolStripMenuItem miSlideshow;
		private System.Windows.Forms.ToolStripDropDownButton tbLoadMRU;

		private void InitializeComponent()
		{
		    this.components = new System.ComponentModel.Container();
		    this.StatusBar = new System.Windows.Forms.StatusBar();
		    this.StatusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
		    this.StatusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
		    this.ToolBar1 = new System.Windows.Forms.ToolStrip();
		    this.tbFileNew = new System.Windows.Forms.ToolStripButton();
		    this.tbFileLoad = new System.Windows.Forms.ToolStripButton();
		    this.tbLoadMRU = new System.Windows.Forms.ToolStripDropDownButton();
		    this.MenuMRU = new System.Windows.Forms.ContextMenuStrip(this.components);
		    this.tbFileSave = new System.Windows.Forms.ToolStripButton();
		    this.TBS1 = new System.Windows.Forms.ToolStripSeparator();
		    this.tbRecordAdd = new System.Windows.Forms.ToolStripButton();
		    this.tbRecordEdit = new System.Windows.Forms.ToolStripButton();
		    this.tbRecordDelete = new System.Windows.Forms.ToolStripButton();
		    this.TBS2 = new System.Windows.Forms.ToolStripSeparator();
		    this.tbFilter = new System.Windows.Forms.ToolStripButton();
		    this.TBS4 = new System.Windows.Forms.ToolStripSeparator();
		    this.tbTreeAncestors = new System.Windows.Forms.ToolStripButton();
		    this.tbTreeDescendants = new System.Windows.Forms.ToolStripButton();
		    this.tbTreeBoth = new System.Windows.Forms.ToolStripButton();
		    this.TBS5 = new System.Windows.Forms.ToolStripSeparator();
		    this.tbPedigree = new System.Windows.Forms.ToolStripDropDownButton();
		    this.MenuPedigree = new System.Windows.Forms.ContextMenuStrip(this.components);
		    this.miPedigree_dAboville2 = new System.Windows.Forms.ToolStripMenuItem();
		    this.miPedigree_Konovalov2 = new System.Windows.Forms.ToolStripMenuItem();
		    this.TBS6 = new System.Windows.Forms.ToolStripSeparator();
		    this.tbStats = new System.Windows.Forms.ToolStripButton();
		    this.TBS7 = new System.Windows.Forms.ToolStripSeparator();
		    this.tbPrev = new System.Windows.Forms.ToolStripButton();
		    this.tbNext = new System.Windows.Forms.ToolStripButton();
		    this.TBS8 = new System.Windows.Forms.ToolStripSeparator();
		    this.tbDocPreview = new System.Windows.Forms.ToolStripButton();
		    this.tbDocPrint = new System.Windows.Forms.ToolStripButton();
		    this.MainMenu1 = new System.Windows.Forms.MenuStrip();
		    this.miFile = new System.Windows.Forms.ToolStripMenuItem();
		    this.miFileNew = new System.Windows.Forms.ToolStripMenuItem();
		    this.miFileLoad = new System.Windows.Forms.ToolStripMenuItem();
		    this.miMRUFiles = new System.Windows.Forms.ToolStripMenuItem();
		    this.miFileSave = new System.Windows.Forms.ToolStripMenuItem();
		    this.miFileClose = new System.Windows.Forms.ToolStripMenuItem();
		    this.N1 = new System.Windows.Forms.ToolStripSeparator();
		    this.miFileProperties = new System.Windows.Forms.ToolStripMenuItem();
		    this.N2 = new System.Windows.Forms.ToolStripSeparator();
		    this.miExport = new System.Windows.Forms.ToolStripMenuItem();
		    this.miExportToExcelFile = new System.Windows.Forms.ToolStripMenuItem();
		    this.N3 = new System.Windows.Forms.ToolStripSeparator();
		    this.miExit = new System.Windows.Forms.ToolStripMenuItem();
		    this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
		    this.miRecordAdd = new System.Windows.Forms.ToolStripMenuItem();
		    this.miRecordEdit = new System.Windows.Forms.ToolStripMenuItem();
		    this.miRecordDelete = new System.Windows.Forms.ToolStripMenuItem();
		    this.N15 = new System.Windows.Forms.ToolStripSeparator();
		    this.miSearch = new System.Windows.Forms.ToolStripMenuItem();
		    this.miFilter = new System.Windows.Forms.ToolStripMenuItem();
		    this.miPedigree = new System.Windows.Forms.ToolStripMenuItem();
		    this.miTreeAncestors = new System.Windows.Forms.ToolStripMenuItem();
		    this.miTreeDescendants = new System.Windows.Forms.ToolStripMenuItem();
		    this.miTreeBoth = new System.Windows.Forms.ToolStripMenuItem();
		    this.miAncestorsCircle = new System.Windows.Forms.ToolStripMenuItem();
		    this.N6 = new System.Windows.Forms.ToolStripSeparator();
		    this.miPedigree_dAboville = new System.Windows.Forms.ToolStripMenuItem();
		    this.miPedigree_Konovalov = new System.Windows.Forms.ToolStripMenuItem();
		    this.miExportToFamilyBook = new System.Windows.Forms.ToolStripMenuItem();
		    this.N7 = new System.Windows.Forms.ToolStripSeparator();
		    this.miMap = new System.Windows.Forms.ToolStripMenuItem();
		    this.N8 = new System.Windows.Forms.ToolStripSeparator();
		    this.miStats = new System.Windows.Forms.ToolStripMenuItem();
		    this.miService = new System.Windows.Forms.ToolStripMenuItem();
		    this.miOrganizer = new System.Windows.Forms.ToolStripMenuItem();
		    this.miSlideshow = new System.Windows.Forms.ToolStripMenuItem();
		    this.N9 = new System.Windows.Forms.ToolStripSeparator();
		    this.miScripts = new System.Windows.Forms.ToolStripMenuItem();
		    this.miTreeTools = new System.Windows.Forms.ToolStripMenuItem();
		    this.N10 = new System.Windows.Forms.ToolStripSeparator();
		    this.miOptions = new System.Windows.Forms.ToolStripMenuItem();
		    this.miPlugins = new System.Windows.Forms.ToolStripMenuItem();
		    this.miWindow = new System.Windows.Forms.ToolStripMenuItem();
		    this.miWinCascade = new System.Windows.Forms.ToolStripMenuItem();
		    this.miWinHTile = new System.Windows.Forms.ToolStripMenuItem();
		    this.miWinVTile = new System.Windows.Forms.ToolStripMenuItem();
		    this.miWinMinimize = new System.Windows.Forms.ToolStripMenuItem();
		    this.miWinArrange = new System.Windows.Forms.ToolStripMenuItem();
		    this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
		    this.miContext = new System.Windows.Forms.ToolStripMenuItem();
		    this.N12 = new System.Windows.Forms.ToolStripSeparator();
		    this.miLogSend = new System.Windows.Forms.ToolStripMenuItem();
		    this.miLogView = new System.Windows.Forms.ToolStripMenuItem();
		    this.N13 = new System.Windows.Forms.ToolStripSeparator();
		    this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
		    this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
		    ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel1)).BeginInit();
		    ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel2)).BeginInit();
		    this.ToolBar1.SuspendLayout();
		    this.MenuPedigree.SuspendLayout();
		    this.MainMenu1.SuspendLayout();
		    this.SuspendLayout();
		    // 
		    // StatusBar
		    // 
		    this.StatusBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
		    this.StatusBar.Location = new System.Drawing.Point(0, 1021);
		    this.StatusBar.Name = "StatusBar";
		    this.StatusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
		    		    		    this.StatusBarPanel1,
		    		    		    this.StatusBarPanel2});
		    this.StatusBar.ShowPanels = true;
		    this.StatusBar.Size = new System.Drawing.Size(896, 24);
		    this.StatusBar.TabIndex = 0;
		    this.StatusBar.DrawItem += new System.Windows.Forms.StatusBarDrawItemEventHandler(this.StatusBar_DrawItem);
		    this.StatusBar.PanelClick += new System.Windows.Forms.StatusBarPanelClickEventHandler(this.StatusBar_PanelClick);
		    // 
		    // StatusBarPanel1
		    // 
		    this.StatusBarPanel1.Name = "StatusBarPanel1";
		    this.StatusBarPanel1.Width = 50;
		    // 
		    // StatusBarPanel2
		    // 
		    this.StatusBarPanel2.Name = "StatusBarPanel2";
		    this.StatusBarPanel2.Style = System.Windows.Forms.StatusBarPanelStyle.OwnerDraw;
		    this.StatusBarPanel2.Width = 24;
		    // 
		    // ToolBar1
		    // 
		    this.ToolBar1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
		    this.ToolBar1.ImageScalingSize = new System.Drawing.Size(20, 20);
		    this.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
		    this.ToolBar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
		    		    		    this.tbFileNew,
		    		    		    this.tbFileLoad,
		    		    		    this.tbLoadMRU,
		    		    		    this.tbFileSave,
		    		    		    this.TBS1,
		    		    		    this.tbRecordAdd,
		    		    		    this.tbRecordEdit,
		    		    		    this.tbRecordDelete,
		    		    		    this.TBS2,
		    		    		    this.tbFilter,
		    		    		    this.TBS4,
		    		    		    this.tbTreeAncestors,
		    		    		    this.tbTreeDescendants,
		    		    		    this.tbTreeBoth,
		    		    		    this.TBS5,
		    		    		    this.tbPedigree,
		    		    		    this.TBS6,
		    		    		    this.tbStats,
		    		    		    this.TBS7,
		    		    		    this.tbPrev,
		    		    		    this.tbNext,
		    		    		    this.TBS8,
		    		    		    this.tbDocPreview,
		    		    		    this.tbDocPrint});
		    this.ToolBar1.Location = new System.Drawing.Point(0, 28);
		    this.ToolBar1.Name = "ToolBar1";
		    this.ToolBar1.Size = new System.Drawing.Size(896, 25);
		    this.ToolBar1.TabIndex = 0;
		    // 
		    // tbFileNew
		    // 
		    this.tbFileNew.Name = "tbFileNew";
		    this.tbFileNew.Size = new System.Drawing.Size(23, 22);
		    this.tbFileNew.Click += new System.EventHandler(this.ToolBar1_ButtonClick);
		    // 
		    // tbFileLoad
		    // 
		    this.tbFileLoad.Name = "tbFileLoad";
		    this.tbFileLoad.Size = new System.Drawing.Size(23, 22);
		    this.tbFileLoad.Click += new System.EventHandler(this.ToolBar1_ButtonClick);
		    // 
		    // tbLoadMRU
		    // 
		    this.tbLoadMRU.AutoToolTip = false;
		    this.tbLoadMRU.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
		    this.tbLoadMRU.DropDown = this.MenuMRU;
		    this.tbLoadMRU.ImageTransparentColor = System.Drawing.Color.Magenta;
		    this.tbLoadMRU.Name = "tbLoadMRU";
		    this.tbLoadMRU.Size = new System.Drawing.Size(13, 22);
		    this.tbLoadMRU.Text = "tbLoadMRU";
		    // 
		    // MenuMRU
		    // 
		    this.MenuMRU.Name = "MenuMRU";
		    this.MenuMRU.OwnerItem = this.tbLoadMRU;
		    this.MenuMRU.Size = new System.Drawing.Size(61, 4);
		    // 
		    // tbFileSave
		    // 
		    this.tbFileSave.Name = "tbFileSave";
		    this.tbFileSave.Size = new System.Drawing.Size(23, 22);
		    this.tbFileSave.Click += new System.EventHandler(this.ToolBar1_ButtonClick);
		    // 
		    // TBS1
		    // 
		    this.TBS1.Name = "TBS1";
		    this.TBS1.Size = new System.Drawing.Size(6, 25);
		    // 
		    // tbRecordAdd
		    // 
		    this.tbRecordAdd.Name = "tbRecordAdd";
		    this.tbRecordAdd.Size = new System.Drawing.Size(23, 22);
		    this.tbRecordAdd.Click += new System.EventHandler(this.ToolBar1_ButtonClick);
		    // 
		    // tbRecordEdit
		    // 
		    this.tbRecordEdit.Name = "tbRecordEdit";
		    this.tbRecordEdit.Size = new System.Drawing.Size(23, 22);
		    this.tbRecordEdit.Click += new System.EventHandler(this.ToolBar1_ButtonClick);
		    // 
		    // tbRecordDelete
		    // 
		    this.tbRecordDelete.Name = "tbRecordDelete";
		    this.tbRecordDelete.Size = new System.Drawing.Size(23, 22);
		    this.tbRecordDelete.Click += new System.EventHandler(this.ToolBar1_ButtonClick);
		    // 
		    // TBS2
		    // 
		    this.TBS2.Name = "TBS2";
		    this.TBS2.Size = new System.Drawing.Size(6, 25);
		    // 
		    // tbFilter
		    // 
		    this.tbFilter.ImageTransparentColor = System.Drawing.Color.White;
		    this.tbFilter.Name = "tbFilter";
		    this.tbFilter.Size = new System.Drawing.Size(23, 22);
		    this.tbFilter.Click += new System.EventHandler(this.ToolBar1_ButtonClick);
		    // 
		    // TBS4
		    // 
		    this.TBS4.Name = "TBS4";
		    this.TBS4.Size = new System.Drawing.Size(6, 25);
		    // 
		    // tbTreeAncestors
		    // 
		    this.tbTreeAncestors.Name = "tbTreeAncestors";
		    this.tbTreeAncestors.Size = new System.Drawing.Size(23, 22);
		    this.tbTreeAncestors.Click += new System.EventHandler(this.ToolBar1_ButtonClick);
		    // 
		    // tbTreeDescendants
		    // 
		    this.tbTreeDescendants.Name = "tbTreeDescendants";
		    this.tbTreeDescendants.Size = new System.Drawing.Size(23, 22);
		    this.tbTreeDescendants.Click += new System.EventHandler(this.ToolBar1_ButtonClick);
		    // 
		    // tbTreeBoth
		    // 
		    this.tbTreeBoth.Name = "tbTreeBoth";
		    this.tbTreeBoth.Size = new System.Drawing.Size(23, 22);
		    this.tbTreeBoth.Click += new System.EventHandler(this.ToolBar1_ButtonClick);
		    // 
		    // TBS5
		    // 
		    this.TBS5.Name = "TBS5";
		    this.TBS5.Size = new System.Drawing.Size(6, 25);
		    // 
		    // tbPedigree
		    // 
		    this.tbPedigree.DropDown = this.MenuPedigree;
		    this.tbPedigree.Name = "tbPedigree";
		    this.tbPedigree.Size = new System.Drawing.Size(13, 22);
		    // 
		    // MenuPedigree
		    // 
		    this.MenuPedigree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
		    		    		    this.miPedigree_dAboville2,
		    		    		    this.miPedigree_Konovalov2});
		    this.MenuPedigree.Name = "MenuPedigree";
		    this.MenuPedigree.OwnerItem = this.tbPedigree;
		    this.MenuPedigree.Size = new System.Drawing.Size(246, 52);
		    // 
		    // miPedigree_dAboville2
		    // 
		    this.miPedigree_dAboville2.Name = "miPedigree_dAboville2";
		    this.miPedigree_dAboville2.Size = new System.Drawing.Size(245, 24);
		    this.miPedigree_dAboville2.Click += new System.EventHandler(this.miPedigree_dAbovilleClick);
		    // 
		    // miPedigree_Konovalov2
		    // 
		    this.miPedigree_Konovalov2.Name = "miPedigree_Konovalov2";
		    this.miPedigree_Konovalov2.Size = new System.Drawing.Size(245, 24);
		    this.miPedigree_Konovalov2.Click += new System.EventHandler(this.miPedigree_KonovalovClick);
		    // 
		    // TBS6
		    // 
		    this.TBS6.Name = "TBS6";
		    this.TBS6.Size = new System.Drawing.Size(6, 25);
		    // 
		    // tbStats
		    // 
		    this.tbStats.Name = "tbStats";
		    this.tbStats.Size = new System.Drawing.Size(23, 22);
		    this.tbStats.Click += new System.EventHandler(this.ToolBar1_ButtonClick);
		    // 
		    // TBS7
		    // 
		    this.TBS7.Name = "TBS7";
		    this.TBS7.Size = new System.Drawing.Size(6, 25);
		    // 
		    // tbPrev
		    // 
		    this.tbPrev.Enabled = false;
		    this.tbPrev.Name = "tbPrev";
		    this.tbPrev.Size = new System.Drawing.Size(23, 22);
		    this.tbPrev.Click += new System.EventHandler(this.ToolBar1_ButtonClick);
		    // 
		    // tbNext
		    // 
		    this.tbNext.Enabled = false;
		    this.tbNext.Name = "tbNext";
		    this.tbNext.Size = new System.Drawing.Size(23, 22);
		    this.tbNext.Click += new System.EventHandler(this.ToolBar1_ButtonClick);
		    // 
		    // TBS8
		    // 
		    this.TBS8.Name = "TBS8";
		    this.TBS8.Size = new System.Drawing.Size(6, 25);
		    // 
		    // tbDocPreview
		    // 
		    this.tbDocPreview.Name = "tbDocPreview";
		    this.tbDocPreview.Size = new System.Drawing.Size(23, 22);
		    this.tbDocPreview.Click += new System.EventHandler(this.ToolBar1_ButtonClick);
		    // 
		    // tbDocPrint
		    // 
		    this.tbDocPrint.Name = "tbDocPrint";
		    this.tbDocPrint.Size = new System.Drawing.Size(23, 22);
		    this.tbDocPrint.Click += new System.EventHandler(this.ToolBar1_ButtonClick);
		    // 
		    // MainMenu1
		    // 
		    this.MainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
		    		    		    this.miFile,
		    		    		    this.miEdit,
		    		    		    this.miPedigree,
		    		    		    this.miService,
		    		    		    this.miPlugins,
		    		    		    this.miWindow,
		    		    		    this.miHelp});
		    this.MainMenu1.Location = new System.Drawing.Point(0, 0);
		    this.MainMenu1.MdiWindowListItem = this.miWindow;
		    this.MainMenu1.Name = "MainMenu1";
		    this.MainMenu1.Size = new System.Drawing.Size(896, 28);
		    this.MainMenu1.TabIndex = 0;
		    this.MainMenu1.Tag = "";
		    // 
		    // miFile
		    // 
		    this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
		    		    		    this.miFileNew,
		    		    		    this.miFileLoad,
		    		    		    this.miMRUFiles,
		    		    		    this.miFileSave,
		    		    		    this.miFileClose,
		    		    		    this.N1,
		    		    		    this.miFileProperties,
		    		    		    this.N2,
		    		    		    this.miExport,
		    		    		    this.N3,
		    		    		    this.miExit});
		    this.miFile.Name = "miFile";
		    this.miFile.Size = new System.Drawing.Size(57, 24);
		    this.miFile.Text = "miFile";
		    // 
		    // miFileNew
		    // 
		    this.miFileNew.Name = "miFileNew";
		    this.miFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
		    this.miFileNew.Size = new System.Drawing.Size(216, 24);
		    this.miFileNew.Text = "miFileNew";
		    this.miFileNew.Click += new System.EventHandler(this.miFileNewClick);
		    // 
		    // miFileLoad
		    // 
		    this.miFileLoad.Name = "miFileLoad";
		    this.miFileLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
		    this.miFileLoad.Size = new System.Drawing.Size(216, 24);
		    this.miFileLoad.Text = "miFileLoad";
		    this.miFileLoad.Click += new System.EventHandler(this.miFileLoadClick);
		    // 
		    // miMRUFiles
		    // 
		    this.miMRUFiles.Enabled = false;
		    this.miMRUFiles.Name = "miMRUFiles";
		    this.miMRUFiles.Size = new System.Drawing.Size(216, 24);
		    this.miMRUFiles.Text = "miMRUFiles";
		    // 
		    // miFileSave
		    // 
		    this.miFileSave.Name = "miFileSave";
		    this.miFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
		    this.miFileSave.Size = new System.Drawing.Size(216, 24);
		    this.miFileSave.Text = "miFileSave";
		    this.miFileSave.Click += new System.EventHandler(this.miFileSaveClick);
		    // 
		    // miFileClose
		    // 
		    this.miFileClose.Name = "miFileClose";
		    this.miFileClose.Size = new System.Drawing.Size(216, 24);
		    this.miFileClose.Text = "miFileClose";
		    this.miFileClose.Click += new System.EventHandler(this.miFileCloseClick);
		    // 
		    // N1
		    // 
		    this.N1.Name = "N1";
		    this.N1.Size = new System.Drawing.Size(213, 6);
		    // 
		    // miFileProperties
		    // 
		    this.miFileProperties.Name = "miFileProperties";
		    this.miFileProperties.Size = new System.Drawing.Size(216, 24);
		    this.miFileProperties.Text = "miFileProperties";
		    this.miFileProperties.Click += new System.EventHandler(this.miFilePropertiesClick);
		    // 
		    // N2
		    // 
		    this.N2.Name = "N2";
		    this.N2.Size = new System.Drawing.Size(213, 6);
		    // 
		    // miExport
		    // 
		    this.miExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
		    		    		    this.miExportToExcelFile});
		    this.miExport.Name = "miExport";
		    this.miExport.Size = new System.Drawing.Size(216, 24);
		    this.miExport.Text = "miExport";
		    // 
		    // miExportToExcelFile
		    // 
		    this.miExportToExcelFile.Name = "miExportToExcelFile";
		    this.miExportToExcelFile.Size = new System.Drawing.Size(234, 24);
		    this.miExportToExcelFile.Text = "miExportToExcelFile";
		    this.miExportToExcelFile.Click += new System.EventHandler(this.miExportToExcelFileClick);
		    // 
		    // N3
		    // 
		    this.N3.Name = "N3";
		    this.N3.Size = new System.Drawing.Size(213, 6);
		    // 
		    // miExit
		    // 
		    this.miExit.Name = "miExit";
		    this.miExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
		    this.miExit.Size = new System.Drawing.Size(216, 24);
		    this.miExit.Text = "miExit";
		    this.miExit.Click += new System.EventHandler(this.miExit_Click);
		    // 
		    // miEdit
		    // 
		    this.miEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
		    		    		    this.miRecordAdd,
		    		    		    this.miRecordEdit,
		    		    		    this.miRecordDelete,
		    		    		    this.N15,
		    		    		    this.miSearch,
		    		    		    this.miFilter});
		    this.miEdit.Name = "miEdit";
		    this.miEdit.Size = new System.Drawing.Size(72, 24);
		    this.miEdit.Text = "miEdit";
		    // 
		    // miRecordAdd
		    // 
		    this.miRecordAdd.Name = "miRecordAdd";
		    this.miRecordAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
		    this.miRecordAdd.Size = new System.Drawing.Size(243, 24);
		    this.miRecordAdd.Text = "miRecordAdd";
		    this.miRecordAdd.Click += new System.EventHandler(this.miRecordAddClick);
		    // 
		    // miRecordEdit
		    // 
		    this.miRecordEdit.Name = "miRecordEdit";
		    this.miRecordEdit.Size = new System.Drawing.Size(243, 24);
		    this.miRecordEdit.Text = "miRecordEdit";
		    this.miRecordEdit.Click += new System.EventHandler(this.miRecordEditClick);
		    // 
		    // miRecordDelete
		    // 
		    this.miRecordDelete.Name = "miRecordDelete";
		    this.miRecordDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
		    this.miRecordDelete.Size = new System.Drawing.Size(243, 24);
		    this.miRecordDelete.Text = "miRecordDelete";
		    this.miRecordDelete.Click += new System.EventHandler(this.miRecordDeleteClick);
		    // 
		    // N15
		    // 
		    this.N15.Name = "N15";
		    this.N15.Size = new System.Drawing.Size(240, 6);
		    // 
		    // miSearch
		    // 
		    this.miSearch.Name = "miSearch";
		    this.miSearch.Size = new System.Drawing.Size(243, 24);
		    this.miSearch.Text = "miSearch";
		    this.miSearch.Click += new System.EventHandler(this.miSearchClick);
		    // 
		    // miFilter
		    // 
		    this.miFilter.Name = "miFilter";
		    this.miFilter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
		    this.miFilter.Size = new System.Drawing.Size(243, 24);
		    this.miFilter.Text = "miFilter";
		    this.miFilter.Click += new System.EventHandler(this.miFilterClick);
		    // 
		    // miPedigree
		    // 
		    this.miPedigree.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
		    		    		    this.miTreeAncestors,
		    		    		    this.miTreeDescendants,
		    		    		    this.miTreeBoth,
		    		    		    this.miAncestorsCircle,
		    		    		    this.N6,
		    		    		    this.miPedigree_dAboville,
		    		    		    this.miPedigree_Konovalov,
		    		    		    this.miExportToFamilyBook,
		    		    		    this.N7,
		    		    		    this.miMap,
		    		    		    this.N8,
		    		    		    this.miStats});
		    this.miPedigree.Name = "miPedigree";
		    this.miPedigree.Size = new System.Drawing.Size(112, 24);
		    this.miPedigree.Text = "miPedigree";
		    // 
		    // miTreeAncestors
		    // 
		    this.miTreeAncestors.Name = "miTreeAncestors";
		    this.miTreeAncestors.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
		    this.miTreeAncestors.Size = new System.Drawing.Size(296, 24);
		    this.miTreeAncestors.Text = "miTreeAncestors";
		    this.miTreeAncestors.Click += new System.EventHandler(this.miTreeAncestorsClick);
		    // 
		    // miTreeDescendants
		    // 
		    this.miTreeDescendants.Name = "miTreeDescendants";
		    this.miTreeDescendants.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
		    this.miTreeDescendants.Size = new System.Drawing.Size(296, 24);
		    this.miTreeDescendants.Text = "miTreeDescendants";
		    this.miTreeDescendants.Click += new System.EventHandler(this.miTreeDescendantsClick);
		    // 
		    // miTreeBoth
		    // 
		    this.miTreeBoth.Name = "miTreeBoth";
		    this.miTreeBoth.Size = new System.Drawing.Size(296, 24);
		    this.miTreeBoth.Text = "miTreeBoth";
		    this.miTreeBoth.Click += new System.EventHandler(this.miTreeBothClick);
		    // 
		    // miAncestorsCircle
		    // 
		    this.miAncestorsCircle.Name = "miAncestorsCircle";
		    this.miAncestorsCircle.Size = new System.Drawing.Size(296, 24);
		    this.miAncestorsCircle.Text = "miAncestorsCircle";
		    this.miAncestorsCircle.Click += new System.EventHandler(this.miAncestorsCircleClick);
		    // 
		    // N6
		    // 
		    this.N6.Name = "N6";
		    this.N6.Size = new System.Drawing.Size(293, 6);
		    // 
		    // miPedigree_dAboville
		    // 
		    this.miPedigree_dAboville.Name = "miPedigree_dAboville";
		    this.miPedigree_dAboville.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
		    this.miPedigree_dAboville.Size = new System.Drawing.Size(296, 24);
		    this.miPedigree_dAboville.Text = "miPedigree_dAboville";
		    this.miPedigree_dAboville.Click += new System.EventHandler(this.miPedigree_dAbovilleClick);
		    // 
		    // miPedigree_Konovalov
		    // 
		    this.miPedigree_Konovalov.Name = "miPedigree_Konovalov";
		    this.miPedigree_Konovalov.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
		    this.miPedigree_Konovalov.Size = new System.Drawing.Size(296, 24);
		    this.miPedigree_Konovalov.Text = "miPedigree_Konovalov";
		    this.miPedigree_Konovalov.Click += new System.EventHandler(this.miPedigree_KonovalovClick);
		    // 
		    // miExportToFamilyBook
		    // 
		    this.miExportToFamilyBook.Name = "miExportToFamilyBook";
		    this.miExportToFamilyBook.Size = new System.Drawing.Size(296, 24);
		    this.miExportToFamilyBook.Text = "miExportToFamilyBook";
		    this.miExportToFamilyBook.Click += new System.EventHandler(this.miExportToFamilyBookClick);
		    // 
		    // N7
		    // 
		    this.N7.Name = "N7";
		    this.N7.Size = new System.Drawing.Size(293, 6);
		    // 
		    // miMap
		    // 
		    this.miMap.Name = "miMap";
		    this.miMap.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
		    this.miMap.Size = new System.Drawing.Size(296, 24);
		    this.miMap.Text = "miMap";
		    this.miMap.Click += new System.EventHandler(this.miMapClick);
		    // 
		    // N8
		    // 
		    this.N8.Name = "N8";
		    this.N8.Size = new System.Drawing.Size(293, 6);
		    // 
		    // miStats
		    // 
		    this.miStats.Name = "miStats";
		    this.miStats.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
		    this.miStats.Size = new System.Drawing.Size(296, 24);
		    this.miStats.Text = "miStats";
		    this.miStats.Click += new System.EventHandler(this.miStatsClick);
		    // 
		    // miService
		    // 
		    this.miService.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
		    		    		    this.miOrganizer,
		    		    		    this.miSlideshow,
		    		    		    this.N9,
		    		    		    this.miScripts,
		    		    		    this.miTreeTools,
		    		    		    this.N10,
		    		    		    this.miOptions});
		    this.miService.Name = "miService";
		    this.miService.Size = new System.Drawing.Size(71, 24);
		    this.miService.Text = "miService";
		    // 
		    // miOrganizer
		    // 
		    this.miOrganizer.Name = "miOrganizer";
		    this.miOrganizer.Size = new System.Drawing.Size(212, 24);
		    this.miOrganizer.Text = "miOrganizer";
		    this.miOrganizer.Click += new System.EventHandler(this.miOrganizerClick);
		    // 
		    // miSlideshow
		    // 
		    this.miSlideshow.Name = "miSlideshow";
		    this.miSlideshow.Size = new System.Drawing.Size(212, 24);
		    this.miSlideshow.Text = "miSlideshow";
		    this.miSlideshow.Click += new System.EventHandler(this.miSlideshowClick);
		    // 
		    // N9
		    // 
		    this.N9.Name = "N9";
		    this.N9.Size = new System.Drawing.Size(209, 6);
		    // 
		    // miScripts
		    // 
		    this.miScripts.Name = "miScripts";
		    this.miScripts.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F11)));
		    this.miScripts.Size = new System.Drawing.Size(212, 24);
		    this.miScripts.Text = "miScripts";
		    this.miScripts.Click += new System.EventHandler(this.miScriptsClick);
		    // 
		    // miTreeTools
		    // 
		    this.miTreeTools.Name = "miTreeTools";
		    this.miTreeTools.Size = new System.Drawing.Size(212, 24);
		    this.miTreeTools.Text = "miTreeTools";
		    this.miTreeTools.Click += new System.EventHandler(this.miTreeToolsClick);
		    // 
		    // N10
		    // 
		    this.N10.Name = "N10";
		    this.N10.Size = new System.Drawing.Size(209, 6);
		    // 
		    // miOptions
		    // 
		    this.miOptions.Name = "miOptions";
		    this.miOptions.Size = new System.Drawing.Size(212, 24);
		    this.miOptions.Text = "miOptions";
		    this.miOptions.Click += new System.EventHandler(this.miOptionsClick);
		    // 
		    // miPlugins
		    // 
		    this.miPlugins.Name = "miPlugins";
		    this.miPlugins.Size = new System.Drawing.Size(68, 24);
		    this.miPlugins.Text = "miPlugins";
		    // 
		    // miWindow
		    // 
		    this.miWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
		    		    		    this.miWinCascade,
		    		    		    this.miWinHTile,
		    		    		    this.miWinVTile,
		    		    		    this.miWinMinimize,
		    		    		    this.miWinArrange});
		    this.miWindow.Name = "miWindow";
		    this.miWindow.Size = new System.Drawing.Size(56, 24);
		    this.miWindow.Text = "miWindow";
		    this.miWindow.DropDownOpening += new System.EventHandler(this.miWindowDropDownOpening);
		    // 
		    // miWinCascade
		    // 
		    this.miWinCascade.Name = "miWinCascade";
		    this.miWinCascade.Size = new System.Drawing.Size(255, 24);
		    this.miWinCascade.Text = "miWinCascade";
		    this.miWinCascade.Click += new System.EventHandler(this.miWinCascadeClick);
		    // 
		    // miWinHTile
		    // 
		    this.miWinHTile.Name = "miWinHTile";
		    this.miWinHTile.Size = new System.Drawing.Size(255, 24);
		    this.miWinHTile.Text = "miWinHTile";
		    this.miWinHTile.Click += new System.EventHandler(this.miWinHTileClick);
		    // 
		    // miWinVTile
		    // 
		    this.miWinVTile.Name = "miWinVTile";
		    this.miWinVTile.Size = new System.Drawing.Size(255, 24);
		    this.miWinVTile.Text = "miWinVTile";
		    this.miWinVTile.Click += new System.EventHandler(this.miWinVTileClick);
		    // 
		    // miWinMinimize
		    // 
		    this.miWinMinimize.Name = "miWinMinimize";
		    this.miWinMinimize.Size = new System.Drawing.Size(255, 24);
		    this.miWinMinimize.Text = "miWinMinimize";
		    this.miWinMinimize.Click += new System.EventHandler(this.miWinMinimizeClick);
		    // 
		    // miWinArrange
		    // 
		    this.miWinArrange.Name = "miWinArrange";
		    this.miWinArrange.Size = new System.Drawing.Size(255, 24);
		    this.miWinArrange.Text = "miWinArrange";
		    this.miWinArrange.Click += new System.EventHandler(this.miWinArrangeClick);
		    // 
		    // miHelp
		    // 
		    this.miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
		    		    		    this.miContext,
		    		    		    this.N12,
		    		    		    this.miLogSend,
		    		    		    this.miLogView,
		    		    		    this.N13,
		    		    		    this.miAbout});
		    this.miHelp.Name = "miHelp";
		    this.miHelp.Size = new System.Drawing.Size(79, 24);
		    this.miHelp.Text = "miHelp";
		    // 
		    // miContext
		    // 
		    this.miContext.Name = "miContext";
		    this.miContext.ShortcutKeys = System.Windows.Forms.Keys.F1;
		    this.miContext.Size = new System.Drawing.Size(286, 24);
		    this.miContext.Text = "miContext";
		    this.miContext.Click += new System.EventHandler(this.miContextClick);
		    // 
		    // N12
		    // 
		    this.N12.Name = "N12";
		    this.N12.Size = new System.Drawing.Size(283, 6);
		    // 
		    // miLogSend
		    // 
		    this.miLogSend.Name = "miLogSend";
		    this.miLogSend.Size = new System.Drawing.Size(286, 24);
		    this.miLogSend.Text = "miLogSend";
		    this.miLogSend.Click += new System.EventHandler(this.miLogSendClick);
		    // 
		    // miLogView
		    // 
		    this.miLogView.Name = "miLogView";
		    this.miLogView.Size = new System.Drawing.Size(286, 24);
		    this.miLogView.Text = "miLogView";
		    this.miLogView.Click += new System.EventHandler(this.miLogViewClick);
		    // 
		    // N13
		    // 
		    this.N13.Name = "N13";
		    this.N13.Size = new System.Drawing.Size(283, 6);
		    // 
		    // miAbout
		    // 
		    this.miAbout.Name = "miAbout";
		    this.miAbout.Size = new System.Drawing.Size(286, 24);
		    this.miAbout.Text = "miAbout";
		    this.miAbout.Click += new System.EventHandler(this.miAboutClick);
		    // 
		    // MainWin
		    // 
		    this.AllowDrop = true;
		    this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
		    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
		    this.ClientSize = new System.Drawing.Size(896, 1045);
		    this.Controls.Add(this.StatusBar);
		    this.Controls.Add(this.ToolBar1);
		    this.Controls.Add(this.MainMenu1);
		    this.Font = new System.Drawing.Font("Tahoma", 8.25F);
		    this.IsMdiContainer = true;
		    this.KeyPreview = true;
		    this.Location = new System.Drawing.Point(337, 111);
		    this.MainMenuStrip = this.MainMenu1;
		    this.Name = "MainWin";
		    this.Text = "GEDKeeper2";
		    this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
		    this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Closed);
		    this.Load += new System.EventHandler(this.Form_Load);
		    this.VisibleChanged += new System.EventHandler(this.Form_Show);
		    this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form_DragDrop);
		    this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form_DragEnter);
		    this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
		    this.Resize += new System.EventHandler(this.Form_Resize);
		    ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel1)).EndInit();
		    ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel2)).EndInit();
		    this.ToolBar1.ResumeLayout(false);
		    this.ToolBar1.PerformLayout();
		    this.MenuPedigree.ResumeLayout(false);
		    this.MainMenu1.ResumeLayout(false);
		    this.MainMenu1.PerformLayout();
		    this.ResumeLayout(false);
		    this.PerformLayout();
		}
	}
}
