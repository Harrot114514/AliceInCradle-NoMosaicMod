### English Version README (English)
<div align="center">
<a href="https://github.com/Harrot114514/AliceInCradle-NoMosaicMod/blob/main/README.md">中文</a> | 
<a href="https://github.com/Harrot114514/AliceInCradle-NoMosaicMod/blob/main/language-readme/readme_JP.md">日本語</a> | 
<strong>English</strong>
</div>

# <div align="center">AliceInCradle NoMosaic Mod</div>
Dynamically disable mosaic effects in AliceInCradle using UnityModManager  
*Compatible with game version 0.27*

## 📜 License
Licensed under Apache-2.0 (modification and redistribution allowed)

## 🛠 Installation Guide
### 1. Install UnityModManager(UMM)
Download from [official site](https://www.nexusmods.com/site/mods/21)

### 2. Add Game Configuration
Edit `UnityModManagerConfig.xml` in UMM folder:
```xml
<!-- Add below existing configurations -->
<GameInfo Name="AliceInCradle">
  <Folder>AliceInCradle</Folder>
  <ModsDirectory>Mods</ModsDirectory>
  <ModInfo>Info.json</ModInfo>
  <GameExe>AliceInCradle.exe</GameExe>
  <EntryPoint>[UnityEngine.UIModule.dll]UnityEngine.Canvas.cctor:Before</EntryPoint>
  <StartingPoint>[Assembly-CSharp.dll]nel.UiBox.Awake:Before</StartingPoint>
  <MinimalManagerVersion>0.12.0</MinimalManagerVersion>
</GameInfo>
```

### 3. Install Mod
1. Select game in UMM installer
2. Click `Install` button
3. Place `NoMosaic.zip` in `Mods` folder

## 🎮 Usage
### Verification
MOD will appear in UMM menu after successful installation  
![Confirmation](https://github.com/Harrot114514/AliceInCradle-NoMosaicMod/blob/main/images/1.png)

### Toggle Function
One-click enable/disable via UMM menu  
![Demo](https://github.com/Harrot114514/AliceInCradle-NoMosaicMod/blob/main/images/202505280132%20(1).gif)

## ❓ Troubleshooting
If encountering issues:
1. Recheck installation steps
2. Contact via [Bilibili Support](https://space.bilibili.com/1732976071)

