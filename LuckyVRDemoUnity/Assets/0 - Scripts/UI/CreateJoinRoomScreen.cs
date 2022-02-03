using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CreateJoinRoomScreen : MonoBehaviour
{
    [SerializeField] private TMP_InputField m_createRoomInputField;
    [SerializeField] private Button m_createRoomButton;
    [SerializeField] private TMP_InputField m_joinRoomInputField;
    [SerializeField] private Button m_joinRoomButton;

    private void Awake()
    {
        m_createRoomButton.interactable = false;
        m_joinRoomButton.interactable = false;
    }

    public void ValidateCreate(string str)
    {
        if (str == string.Empty)
        {
            m_createRoomButton.interactable = false;
        }
        else
        {
            m_createRoomButton.interactable = true;
        }
    }

    public void ValidateJoin(string str)
    {
        if (str == string.Empty)
        {
            m_joinRoomButton.interactable = false;
        }
        else
        {
            m_joinRoomButton.interactable = true;
        }
    }

    public void OnCreateRoomButtonPressed()
    {
        UIManager.Instance.SwapScreen(2);
    }
    public void OnJoinRoomButtonPressed()
    {
        UIManager.Instance.SwapScreen(2);
    }
}
