# Language

### C#, Winform

## Library

1. KryptonForm

    Krypton.Toolkit

    Krypton.Navigator

    Krypton.Workspace

    Keypton.Docking

2. SQLite

    System.Data.Sqlite

**(All libraries from Nuget Package ( Latest Version))**

# Function

1. Real-Time Data Visualization 
    
    Serial, Wifi Communication possible
    
    Up-to 4 Ports
    
2. Graph Setting Box
    
    Set Upper, Lower Limit
    
3. Dynamic resize of Application window
4. UI Theme Changable
    
    Simple Click to Change Overall Theme of Application
    
    Follow : Form (Designer) - KryptonPalette - BasePalette - Select 
    
    Option : Office Black, Blue, Silver, Custom
    
    Custom : Editable in Krypton Palette
    

# TroubleShooting

## Error Message

### ‘TableLayoutPanel not found in Krypton.Toolkit’

Answer: you are using old version of Toolkit dll. try to download latest version from Nuget Package

### File cannot be processed because restricted or web-related zone

Error message: file cannot be processed because it is located in an internet or restricted zone, or because the file has web-related settings. To process such files, please remove the web-related settings.

Answer: you might have downloaded source from internet in .zip format. 

1. right click .zip folder
2. Proeprties
3. Toggle ‘Unblock’ . the Button is usually at the bottom.
4. Delete project
5. Unzip
6. Use new project
