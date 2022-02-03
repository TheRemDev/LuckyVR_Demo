using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Player : MonoBehaviour
{
    public string playerName { get; private set; }
    [SerializeField] private int m_playerChips = 0;
    [SerializeField] private int m_betAmount;
    [SerializeField] private ColorChoice m_bettingColor = ColorChoice.None;

    public void Awake()
    {
        m_playerChips = Random.Range(100, 1000);
        DontDestroyOnLoad(this.gameObject);
    }

    public void SetPlayerName(string name)
    {
        playerName = name;
    }

    public void MakeBet(ColorChoice choice)
    {
        NetworkEventsManager.SendNetworkEventPlayerMadeABet(this, choice);
    }

    public int GetChipsAmount()
    {
        return m_playerChips;
    }

    public int GetBetAmount()
    {
        return m_betAmount;
    }
}
