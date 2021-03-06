﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : GeneralSquare {

    public override void Start()
    {
        base.Start();
        gameObject.SetActive(false);
    }

    protected override void LevelUp()
    {
        maxHealth += 3;
        health += 3;
        base.LevelUp();
    }
}
