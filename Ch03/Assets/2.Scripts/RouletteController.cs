using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0f;
    public float startSpeed = 20f;
    float dRatio = 0.99f;
    float minSpeed = 0.1f;
    bool startDecrease = false;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = this.startSpeed;
        }

        if (Input.GetMouseButtonUp(0))
        {
            this.startDecrease = true;
        }
        
        transform.Rotate(0, 0, -rotSpeed);

        if (this.StartDecrease)
        {
            this.rotSpeed *= this.dRatio;
        }

        if(this.rotSpeed < this.minSpeed)
        {
            this.rotSpeed = 0f;
        }
    }
        
}
