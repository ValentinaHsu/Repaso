using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDeactivate : MonoBehaviour {
    public GameObject myObject;

	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            //if (myObject.activeInHierarchy == true)
            //{
            //    myObject.SetActive(false);
            //}
            //else
            //{
            //    myObject.SetActive(true);
            //}
            myObject.SetActive(!myObject.activeInHierarchy);
            
        }
	}
}
