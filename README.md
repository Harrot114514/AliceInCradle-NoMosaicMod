<div align="center">
<strong>中文</strong> | 
<a href="https://github.com/Harrot114514/AliceInCradle-NoMosaicMod/blob/main/language-readme/readme_JP.md">日本語</a> | 
<a href="https://github.com/Harrot114514/AliceInCradle-NoMosaicMod/blob/main/language-readme/readme_EN.md">English</a>
</div>

# <div align="center" >AliceInCradle-NoMosaicMod</div>
### mod原理
*本模组使用umm管理器实行动态加载，并非直接反编译修改，是通过mod动态禁用AliceInCradle中的打码处  
### 注意
*本mod是一个r18模组
*本模组基于游戏0.27版本制作  
### 联系我
B站主页:[不会起名的萝卜君](https://space.bilibili.com/1732976071?spm_id_from=333.1007.0.0)  
### 许可证
*本项目使用Apache-2.0许可证，但您可以自由修改发布（选的时候搞错了），我并不会追究  
### 其他
*由于某些原因，原图带马赛克，故无法去除（目前正在研究）
## 模组使用方法
### 我这里提供一种更简单的模组加载器的安装，因为游戏是使用Unity引擎制作
### 1.首先你需要有umm（UnityModManager，后文统称umm或UMM）
这一步您须自己寻找下载，[UMM官网](https://www.nexusmods.com/site/mods/21)
### 2.安装
注意，该游戏暂没有配置文件，所以我自己写了，使用时先打开你的umm文件夹，找到UnityModManagerConfig.xml，打开它，在大概5~16行左右的	
~~~
<!--<GameInfo Name="Oxygen Not Included">
...（一堆代码）
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
#### (1).检查是否安装成功
若无问题，打开游戏在闪过unity的logo后umm会正常显示，如图
![图1](https://github.com/Harrot114514/AliceInCradle-NoMosaicMod/blob/main/images/1.png)
![动图](https://github.com/Harrot114514/AliceInCradle-NoMosaicMod/blob/main/images/202505280132%20(1).gif)
其中第一个NoMosaicMod即为本模组
#### (2).mod的启用与禁用
因本人的技术力有限，只能做到使用模组的启用与禁用来控制效果，第一次使用时默认关闭，如需要打开如图所示点击这个即可
![图2](https://github.com/Harrot114514/AliceInCradle-NoMosaicMod/blob/main/images/3.png)
打开的话再点一下即可
#### (3).检查mod是否生效
因为一些原因，这里不方便放演示图，还请您进游戏后自行对比
# 若出现任何问题请回忆自己是否哪一步做错了，实在不行再来B站找我
