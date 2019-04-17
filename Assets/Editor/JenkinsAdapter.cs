﻿using System.Collections.Generic;
using UnityEditor;

public  class JenkinsAdapter
{
   // [MenuItem("Jenkins/JenkinsBuild")] 
    public static void Build() {
        EditorUserBuildSettings.SwitchActiveBuildTarget( BuildTarget.Android);
        List<string> sceneList = new List<string>();
        EditorBuildSettingsScene[] temp = EditorBuildSettings.scenes;
        for (int i = 0, iMax = temp.Length; i < iMax; ++i) sceneList.Add(temp[i].path);
        BuildPipeline.BuildPlayer(sceneList.ToArray(), "./test.apk", BuildTarget.Android, BuildOptions.None);
        
    }
}