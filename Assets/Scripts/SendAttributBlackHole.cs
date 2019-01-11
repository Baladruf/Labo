using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using System;

public class SendAttributBlackHole : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		PostProcessVolume volume = gameObject.GetComponent<PostProcessVolume>();
		Vignette vigne;
		volume.profile.TryGetSettings(out vigne);
		if(vigne == null)
		{
			
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
