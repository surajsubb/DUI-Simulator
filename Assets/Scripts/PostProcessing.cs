using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessing : MonoBehaviour
{
    public PostProcessVolume volume; 

    private ChromaticAberration _Cromatic;
    private DepthOfField _DoF;
    

    void Start()
    {
        volume.profile.TryGetSettings(out _Cromatic);
        _Cromatic.intensity.value = 0;

        volume.profile.TryGetSettings(out _DoF);
        _DoF.aperture.value = 3;
        _DoF.focusDistance.value = 1;
        _DoF.focalLength.value = 1;

        
    }

    // Update is called once per frame
    void Update()
    {
        //TODO
        //Change how much value increases as threshold increases
        
        _Cromatic.intensity.value = _Cromatic.intensity.value+0.001f;
        // _DoF.aperture.value = _DoF.aperture.value-0.1f;
        // _DoF.focusDistance.value = _DoF.focusDistance.value-0.1f;
        _DoF.focalLength.value = _DoF.focalLength.value+0.01f;
        

        
    }
}
