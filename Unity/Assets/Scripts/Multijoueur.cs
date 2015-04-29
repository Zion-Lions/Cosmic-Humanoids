using UnityEngine;
using System.Collections;
using System;

public class Multijoueur : MonoBehaviour
{
    public const string TypeName = "Cosmic-Humanoids";
    public static string gameName = "";
    public static HostData GameToJoin = null;
    private HostData[] _hostData;
    private Rect cacheRect;

    public void Start()
    {
        cacheRect = new Rect(0, 0, 200, 50);
    }

    void OnGUI()
    {
        if (_hostData != null)
        {
            for (int i = 0; i < _hostData.Length; ++i)
            {
                cacheRect.x = 15;
                cacheRect.y = Screen.height / 2 + (55 * i);

                GUI.Button(cacheRect, _hostData[i].gameName);

                if (GUI.Button(cacheRect, _hostData[i].gameName))
                {
                    JoinServer(_hostData[i]);
                }
            }
        }
    }

    public void StartServer()
    {
        if (!Network.isClient && !Network.isServer)
        {
            Network.InitializeServer(4, 2500, !Network.HavePublicAddress());
            MasterServer.RegisterHost(TypeName, gameName);

        }


        Application.LoadLevel("FirstGame");
    }

    public void RefreshList()
    {
        MasterServer.RequestHostList(TypeName);
    }

    private void JoinServer(HostData gameToJoint)
    {
        GameToJoin = gameToJoint;
        Application.LoadLevel("FirstGame");

    }

    void OnMasterServerEvent(MasterServerEvent sEvent)
    {
        if (sEvent == MasterServerEvent.HostListReceived)
        {
            _hostData = MasterServer.PollHostList();
        }
    }



}
