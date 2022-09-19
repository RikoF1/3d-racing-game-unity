using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject NormalCam;
    public GameObject FarCam;
    public GameObject HoodCam; //FPCam
    public int CamMode;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown ("Viewmode")) {
            if (CamMode == 2) {
                CamMode = 0;
            }
            else {
                CamMode += 1;
            }
            StartCoroutine(ModeChange());
        }
    }

    IEnumerator ModeChange (){
        yield return new WaitForSeconds(0.01f);
        if (CamMode == 0){
            NormalCam.SetActive (true);
            HoodCam.SetActive (false);
        }
        if (CamMode == 1){
            FarCam.SetActive (true);
            NormalCam.SetActive (false);
        }
        if (CamMode == 2){
            HoodCam.SetActive (true);
            FarCam.SetActive (false);
        }
    }
}
