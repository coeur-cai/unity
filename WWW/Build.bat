@echo off
@set unity="D:\install\Unity2017.4.26f1\Unity\Editor\Unity.exe"
@set projectPath="C:\Users\caimin.caimin\unity\WWW"
echo BuildUnityWWWAPK
echo 正在生成apk文件....
%unity% -batchmode -quit -nographics -executeMethod BatchMode.UnityBuildAndroid -logFile D:\UnityEditor.log -projectPath %projectPath%
echo APK生成完毕
pause