using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    public GameObject Ui;
    public GameObject Description1;
    public GameObject Description2;
    public GameObject Description3;
    public GameObject Description4;
    public GameObject Description5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit)){
            if (hit.collider.gameObject.CompareTag("Plant1"))
            {
                Ui.SetActive(false);
                Description1.SetActive(true);
            }
            else
            {
                if (hit.collider.gameObject.CompareTag("Plant2"))
                {
                    Ui.SetActive(false);
                    Description2.SetActive(true);                
                }
                else 
                {
                    if (hit.collider.gameObject.CompareTag("Plant3"))
                    {
                        Ui.SetActive(false);
                        Description3.SetActive(true);    
                    }
                    else
                    {
                        if (hit.collider.gameObject.CompareTag("Plant4"))
                        {
                            Ui.SetActive(false);
                            Description4.SetActive(true);   
                        }
                        else
                        {
                            if (hit.collider.gameObject.CompareTag("Plant5"))
                            {
                                Ui.SetActive(false);
                                Description5.SetActive(true);   
                            }
                        }
                    }
                }
            }
        }
    }
}
