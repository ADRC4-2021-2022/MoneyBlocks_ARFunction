using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
///<summary>
///
///</summary>
public class UIController : MonoBehaviour
{

    private GameObject buttonLeft;

    private GameObject buttonRight;

    private GameObject buttonUp;

    private GameObject buttonDown;

    private GameObject buttonIn;

    private GameObject buttonOut;

    private GameObject buttonRotate;

    private GameObject buttonRotate2;

    private GameObject buttonNext;

    

    void Start()
    {
        buttonLeft = GameObject.Find("ButtonLeft");
        buttonRight = GameObject.Find("ButtonRight");
        buttonUp = GameObject.Find("ButtonUp");
        buttonDown = GameObject.Find("ButtonDown");
        buttonIn = GameObject.Find("ButtonIn");
        buttonOut = GameObject.Find("ButtonOut");
        buttonRotate = GameObject.Find("ButtonRotate");
        buttonRotate2 = GameObject.Find("ButtonRotate2");
        buttonNext = GameObject.Find("ButtonNext");

        buttonLeft.GetComponent<Button>().onClick.AddListener(ButtonLeft);
        buttonRight.GetComponent<Button>().onClick.AddListener(ButtonRight);
        buttonUp.GetComponent<Button>().onClick.AddListener(ButtonUp);
        buttonDown.GetComponent<Button>().onClick.AddListener(ButtonDown);
        buttonIn.GetComponent<Button>().onClick.AddListener(ButtonIn);
        buttonOut.GetComponent<Button>().onClick.AddListener(ButtonOut);
        buttonRotate.GetComponent<Button>().onClick.AddListener(ButtonRotate);
        buttonRotate2.GetComponent<Button>().onClick.AddListener(ButtonRotate2);
        buttonNext.GetComponent<Button>().onClick.AddListener(ButtonNext);





    }



    public void ButtonLeft()
    {

        transform.position += new Vector3(-1, 0, 0);

    }

    public void ButtonRight()
    {

        transform.position += new Vector3(1, 0, 0);

    }

    public void ButtonUp()
    {

        transform.position += new Vector3(0, 1, 0);

    }

    public void ButtonDown()
    {

        transform.position += new Vector3(0, -1, 0);

    }

    public void ButtonIn()
    {

        transform.position += new Vector3(0, 0, 1);

    }

    public void ButtonOut()
    {

        transform.position += new Vector3(0, 0, -1);

    }

    public void ButtonRotate()
    {

        transform.Rotate(0, 0, -90);

    }

    public void ButtonRotate2()
    {

        transform.Rotate(0, -90, 0);

    }

    public void ButtonNext()
    {




        FindObjectOfType<Spawner>().SpawnNext();

        enabled = false;





    }






}

