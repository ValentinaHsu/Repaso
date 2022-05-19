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

    // Use this for initialization
    void Start () {
        isRotated = false;
        originalRotado = myObject.transform.eulerAngles;
        originalEscalado = myObject.transform.localScale;
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R))
        {
            if (isRotated)
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
	}
}
