#define MyAppName "Secret"
#define MyAppVersion "1.0.0"
#define MyAppPublisher "Romeus Eliezer"
#define MyAppExeName "Secret.exe"
#define PublishedExeName "projet_c#_ROMEUS_Eliezer_Joel_Levi.exe"
#define ProjectRoot AddBackslash(SourcePath)
#define PublishDir ProjectRoot + "bin\Release\net10.0-windows\publish\win-x86"

[Setup]
AppId={{7E8F5B26-9166-4CC5-B0DB-97ECAFF741D8}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={localappdata}\Programs\Secret
DefaultGroupName={#MyAppName}
DisableProgramGroupPage=yes
PrivilegesRequired=lowest
SetupIconFile=C:\Users\Home\Downloads\favicon_io\favicon.ico
UninstallDisplayIcon={app}\{#MyAppExeName}
OutputDir={#ProjectRoot}..\dist
OutputBaseFilename=Secret-Setup
Compression=lzma2
SolidCompression=yes
WizardStyle=modern

[Tasks]
Name: "desktopicon"; Description: "Créer une icône sur le Bureau"; GroupDescription: "Icônes supplémentaires :"; Flags: unchecked

[Files]
Source: "{#PublishDir}\{#PublishedExeName}"; DestDir: "{app}"; DestName: "{#MyAppExeName}"; Flags: ignoreversion
Source: "{#PublishDir}\appsettings.json"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; WorkingDir: "{app}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; WorkingDir: "{app}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "Lancer {#MyAppName}"; WorkingDir: "{app}"; Flags: nowait postinstall skipifsilent
