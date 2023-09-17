using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning : MonoBehaviour
{
    public GameObject tooltip; //<--Assign in inspector & deactivate.
    public float tooltipDuration = 2;
 
    IEnumerator OnMouseUp() {
    tooltip.SetActive(true);
            yield return new WaitForSeconds(tooltipDuration);
    tooltip.SetActive(false);
        }
    
}
