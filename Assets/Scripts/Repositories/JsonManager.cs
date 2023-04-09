using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JsonManager : IJsonManager
{

    public List<List<int>> GetMazeData()
    {
        TextAsset dataMaze = Resources.Load("robot.json") as TextAsset;
        List<List<int>> jsonMaze = JsonUtility.FromJson<List<List<int>>>(dataMaze.text);
        return jsonMaze;
    }



}
