﻿using UnityEngine;
using System.Collections;

public class BackgroundRepeater : MonoBehaviour {

    private Transform cameraTransform;
    private float spriteWidth;

	// Use this for initialization
	void Start () {
        cameraTransform = Camera.main.transform;

        SpriteRenderer spriteRender = GetComponent<Renderer>() as SpriteRenderer;
        spriteWidth = spriteRender.sprite.bounds.size.x;
	
	}
	
	// Update is called once per frame
	void Update () {
        if((transform.position.x + spriteWidth) < cameraTransform.position.x)
        {
            Vector3 newPos = transform.position;
            newPos.x += 2.0f * spriteWidth;
            transform.position = newPos;
        }
	
	}
}
