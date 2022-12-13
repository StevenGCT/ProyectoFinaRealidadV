using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButonPg1 : MonoBehaviour
{
    public GameObject Ui;
    public GameObject Description;
    public GameObject Careful;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseDescription()
    {
        Description.SetActive(false);
        Careful.SetActive(true);
    }

    public void CloseAll()
    {
        Description.SetActive(false);
        Careful.SetActive(false);
        Ui.SetActive(true);
    }

    public void Back()
    {
        Description.SetActive(true);
        Careful.SetActive(false);
    }
}
