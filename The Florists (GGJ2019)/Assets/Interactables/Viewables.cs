﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Viewables : Interactable {

	public Sprite image;

    override public IEnumerator run(Freeroam p) {
        p.freeze();
        yield return StartCoroutine(showImage(image));
        p.unfreeze();
    }
}
