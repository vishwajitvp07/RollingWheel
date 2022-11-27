using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SliderBar : MonoBehaviour
{

    [SerializeField]public GameObject playerGO;
    [SerializeField]public GameObject Finish;
    Image progessbar;
    float maxdistance;
    private void Start()
    {
        progessbar = GetComponent<Image>();
        maxdistance = Finish.transform.position.z;
        progessbar.fillAmount = playerGO.transform.position.z / maxdistance;
    }
    private void Update()
    {
        if (progessbar.fillAmount < 1)
        {
            progessbar.fillAmount = playerGO.transform.position.z / maxdistance;
        }
    }
}
