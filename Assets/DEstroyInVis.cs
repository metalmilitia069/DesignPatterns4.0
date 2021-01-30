using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEstroyInVis : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
