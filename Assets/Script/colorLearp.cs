using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorLearp : MonoBehaviour
{
   
    MeshRenderer myrenderer;
    [SerializeField] [Range(0f, 1f)] float learptime;
    [SerializeField] Color[] mycolors;
    int colorindex = 0;
    float t = 0f;
    int len;
    private void Start()
    {
        myrenderer = GetComponent<MeshRenderer>();
        len = mycolors.Length;
    }
    private void Update()
    {
        myrenderer.material.color = Color.Lerp(myrenderer.material.color, mycolors[colorindex], learptime*Time.deltaTime);
        t = Mathf.Lerp(t, 1f, learptime * Time.deltaTime);
        if(t>.9f)
        {
            t = 0f;
            colorindex++;
            colorindex = (colorindex >=len) ? 0 : colorindex;
        }

    }
}
