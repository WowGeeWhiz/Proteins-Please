using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellShooter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localPosition += new Vector3(10f * Time.deltaTime, 0, 0);
    }
}