using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Journal : MonoBehaviour
{
    public GameObject crabImage;
    public GameObject crabObject;
    public bool crabFound;

    public GameObject fishImage;
    public GameObject fishObject;
    public bool fishFound;

    public GameObject jellyfishImage;
    public GameObject jellyfishObject;
    public bool jellyfishFound;

    public GameObject morayImage;
    public GameObject morayObject;
    public bool morayFound;

    public GameObject seahorseImage;
    public GameObject seahorseObject;
    public bool seahorseFound;

    public GameObject seaweedImage;
    public GameObject seaweedObject;
    public bool seaweedFound;

    public GameObject sharkImage;
    public GameObject sharkObject;
    public bool sharkFound;

    public GameObject squidImage;
    public GameObject squidObject;
    public bool squidFound;


    public void comparingTags()
    {
        if (crabObject.CompareTag("Crab"))
        {
            crabFound = true;
        }
        else if (fishObject.CompareTag("Fish"))
        {
            fishFound = true;
        }
        else if (jellyfishObject.CompareTag("Jellyfish"))
        {
            jellyfishFound = true;
        }
        else if (morayObject.CompareTag("Moray"))
        {
            morayFound = true;
        }
        else if (seahorseObject.CompareTag("Seahorse"))
        {
            seahorseFound = true;
        }
        else if (seaweedObject.CompareTag("Seaweed"))
        {
            seaweedFound = true;
        }
        else if (sharkObject.CompareTag("Shark"))
        {
            sharkFound = true;
        }
        else if (squidObject.CompareTag("Squid"))
        {
            squidFound = true;
        }
        else
        {
            Debug.Log("Not found");
        }

    }

    public void displayOverlaysPage1()
    {
        if (crabFound == true && fishFound == true)
        {
            crabImage.SetActive(true);
            fishImage.SetActive(true);
        }
        else if (crabFound == true && fishFound != true)
        {
            crabImage.SetActive(true);
        }
        else if (crabFound != true && fishFound == true)
        {
            fishImage.SetActive(true);
        }
        else
        {
            Debug.Log("None found");
        }

    }

    public void turnPageRight()
    {
        crabImage.SetActive(false);
        fishImage.SetActive(false);

        if (jellyfishFound == true && morayFound == true)
        {
            jellyfishImage.SetActive(true);
            morayImage.SetActive(true);
        }
        else if (jellyfishFound == true && morayFound != true)
        {
            jellyfishImage.SetActive(true);
        }
        else if (jellyfishFound != true && morayFound == true)
        {
            morayImage.SetActive(true);
        }
        else
        {
            Debug.Log("No");
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            jellyfishImage.SetActive(false);
            morayImage.SetActive(false);

        }
      
    }

    

    

}
