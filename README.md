# Language
1. C#
2. WinForms

## Third-Party Libraries

This project uses the following third-party libraries:

### KryptonForm

- **License**: BSD-3 Clause
- **Components**:
  - `Krypton.Toolkit`
  - `Krypton.Navigator`
  - `Krypton.Workspace`
  - `Krypton.Docking`

### SQLite

- **License**: Apache 2.0
- **Component**:
  - `System.Data.Sqlite`

> **Note**: All libraries are from NuGet and are the latest versions available.

For more details about the licenses, check the `LICENSE` file in this project.

# Features

1. **Real-Time Data Visualization**
    - Supports Serial and WiFi communication
    - Up to 4 Ports

2. **Graph Settings**
    - Set Upper and Lower Limits

3. **Dynamic Window Resizing**

4. **Change UI Theme**
    - Easily change the overall theme of the application
    - Go to: Form (Designer) > KryptonPalette > BasePalette > Select
    - Themes available: Office Black, Blue, Silver, Custom
    - **Custom**: Editable in Krypton Palette

# Troubleshooting

## Error Messages

### ‘TableLayoutPanel not found in Krypton.Toolkit’

**Problem** : You are using an old version of the Toolkit DLL.  
**Solution** : Download the latest version from NuGet Package.  

### File cannot be processed because it is in a restricted or web-related zone

**Problem** : The file cannot be processed because it is from the internet or has web-related settings.  
**Solution** :  
1. Right-click the .zip file
2. Select "Properties"
3. Click "Unblock" at the bottom (if available)
4. Delete the project folder
5. Unzip the file again
6. Open the new project
