; "GEDKeeper", the personal genealogical database editor.
; Copyright (C) 2009-2016 by Serg V. Zhdanovskih (aka Alchemist, aka Norseman).
; This file is part of "GEDKeeper".

!include "MUI2.nsh"

Name "GEDKeeper2"
OutFile "GEDKeeper2-v2.6.0-win-setup.exe"
InstallDir $PROGRAMFILES\GEDKeeper2
XPStyle on
;ShowInstDetails show
RequestExecutionLevel admin

; Registry key to check for directory (so if you install again, it will 
; overwrite the old one automatically)
InstallDirRegKey HKLM "Software\GEDKeeper2" "Install_Dir"

; Pages
Page components
Page directory
Page instfiles

LoadLanguageFile "${NSISDIR}\Contrib\Language files\English.nlf"
LoadLanguageFile "${NSISDIR}\Contrib\Language files\Russian.nlf"

UninstPage uninstConfirm
UninstPage instfiles

Section "GEDKeeper2 (����������)"
  SectionIn RO

  SetOutPath $INSTDIR

  File "..\GEDKeeper2.exe"
  File "..\GKCommon.dll"

  File "..\ArborGVT.dll"
  File "..\ExcelLibrary.dll"
  File "..\itextsharp.dll"
  File "..\lua51.dll"
  File "..\LuaInterface.dll"
  File "..\ZedGraph.dll"

  CreateDirectory "$INSTDIR\locales"
  SetOutPath "$INSTDIR\locales"
  File "..\locales\readme_rus.txt"
  File "..\locales\russian.sample"

  CreateDirectory "$INSTDIR\plugins"
  SetOutPath "$INSTDIR\plugins"
  File "..\plugins\GKCommon.dll"

  CreateDirectory "$INSTDIR\locales\help_rus"
  SetOutPath "$INSTDIR\locales\help_rus"
  File "..\locales\help_rus\*.*"

  CreateDirectory "$INSTDIR\locales\help_rus\images"
  SetOutPath "$INSTDIR\locales\help_rus\images"
  File "..\locales\help_rus\images\*.*"

  CreateDirectory "$SMPROGRAMS\GEDKeeper2"
  CreateShortCut "$SMPROGRAMS\GEDKeeper2\GEDKeeper2.lnk" "$INSTDIR\GEDKeeper2.exe" "" "$INSTDIR\GEDKeeper2.exe" 0
  CreateShortCut "$SMPROGRAMS\GEDKeeper2\�������.lnk" "$INSTDIR\locales\help_rus\GEDKeeper2.html" "" "$INSTDIR\locales\help_rus\GEDKeeper2.html" 0
  CreateShortCut "$SMPROGRAMS\GEDKeeper2\Uninstall.lnk" "$INSTDIR\uninstall.exe" "" "$INSTDIR\uninstall.exe" 0

  ; Write the installation path into the registry
  WriteRegStr HKLM SOFTWARE\GEDKeeper2 "Install_Dir" "$INSTDIR"

  ; Write the uninstall keys for Windows
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\GEDKeeper2" "DisplayName" "GEDKeeper2"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\GEDKeeper2" "UninstallString" '"$INSTDIR\uninstall.exe"'
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\GEDKeeper2" "NoModify" 1
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\GEDKeeper2" "NoRepair" 1
  WriteUninstaller "uninstall.exe"
SectionEnd

Section "������� ��������"
  CreateDirectory "$INSTDIR\scripts"
  SetOutPath "$INSTDIR\scripts"

  File "..\scripts\*.lua"
SectionEnd

Section "����������� � �������"
  CreateShortCut "$DESKTOP\GEDKeeper2.lnk" "$INSTDIR\GEDKeeper2.exe" "" "$INSTDIR\GEDKeeper2.exe" 0

  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\App Paths\GEDKeeper2.exe" "" "$INSTDIR\GEDKeeper2.exe"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\App Paths\GEDKeeper2.exe" "Path" "$INSTDIR"

  WriteRegStr HKCR ".ged" "" "GEDCOM.File"
  WriteRegStr HKCR "GEDCOM.File" "" "GEDCOM File"
  WriteRegStr HKCR "GEDCOM.File\DefaultIcon" "" "$INSTDIR\GEDKeeper2.exe,0"
  WriteRegStr HKCR "GEDCOM.File\shell" "" "open"
  WriteRegStr HKCR "GEDCOM.File\shell\open" "" "&�������"
  WriteRegStr HKCR "GEDCOM.File\shell\open\command" "" '$INSTDIR\GEDKeeper2.exe "%1"'
SectionEnd

SectionGroup /e "�����"
	Section "English"
  		SetOutPath "$INSTDIR\locales"
  		File "..\locales\english.lng"
	SectionEnd

	Section "���������"
  		SetOutPath "$INSTDIR\locales"
  		File "..\locales\ukrainian.lng"
	SectionEnd
SectionGroupEnd

SectionGroup /e "�������"
	Section "����������� ���������"
  		SetOutPath "$INSTDIR\plugins"
  		File "..\plugins\GKCalculatorPlugin.dll"
  		File "..\plugins\GKCalculatorPlugin.rus"
  		File "..\plugins\GKCalculatorPlugin.eng"
  		File "..\plugins\GKCalculatorPlugin.ukr"
	SectionEnd

	Section "���������"
  		SetOutPath "$INSTDIR\plugins"
  		File "..\plugins\GKCalendarPlugin.dll"
  		File "..\plugins\GKCalendarPlugin.rus"
  		File "..\plugins\GKCalendarPlugin.eng"
  		File "..\plugins\GKCalendarPlugin.ukr"
	SectionEnd

	Section "���������� ����"
  		SetOutPath "$INSTDIR\plugins"
  		File "..\plugins\GKNamesBookPlugin.dll"
  		File "..\plugins\GKNamesBookPlugin.rus"
  		File "..\plugins\GKNamesBookPlugin.eng"
  		File "..\plugins\GKNamesBookPlugin.ukr"
	SectionEnd

	Section "����� �������"
  		SetOutPath "$INSTDIR\plugins"
  		File "..\plugins\GKTimeLinePlugin.dll"
  		File "..\plugins\GKTimeLinePlugin.rus"
  		File "..\plugins\GKTimeLinePlugin.eng"
  		File "..\plugins\GKTimeLinePlugin.ukr"
	SectionEnd

	Section "�������� ����"
  		SetOutPath "$INSTDIR\plugins"
  		File "..\plugins\GKFlowInputPlugin.dll"
  		File "..\plugins\GKFlowInputPlugin.rus"
  		File "..\plugins\GKFlowInputPlugin.eng"
  		File "..\plugins\GKFlowInputPlugin.ukr"
	SectionEnd

	Section "������ ��������"
  		SetOutPath "$INSTDIR\plugins"
  		File "..\plugins\GKPedigreeImporterPlugin.dll"
  		File "..\plugins\GKPedigreeImporterPlugin.rus"
  		File "..\plugins\GKPedigreeImporterPlugin.eng"
  		File "..\plugins\GKPedigreeImporterPlugin.ukr"
	SectionEnd

	Section "�������������� �����"
  		SetOutPath "$INSTDIR\plugins"
  		File "..\plugins\_XapianSharp.dll"
  		File "..\plugins\XapianCSharp.dll"
  		File "..\plugins\zlib1.dll"
		File "..\plugins\GKTextSearchPlugin.dll"
  		File "..\plugins\GKTextSearchPlugin.rus"
  		File "..\plugins\GKTextSearchPlugin.eng"
  		File "..\plugins\GKTextSearchPlugin.ukr"
	SectionEnd

	Section "3D ������������"
  		SetOutPath "$INSTDIR\plugins"
  		File "..\plugins\csgl.dll"
  		File "..\plugins\csgl.native.dll"
		File "..\plugins\GKTreeVizPlugin.dll"
		File "..\plugins\ArborGVT.dll"
	SectionEnd

	Section "�������� �����������"
  		SetOutPath "$INSTDIR\plugins"
		File "..\plugins\GKImageViewerPlugin.dll"
  		File "..\plugins\GKImageViewerPlugin.rus"
  		File "..\plugins\GKImageViewerPlugin.eng"
  		File "..\plugins\GKImageViewerPlugin.ukr"
	SectionEnd

	Section "���� '����� ������'"
  		SetOutPath "$INSTDIR\plugins"
  		File "..\plugins\ConwayLife.dll"
  		File "..\plugins\GKLifePlugin.dll"
  		File "..\plugins\GKLifePlugin.rus"
  		File "..\plugins\GKLifePlugin.eng"
  		File "..\plugins\GKLifePlugin.ukr"
	SectionEnd
SectionGroupEnd

Section "Uninstall"
  ; Remove registry keys
  DeleteRegKey HKCR ".ged"
  DeleteRegKey HKCR "GEDCOM.File"

  DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\App Paths\GEDKeeper2.exe"
  DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\GEDKeeper2"
  DeleteRegKey HKLM "SOFTWARE\GEDKeeper2"

  ; Remove files and uninstaller
  Delete $INSTDIR\GEDKeeper2.exe
  Delete $INSTDIR\GKCommon.dll

  Delete $INSTDIR\ArborGVT.dll
  Delete $INSTDIR\ExcelLibrary.dll
  Delete $INSTDIR\itextsharp.dll
  Delete $INSTDIR\lua51.dll
  Delete $INSTDIR\LuaInterface.dll
  Delete $INSTDIR\ZedGraph.dll

  Delete $INSTDIR\uninstall.exe

  Delete "$INSTDIR\locales\help_rus\images\*.*"
  RMDir "$INSTDIR\locales\help_rus\images"

  Delete "$INSTDIR\locales\help_rus\*.*"
  RMDir "$INSTDIR\locales\help_rus"

  Delete "$INSTDIR\locales\*.*"
  RMDir "$INSTDIR\locales"

  Delete "$INSTDIR\scripts\*.lua"
  RMDir "$INSTDIR\scripts"

  Delete "$INSTDIR\plugins\*.*"
  RMDir "$INSTDIR\plugins"

  ; Remove shortcuts, if any
  Delete "$SMPROGRAMS\GEDKeeper2\*.*"
  Delete "$DESKTOP\GEDKeeper2.lnk"

  ; Remove directories used
  RMDir "$SMPROGRAMS\GEDKeeper2"
  RMDir "$INSTDIR"
SectionEnd
