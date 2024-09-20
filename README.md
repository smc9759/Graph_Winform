# Project Overview

## Language and Framework

- **Language**: C#
- **Framework**: WinForms

## Third-Party Libraries

This project uses these third-party libraries:

### KryptonForm

- **License**: BSD-3 Clause
- **Components**:
    - `Krypton.Toolkit`
    - `Krypton.Workspace`
    - `Krypton.Ribbon`

### SQLite

- **License**: Apache 2.0
- **Component**:
    - `System.Data.Sqlite`

> Note: All libraries come from NuGet and are up to date.

For more details about the licenses, check the `LICENSE` file in the project.

## Features

1. **Real-Time Data Visualization**
   - Works with Serial and WiFi connections.
   - Supports up to 4 ports.
2. **Graph Settings**
   - Set upper and lower limits for data.
3. **Dynamic Window Resizing**
   - Automatically adjusts when the window size changes.
4. **Change UI Theme**
   - Easily switch the app’s theme.
   - Go to: Form (Designer) > KryptonPalette > BasePalette > Select.
   - Themes available: Office Black, Blue, Silver, Custom.
   - **Custom Theme**: Can be edited in the Krypton Palette.

**Default Window Size**: 1940 x 1080

## Troubleshooting

### Common Errors

#### ‘TableLayoutPanel not found in Krypton.Toolkit’

**Problem**: You're using an old version of the Toolkit.

**Solution**: Update to the latest version from NuGet.

#### File cannot be processed because it is in a restricted or web-related zone

**Problem**: The file is blocked because it came from the internet.

**Solution**:
1. Right-click the `.zip` file.
2. Select "Properties".
3. Click "Unblock" (if you see this option).
4. Delete the project folder.
5. Unzip the file again.
6. Open the new project.

#### ‘Form1.cs[Designer] not showing’

**Problem**: The Designer doesn’t appear.

**Solution**:
- If you have the latest version of `Krypton.Toolkit`, build the solution once.
- If that doesn’t work, close the project and reopen it.
