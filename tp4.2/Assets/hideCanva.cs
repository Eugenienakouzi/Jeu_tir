using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideCanva : MonoBehaviour


{
    public GameObject CanvaMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Hide()
    {
        CanvaMenu.SetActive(false);
    }
}
