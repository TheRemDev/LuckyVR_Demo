using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    public static NetworkManager Instance;
    public int totalPlayersInRoom = 0;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
            //Debug.Log("Multiplayer Manager Persistent Singleton Created:" + this.name);
        }
    }

    public void ConnectToMaster()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        Debug.Log("Multiplayer Manager: Connected to master");

        PhotonNetwork.JoinLobby();
        Debug.Log("Multiplayer Manager: Joining Lobby...");
    }

    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();
        Debug.Log("Multiplayer Manager: Join Lobby Success !");
        LocalEventsManager.Fire_evt_JoinMasterServerSuccess();

    }

    public void JoinRoom(string roomName)
    {
        PhotonNetwork.JoinRoom(roomName);
    }

    public void CreateRoom(string roomName)
    {
        PhotonNetwork.CreateRoom(roomName);
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        LocalEventsManager.Fire_evt_JoinRoomSuccess();
    }

    public void Update()
    {
        if (PhotonNetwork.InRoom)
        {
            totalPlayersInRoom = PhotonNetwork.CurrentRoom.PlayerCount;
        }
  
    }
}

