using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class onColEnterSound : MonoBehaviour 
{

	public AudioClip ObjectHit_Surface;

	void Start ()
	{
		GetComponent<AudioSource> ().playOnAwake = false;

		GetComponent<AudioSource> ().clip = ObjectHit_Surface;
	}

	void onCollisionEnter(Collision other)
	{
		GetComponent<AudioSource> ().Play ();
	}

}
