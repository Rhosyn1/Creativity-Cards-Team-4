using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class JournalScript: MonoBehaviour
{
    //creating images
    public Image crabImage;
    public Image fishImage;
    public Image jellyfishImage;
    public Image morayImage;
    public Image seahorseImage;
    public Image seaweedImage;
    public Image sharkImage;
    public Image squidImage;

    //storing true or false if that type of fish has been found (setting all to false to  begin with)
    public bool crabFound = false;
    public bool fishFound = false;
    public bool jellyfishFound = false;
    public bool morayFound = false;
    public bool seahorseFound = false;
    public bool seaweedFound = false;
    public bool sharkFound = false;
    public bool squidFound = false;

    //checking for trigger
    public void onTriggerEnter(Collider other)
    {
        //checking tags
        if (other.CompareTag("Crab"))
        {
            //over the cover
            crabImage.enabled = true;
            crabFound = true;

        }

        else if (other.CompareTag("Fish"))
        {
            fishImage.enabled = true;
            fishFound = true;
        }

        else if (other.CompareTag("Jellyfish"))
        {
            jellyfishFound = true;
        }

        else if (other.CompareTag("Moray"))
        {
            morayFound = true;
        }

        else if (other.CompareTag("Seahorse"))
        {
            seahorseFound = true;
        }

        else if (other.CompareTag("Seaweed"))
        {
            seaweedFound = true;
        }

        else if (other.CompareTag("Shark"))
        { 
            sharkFound = true;
        }

        else if (other.CompareTag("Squid"))
        {
            squidFound = true;
        }

        else
        {
            Debug.Log("None");
        }

    }

    public void turnPages()
    {
        if (crabFound == true && fishFound == true)
        {

            if (jellyfishFound == true && morayFound == true)
            {
                //disabling the images currently on pages
                crabImage.enabled = false;
                fishImage.enabled = false;

                //enabling the new images
                jellyfishImage.enabled = true;
                morayImage.enabled = true;

                if (seahorseFound == true && seaweedFound == true)
                {
                    jellyfishImage.enabled = false;
                    morayImage.enabled = false;

                    seaweedImage.enabled = true;
                    seahorseImage.enabled = true;

                    if (sharkFound == true && squidFound == true)
                    {
                        seaweedImage.enabled = false;
                        seahorseImage.enabled = false;

                        sharkImage.enabled = true;
                        squidImage.enabled = true;
                    }
                    else
                    {
                        Debug.Log("No more found");
                    }
                }
                else
                {
                    Debug.Log("No more found");
                }
            }
            else
            {
                Debug.Log("No more animals found");
            }
        }
        else
        {
            Debug.Log("Nothing found");
        }

    }

}
