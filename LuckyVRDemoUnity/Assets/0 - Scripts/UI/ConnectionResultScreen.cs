using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConnectionResultScreen : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_resultTextLabel;

    public void SetupDisplayText(string str)
    {
        m_resultTextLabel.text = str;
    }
}


