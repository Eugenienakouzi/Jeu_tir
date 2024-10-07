using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearGun : MonoBehaviour
{
    public GameObject Gun;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void ShowGun()
    {
        Gun.gameObject.SetActive(true);
    }
}
