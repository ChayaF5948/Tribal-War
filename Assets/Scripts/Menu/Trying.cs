using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Trying : MonoBehaviour
{
    string saveFiles;
    string JsonString = "ggg";

    // Start is called before the first frame update
    void Start()
    {
        saveFiles = Application.persistentDataPath + "/gamedata.json";
    }

    public void readFile()
    {
        if (File.Exists(saveFiles))
        {
            string fileContents = File.ReadAllText(saveFiles);          
        }
    }

    public void writerFile()
    {
        File.WriteAllText(saveFiles, JsonString );

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
