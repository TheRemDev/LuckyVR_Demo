using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class LoadManager : MonoBehaviour
{
    ConnectionResultScreen connectionResultScreen;

    private void Start()
    {
        //This is ugly, TODO, more love on the load manager
        connectionResultScreen = UIManager.Instance.GetScreen(3).GetComponent<ConnectionResultScreen>();
        NetworkManager.Instance.ConnectToMaster();
    }

    private void OnJoinMasterServerSuccess()
    {
        UIManager.Instance.SwapScreen(1);
    }

    private void OnJoinMasterServerFailed()
    {
        UIManager.Instance.SwapScreen(3);
        connectionResultScreen.SetupDisplayText("Could not join master server.... try again...");
    }

    private void OnJoinRoomSuccess()
    {
        connectionResultScreen.SetupDisplayText("Succesfully joined room.");
        PhotonNetwork.LoadLevel(1);
    }

    private void OnJoinRoomFailed()
    {
        connectionResultScreen.SetupDisplayText("Failed to join room." );
    }

    private void OnCreateRoomSuccess()
    {
        connectionResultScreen.SetupDisplayText("Succesfully created room." );
    }

    private void OnCreateRoomFailed()
    {
        connectionResultScreen.SetupDisplayText("Failed to create room.");
    }

    // Subscribe / Unsubsribe to events
    #region 
    private void OnEnable()
    {
        LocalEventsManager.OnJoinMasterServerSuccess    += OnJoinMasterServerSuccess;
        LocalEventsManager.OnJoinMasterServerFailed     += OnJoinMasterServerFailed;
        LocalEventsManager.OnCreateRoomFailed           += OnCreateRoomFailed;
        LocalEventsManager.OnCreateRoomSuccess          += OnCreateRoomSuccess;
        LocalEventsManager.OnJoinRoomFailed             += OnJoinRoomFailed;
        LocalEventsManager.OnJoinRoomSuccess            += OnJoinRoomSuccess;
    }

 

    private void OnDisable()
    {
        LocalEventsManager.OnJoinMasterServerSuccess    -= OnJoinMasterServerSuccess;
        LocalEventsManager.OnJoinMasterServerFailed     -= OnJoinMasterServerFailed;
        LocalEventsManager.OnCreateRoomFailed           -= OnCreateRoomFailed;
        LocalEventsManager.OnCreateRoomSuccess          -= OnCreateRoomSuccess;
        LocalEventsManager.OnJoinRoomFailed             -= OnJoinRoomFailed;
        LocalEventsManager.OnJoinRoomSuccess            -= OnJoinRoomSuccess;
    }
    #endregion
}
