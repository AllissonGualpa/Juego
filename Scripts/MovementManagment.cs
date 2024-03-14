using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManagments : MonoBehaviour
{
    public Sprite[] mySprites;
    private int index = 0;
    private SpriteRenderer mySpriteRenderer;

    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(WalkCoRoutine());
    }

    IEnumerator WalkCoRoutine()
    {
        yield return new WaitForSeconds(0.05f);
        mySpriteRenderer.sprite = mySprites[index];
        index = (index + 1) % mySprites.Length; // Simplifica la lógica del índice
        StartCoroutine(WalkCoRoutine());
    }
}
