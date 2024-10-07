using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearTable : MonoBehaviour
{
    public GameObject table;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void ShowTable()
    {
        table.gameObject.SetActive(true);
    }
}
