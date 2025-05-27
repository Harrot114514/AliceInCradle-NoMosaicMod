# AliceInCradle-NoMosaicMod
通过mod动态禁用AliceInCradle中的打码处
## 模组使用方法
### 1.首先你需要有umm（UnityModManager）
这一步您可以自己寻找下载，[UMM官网](https://www.nexusmods.com/site/mods/21)
### 2.安装
注意，该游戏暂没有配置文件，所以我自己写了，使用时先打开你的umm文件夹，找到UnityModManagerConfig.xml，打开它，在大概16行左右的	
~~~
<!--<GameInfo Name="Oxygen Not Included">
...
</GameInfo>-->
~~~
处按回车，输入以下代码
~~~
<GameInfo Name="AliceInCradle">
		<Folder>AliceInCradle</Folder>
		<ModsDirectory>Mods</ModsDirectory>
		<ModInfo>Info.json</ModInfo>
		<GameExe>AliceInCradle.exe</GameExe>
		<EntryPoint>[UnityEngine.UIModule.dll]UnityEngine.Canvas.cctor:Before</EntryPoint>
		<StartingPoint>[Assembly-CSharp.dll]nel.UiBox.Awake:Before</StartingPoint>
		<MinimalManagerVersion>0.12.0</MinimalManagerVersion>
	</GameInfo>
~~~
之后保存，打开umm安装器(UnityModManager.exe这个文件)，在下行的Game选择AliceInCradle，再下一行的Folder单击找到自己的游戏目录打开（其中有游戏本体AliceInCradle.exe），然后点击Install，在上方找到Mods，点击进入，将我的mod(即NoMosaic.zip)拖入下方的虚线框里，即安装完毕
### 3.游戏内用法
