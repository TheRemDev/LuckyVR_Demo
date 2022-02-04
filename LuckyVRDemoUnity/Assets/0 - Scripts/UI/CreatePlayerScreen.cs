using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CreatePlayerScreen : MonoBehaviour
{
    [SerializeField] private TMP_InputField m_playerNameInputField;
    [SerializeField] private Button m_button;

    private void Awake()
    {
        m_button.interactable = false;
    }

    public void ValidatePlayerName(string str)
    {
        if (str == string.Empty)
        {
            m_button.interactable = false;
        }
        else
        {
            m_button.interactable = true;
        }
    }

    public void OnOkButtonPressed()
    {
        //FindObjectOfType<Player>().SetPlayerName(m_playerNameInputField.text);
        FindObjectOfType<DataManager>().playerName = m_playerNameInputField.text;
        UIManager.Instance.SwapScreen(2);
    }

}
