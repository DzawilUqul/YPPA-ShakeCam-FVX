using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CinemachineShake : MonoBehaviour
{
    public static CinemachineShake Instance {get; private set;}
    private CinemachineVirtualCamera cinemachineVirtualCamera;
    private CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin;
    float shakeDuration;
    void Awake(){
        cinemachineVirtualCamera = GetComponent<CinemachineVirtualCamera>();
        cinemachineBasicMultiChannelPerlin = cinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

        Instance = this;
    }

//  Initialization how much intens, time in shake
    public void shakeCamera(float intensity, float time){

        cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = intensity;
        shakeDuration = time;
    }

    private void Update(){
        if(shakeDuration > 0){
            shakeDuration -= Time.deltaTime;
            if(shakeDuration <= 0f){
                // time is up
                cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = 0f;
            }
        }
    }
}
