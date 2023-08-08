using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirLineControl : MonoBehaviour
{
    public LineRenderer LineRenderer;
    public GameObject 无人机1;
    public GameObject 无人机2;
    public float width = 2;
    // Start is called before the first frame update
    void Start()
    {
        LineRenderer.positionCount = 2;
    }

    // Update is called once per frame
    void Update()
    {
        LineRenderer.startWidth = width;
        LineRenderer.endWidth = width;

        LineRenderer.SetPosition(0,无人机1.transform.localPosition);
        LineRenderer.SetPosition(1,无人机2.transform.localPosition);       

    }
}
 