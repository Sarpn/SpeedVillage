using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class bar : MonoBehaviour
{

    public float hungerDelta = 1;
    public GameObject statusBar;
    private Vector3 scaleChange;
    public float actualStatus = 100;

    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        actualStatus -= hungerDelta * Time.deltaTime;
        scaleChange = new Vector3(0.08f, 1f, (actualStatus)  /100);
        statusBar.transform.localScale = scaleChange;
    }
}
