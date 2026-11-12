#define MyAppName "Mon espace personnel"
#define MyAppVersion "1.0.0"
#define MyAppPublisher "Romeus Eliezer"
#define MyAppExeName "projet_c#_ROMEUS_Eliezer_Joel_Levi.exe"
#define ProjectRoot AddBackslash(SourcePath)
#define PublishDir ProjectRoot + "bin\Release\net10.0-windows\win-x64\publish"

[Setup]
AppId={{7E8F5B26-9166-4CC5-B0DB-97ECAFF741D8}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={localappdata}\Programs\MonEspacePersonnel
DefaultGroupName={#MyAppName}
DisableProgramGroupPage=yes
PrivilegesRequired=lowest
ArchitecturesAllowed=x64
ArchitecturesInstallIn64BitMode=x64
SetupIconFile={#ProjectRoot}favicon.ico
UninstallDisplayIcon={app}\{#MyAppExeName}
OutputDir={#ProjectRoot}..\dist
OutputBaseFilename=MonEspacePersonnel-Setup
Compression=lzma2
SolidCompression=yes
WizardStyle=modern

[Tasks]
Name: "desktopicon"; Description: "Créer une icône sur le Bureau"; GroupDescription: "Icônes supplémentaires :"; Flags: unchecked

[Files]
Source: "{#PublishDir}\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; WorkingDir: "{app}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; WorkingDir: "{app}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "Lancer {#MyAppName}"; WorkingDir: "{app}"; Flags: nowait postinstall skipifsilent
