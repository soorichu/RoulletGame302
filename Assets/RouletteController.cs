using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0.0f;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10.0f;
        }

        if (Input.GetMouseButtonDown(1))
        {
            this.rotSpeed = 0.0f;
        }

        // rotSpeed의 속도를 서서히 0으로 만드는 코드를 넣으면 된다.
        this.rotSpeed *= 0.987f;

        transform.Rotate(0, 0, this.rotSpeed);
    }
}
