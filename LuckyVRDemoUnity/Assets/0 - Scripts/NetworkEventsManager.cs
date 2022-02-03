using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ExitGames.Client.Photon;
using Photon.Realtime;
using Photon.Pun;

public static class NetworkEventsManager
{
    // Event code bytes
    public const byte PlayerMadeABetEventCode = 1;
    public static void SendNetworkEventPlayerMadeABet(Player player, ColorChoice colorChoice)
    {
        Debug.Log(player.playerName + " made a bet on: " + colorChoice);
        object[] content = new object[] {  }; // Array contains the target position and the IDs of the selected units
        RaiseEventOptions raiseEventOptions = new RaiseEventOptions { Receivers = ReceiverGroup.All }; // You would have to set the Receivers to All in order to receive this event on the local client as well
        PhotonNetwork.RaiseEvent(PlayerMadeABetEventCode, content, raiseEventOptions, SendOptions.SendReliable);
    }
}
