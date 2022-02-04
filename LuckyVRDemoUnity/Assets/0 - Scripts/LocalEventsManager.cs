using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class LocalEventsManager
{
    //Connect to master
    public static event Action OnJoinMasterServerSuccess = delegate { };
    public static void Fire_evt_JoinMasterServerSuccess()
    {
        OnJoinMasterServerSuccess();
    }

    public static event Action OnJoinMasterServerFailed = delegate { };
    public static void Fire_evt_JoinMasterServerFailed()
    {
        OnJoinMasterServerFailed();
    }

    //Create Room/ Join Room
    #region
    public static event Action OnCreateRoomSuccess = delegate { };
    public static void Fire_evt_CreateRoomSuccess()
    {
        Debug.Log("EventsManager: Fired event -> Create Room Success()");
        OnCreateRoomSuccess();
    }

    public static event Action OnCreateRoomFailed = delegate { };
    public static void Fire_evt_CreateRoomFailed()
    {
        Debug.Log("EventsManager: Fired event -> Create Room Failed()");
        OnCreateRoomFailed();
    }

    public static event Action OnJoinRoomSuccess = delegate { };
    public static void Fire_evt_JoinRoomSuccess()
    {
        Debug.Log("EventsManager: Fired event -> Join Room Success()");
        OnJoinRoomSuccess();
    }

    public static event Action OnJoinRoomFailed = delegate { };
    public static void Fire_evt_JoinRoomFailed()
    {
        Debug.Log("EventsManager: Fired event -> Join Room Failed()");
        OnJoinRoomFailed();
    }
    #endregion
}
