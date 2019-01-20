﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTracker : MonoBehaviour{
    public static bool hasKey;
    public static bool movedBS;
    public static bool hasJacket;
	public static bool CRclosed;
	public static bool hasDS;
	public static bool Oclosed;
	public static bool foundVent;
	public static bool hasSS;
	public static bool foundRope;
	public static bool hasSD;
	public static bool Vclosed;
	public static bool faucetOn;
	public static bool usedDS;
	public static bool fixedBS;
	public static bool timesUp;

    void Awake() {
        hasKey = false;
        movedBS = false;
        hasSD = false;
        hasSS = false;
        hasDS = false;
        hasJacket = false;
        CRclosed = true;
        Oclosed = true;
        Vclosed = true;
        foundRope = false;
        foundVent = false;
        faucetOn = false;
        usedDS = false;
        fixedBS = false;
        timesUp = false;
    }
}
