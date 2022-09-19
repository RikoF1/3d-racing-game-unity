using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;
    public GameObject LapTimeBox;

    public GameObject LapCounter;
    public int LapsDone; //lap number container

    public float RawTime;

    public GameObject RaceFinish;

    void Update () {
        if (LapsDone == 3) {
            RaceFinish.SetActive (true);
        }
    }

    void OnTriggerEnter (){
        LapsDone += 1;
        RawTime = PlayerPrefs.GetFloat ("RawTime");
        if (LapTimeManager.RawTime <= RawTime){
        if (LapTimeManager.SecondCount <= 9) {
            SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
        }
        else {
            SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";
        }
        if (LapTimeManager.MinuteCount <= 9) {
            MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ".";
        }
        else {
            MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ".";
        }

        MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount;
    }
// save player best lap time
        PlayerPrefs.SetInt ("MinSave", LapTimeManager.MinuteCount);
        PlayerPrefs.SetInt ("SecSave", LapTimeManager.SecondCount);
        PlayerPrefs.SetFloat ("MilliSave", LapTimeManager.MilliCount);
        PlayerPrefs.SetFloat ("RawTime", LapTimeManager.RawTime); //setting time

//reset time
        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;
        LapTimeManager.RawTime = 0; //reset time
        LapCounter.GetComponent<Text>().text = "" + LapsDone;

        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
    }
}
