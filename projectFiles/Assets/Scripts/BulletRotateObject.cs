using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletRotateObject : MonoBehaviour
{
    public float speed = 2f;
 private void OnCollisionEnter(Collision col)
 {
 if (col.gameObject.tag == "Dreamcar01")
    {
      // Destroy (col.gameObject);
     // col.gameObject.transform.Rotate(0,30f,0, Space.World);
      col.gameObject.transform.Rotate (new Vector3 (0, 360, 0) * speed * Time.deltaTime);
    }
  }
}
