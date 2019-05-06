using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    float screenUnitWidth, spriteUnitWidth;
    private Vector2 paddlePos;

    // Start is called before the first frame update
    void Start()
    {
        paddlePos = new Vector2();
        Vector2 spriteRect = GetComponent<SpriteRenderer>().sprite.rect.size;
        spriteUnitWidth = (spriteRect.x / GetComponent<SpriteRenderer>().sprite.pixelsPerUnit);
        screenUnitWidth = ((Camera.main.orthographicSize * 2) * Camera.main.aspect);

    }

    // Update is called once per frame
    void Update()
    {

        paddlePos.Set(GetScreenUnitX(), transform.position.y);
        paddlePos.x = Mathf.Clamp(paddlePos.x, 0, (screenUnitWidth - spriteUnitWidth));
        transform.position = paddlePos;

    }

    private float GetScreenUnitX()
    {

        return ((Input.mousePosition.x / Screen.width) * screenUnitWidth);

    }
}
