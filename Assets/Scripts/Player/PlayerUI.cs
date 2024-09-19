using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public PlayerClass playerClass;
    public TextMeshProUGUI playerNameText;
    public TextMeshProUGUI playerHealthText;
    // Start is called before the first frame update
    void Start()
    {
        playerNameText.text = playerClass.name;
        playerHealthText.text = playerClass.health.ToString();
    }

    
}
