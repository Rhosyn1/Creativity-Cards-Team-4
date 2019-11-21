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

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
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

    public void turnPageRight1()
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

        button1.SetActive(false);
        button2.SetActive(true);
      
    }

    public void turnPageRight2()
    {
        jellyfishImage.SetActive(false);
        morayImage.SetActive(false);

        if (seahorseFound == true && seaweedFound == true)
        {
            seahorseImage.SetActive(true);
            seaweedImage.SetActive(true);
        }
        else if (seahorseFound == true && seaweedFound != true)
        {
            seahorseImage.SetActive(true);
        }
        else if (seahorseFound != true && seaweedFound == true)
        {
            seaweedImage.SetActive(true);
        }
        else
        {
            Debug.Log("No");
        }

        button2.SetActive(false);
        button3.SetActive(true);

    }

    public void turnPageRight3()
    {
        seahorseImage.SetActive(false);
        seaweedImage.SetActive(false);

        if (sharkFound == true && squidFound == true)
        {
            sharkImage.SetActive(true);
            squidImage.SetActive(true);
        }
        else if (sharkFound == true && squidFound != true)
        {
            sharkImage.SetActive(true);
        }
        else if (sharkFound != true && squidFound == true)
        {
            squidImage.SetActive(true);
        }
        else
        {
            Debug.Log("No");
        }

        button3.SetActive(false);

    }

   





}
