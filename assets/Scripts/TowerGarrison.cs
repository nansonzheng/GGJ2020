﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerGarrison : Garrison
{
    // Start is called before the first frame update
	TowerAttack attack;
    protected override void Start()
    {
        base.Start();
		attack = GetComponent<TowerAttack>();
    }
	
	void Update(){
		attack.manned = (units.Count != 0);
	}

	public float GetTotalCooldown(float cd){
		cd = cd / Mathf.Sqrt(units.Count);
		return cd;
	}
	
	public int GetTotalAttack(int attack){
		attack += units.Count * 3;
		return attack;
	}
}
