using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSurface : MonoBehaviour
{
    // Start is called before the first frame update

    void Update()
    {
        this.transform.position = this.transform.position - Vector3.left*Time.deltaTime * GameManager.Instance.speed;
    }
}
