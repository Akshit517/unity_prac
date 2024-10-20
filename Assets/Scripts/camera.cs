using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    private Vector3 initialposition;
    private void Start(){
        initialposition = transform.position;
    }

    private void LateUpdate() {
        transform.position = initialposition;
    }

}
