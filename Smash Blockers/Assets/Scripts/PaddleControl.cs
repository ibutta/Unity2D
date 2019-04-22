using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControl : MonoBehaviour
{

    [SerializeField]
    Camera sceneCam;
    int screenUnitWidth, spriteUnitWidth;
    private Vector2 paddlePos = new Vector2();

    // Start is called before the first frame update
    void Start()
    {

        Vector2 spriteRect = GetComponent<SpriteRenderer>().sprite.rect.size;
        spriteUnitWidth = (int)(spriteRect.x / GetComponent<SpriteRenderer>().sprite.pixelsPerUnit);
        screenUnitWidth = (int)((sceneCam.orthographicSize * 2) * sceneCam.aspect);

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
