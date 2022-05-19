using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranformManager : MonoBehaviour {
    public GameObject myObject;

    public GameObject rotado;
    public GameObject escalado;
    public GameObject rotadoEscalado;

    public Vector3 originalRotado;
    public Vector3 originalEscalado;

    public bool isRotated;
    public bool isScaled;

    // Use this for initialization
    void Start () {
        isRotated = false;
        isScaled = false;
        originalRotado = myObject.transform.eulerAngles;
        originalEscalado = myObject.transform.localScale;
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R))
        {
            if (isRotated==true)
            {
                myObject.transform.eulerAngles = originalRotado;
                isRotated = false;
            }
            else
            {
                myObject.transform.eulerAngles = rotado.transform.eulerAngles;
                isRotated = true;
            }
            
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isScaled == true)
            {
                myObject.transform.localScale = originalEscalado;
                isScaled = false;
            }
            else
            {
                myObject.transform.localScale = escalado.transform.localScale;
                isScaled = true;
            }

        }
    }
}
