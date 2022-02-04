using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField] private RectTransform[] m_allScreens;
    public int CurrentScreenIndex { get; private set;}

    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(this.gameObject);

        Instance = this;
    }

    private void Start()
    {
        InitScreens();
    }

    private void InitScreens(int startinScreenIndex = 0)
    {
        CenterAllScreens();
        SwapScreen(0);
    }

    private void CenterAllScreens()
    {
        for (int i = 0; i < m_allScreens.Length; i++)
        {
            m_allScreens[i].offsetMax = Vector2.one;
            m_allScreens[i].offsetMin = Vector2.zero;
        }
    }

    private void DisableAllScreens()
    {
        for (int i = 0; i < m_allScreens.Length; i++)
        {
            m_allScreens[i].gameObject.SetActive(false);
        }
    }

    public void SwapScreen(int screenIndex)
    {
        if (screenIndex > m_allScreens.Length -1 || screenIndex < 0)
            return;

        DisableAllScreens();
        m_allScreens[screenIndex].gameObject.SetActive(true);
        CurrentScreenIndex = screenIndex;
    }

    public GameObject GetScreen(int requiredScreenIndex)
    {
        return m_allScreens[requiredScreenIndex].gameObject;
    }
}
