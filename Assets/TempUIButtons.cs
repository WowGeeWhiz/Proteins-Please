using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TempUIButtons : MonoBehaviour
{
    public GameObject generateButton;
    public GameObject killButton;
    public GameObject acceptButton;
    public GameObject documentButton;
    public TMP_Text healthAllow;
    public TMP_Text healthKill;
    public TMP_Text cancerAllow;
    public TMP_Text cancerKill;

    public GameManager gameManager;
    private void Start()
    {
        
    }
    private void Update()
    {
        healthAllow.text = "Healthy Allowed: " + gameManager.GetHealthyAllowed();
        healthKill.text = "Healthy Killed: " + gameManager.GetHealthyTerminated();
        cancerAllow.text = "Cancer Allowed: " + gameManager.GetCancerAllowed();
        cancerKill.text = "Cancer Killed: " + gameManager.GetCancerTerminated();
    }
    public void GenerateButton()
    {
        generateButton.SetActive(false);
        killButton.SetActive(true);
        acceptButton.SetActive(true);
        documentButton.SetActive(true);
    }
    public void DocumentButton()
    {
        documentButton.SetActive(false);
    }
    public void ChoiceButtons()
    {
        documentButton.SetActive(false);
        killButton.SetActive(false);
        acceptButton.SetActive(false);
        generateButton.SetActive(true);
    }
}
