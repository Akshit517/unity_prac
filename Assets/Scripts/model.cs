using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour {
    private Vector3 initialposition;
    private void Start(){
        initialposition = transform.position;
    }

    private void LateUpdate() {
        transform.position = initialposition;
    }

}
