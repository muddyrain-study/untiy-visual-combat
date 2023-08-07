using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRenderControl : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public float width = 10f;   
    public float speed = 1.3f;
    public float offset = 0;    
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = transform.GetComponent<LineRenderer>();
        lineRenderer.positionCount = transform.childCount;
        ;
        for (int i = 0; i < transform.childCount; i++)    
        {
            lineRenderer.SetPosition(i, transform.GetChild(i).position);
            transform.GetChild(i).gameObject.SetActive(false);  
        }
    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;

        offset += Time.deltaTime * speed;
        lineRenderer.material.SetTextureOffset("_MainTex",new Vector2(offset,0));
    }
}
