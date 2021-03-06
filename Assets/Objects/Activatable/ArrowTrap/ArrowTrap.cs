﻿using UnityEngine;
using System.Collections;

public class ArrowTrap : Activatable {

	private ParticleSystem arrowParticles;

	void Start()
	{
		arrowParticles = this.GetComponentInChildren<ParticleSystem>();
	}

	public override void Activate ()
	{
		if (arrowParticles != null)
		{
			arrowParticles.Play();
			Destroy(arrowParticles, arrowParticles.duration);
		}
	}

	public override void Deactivate()
	{
		// Nothing (arrow trap can't be deactivated as its a one shot device)
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player" && arrowParticles != null && arrowParticles.isPlaying)
		{
			print ("Kill player!");
		}
	}
}
