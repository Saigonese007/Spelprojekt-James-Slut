using System.Collections.Generic;
using UnityEngine;

public class Utility : MonoBehaviour
{
    public static Dictionary<string, string> saveData = new Dictionary<string, string>();

    public static void PrintSaveData()
    {
        Debug.Log("Contents of save data:");

        foreach (var item in saveData)
        {
            Debug.Log(item.Key + " : " + item.Value);
        }
    }
}
