### 日本語版 README (日本語)
<div align="center">
<a href="https://github.com/Harrot114514/AliceInCradle-NoMosaicMod/blob/main/README.md">中文</a> | 
<strong>日本語</strong> | 
<a href="https://github.com/Harrot114514/AliceInCradle-NoMosaicMod/blob/main/language-readme/readme_EN.md">English</a>
</div>

# <div align="center">AliceInCradle モザイク解除MOD</div>
UnityModManagerを使用してゲーム内のモザイク処理を動的に無効化するMOD  
※本MODはゲームバージョン0.27向けに作成されています

## 📜 ライセンス
Apache-2.0ライセンスで公開しています（修正・再配布自由）

## 🛠 導入方法
### 1. UnityModManager(UMM)のインストール
[公式サイト](https://www.nexusmods.com/site/mods/21)からダウンロードしてください

### 2. 設定ファイルの追加
UMMフォルダ内の`UnityModManagerConfig.xml`を編集：
```xml
<!-- 既存の設定の下に追記 -->
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

### 3. MODの導入
1. UMMインストーラでゲームを選択
2. `Install`ボタンをクリック
3. `Mods`フォルダに`NoMosaic.zip`を配置

## 🎮 使用方法
### 動作確認
ゲーム起動後、UMMメニューにMODが表示されれば成功  
![確認画像](https://github.com/Harrot114514/AliceInCradle-NoMosaicMod/blob/main/images/1.png)

### 有効/無効切り替え
UMMメニューからワンクリックで操作可能  
![操作GIF](https://github.com/Harrot114514/AliceInCradle-NoMosaicMod/blob/main/images/202505280132%20(1).gif)

## ❓ トラブルシューティング
問題が発生した場合：
1. インストール手順を再確認
2. [Bilibiliサポート](https://space.bilibili.com/1732976071)までご連絡

