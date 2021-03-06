; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{7C324A33-BDBB-4A86-BFE9-45C32CC7B180}
AppName=Run Skel Run
AppVersion=1.0
;AppVerName=Run Skel Run 1.0
AppPublisher=AFG_RU
DefaultDirName={pf}\Run Skel Run
DisableProgramGroupPage=yes
OutputDir=C:\Users\Hamid\Desktop\GAMES\RunSkelRunGame\Run Skel Run\Builds\Installer
OutputBaseFilename=RunSkelRun_Setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\Hamid\Desktop\GAMES\RunSkelRunGame\Run Skel Run\Builds\Run Skel Run!.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Hamid\Desktop\GAMES\RunSkelRunGame\Run Skel Run\Builds\Run Skel Run!_Data\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\Hamid\Desktop\GAMES\RunSkelRunGame\Run Skel Run\Builds\MonoBleedingEdge\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\Hamid\Desktop\GAMES\RunSkelRunGame\Run Skel Run\Builds\UnityPlayer.dll"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\Run Skel Run"; Filename: "{app}\Run Skel Run!.exe"
Name: "{commondesktop}\Run Skel Run"; Filename: "{app}\Run Skel Run!.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\Run Skel Run!.exe"; Description: "{cm:LaunchProgram,Run Skel Run}"; Flags: nowait postinstall skipifsilent

