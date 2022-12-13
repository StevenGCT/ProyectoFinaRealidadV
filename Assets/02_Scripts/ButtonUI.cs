using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUI : MonoBehaviour
{
    public GameObject Plant1;
    public GameObject Plant2;
    public GameObject Plant3;
    public GameObject Plant4;
    public GameObject Plant5;
    public int PlantActual = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(PlantActual)
        {
            case 1:
                Plant1.SetActive(true);
                Plant2.SetActive(false);
                Plant3.SetActive(false);
                Plant4.SetActive(false);
                Plant5.SetActive(false);
            break;
            case 2:
                Plant1.SetActive(false);
                Plant2.SetActive(true);
                Plant3.SetActive(false);
                Plant4.SetActive(false);
                Plant5.SetActive(false);
            break;
            case 3:
                Plant1.SetActive(false);
                Plant2.SetActive(false);
                Plant3.SetActive(true);
                Plant4.SetActive(false);
                Plant5.SetActive(false);
            break;
            case 4:
                Plant1.SetActive(false);
                Plant2.SetActive(false);
                Plant3.SetActive(false);
                Plant4.SetActive(true);
                Plant5.SetActive(false);

            break;
            case 5:
                Plant1.SetActive(false);
                Plant2.SetActive(false);
                Plant3.SetActive(false);
                Plant4.SetActive(false);
                Plant5.SetActive(true);
            break;
        }
    }

    public void NextPlant()
    {
        PlantActual++;
        if (PlantActual >5)
        {
            PlantActual = 1;
        }
    }

    public void PreviousPlant()
    {
        PlantActual--;
        if (PlantActual < 1)
        {
            PlantActual = 5;
        }
    }
}
