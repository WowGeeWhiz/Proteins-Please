using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathGame : MonoBehaviour
{
    int cancerCellsCaught = 0;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void UpdateCancerCellsCaught(int caught)
    {
        cancerCellsCaught = caught;
    }
}
