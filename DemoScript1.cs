using UnityEngine;
using System.Collections;

public class DemoScript1 : MonoBehaviour {

    public Light myLight;
    private Rigidbody myRigi;

    void Awake()
    {
       myRigi = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            MyFunction();
        }
    }

    void MyFunction()
    {
        myLight.enabled = !myLight.enabled;

    }
}
