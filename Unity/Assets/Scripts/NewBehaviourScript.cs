using UnityEngine;
using System.Collections;
using System;

public class NewBehaviourScript : MonoBehaviour 
{
    public const string TypeName = "Cosmic-Humanoids";
    public static string gameName = "";
    public static HostData GameToJoin = null;
    private HostData[] _hostData;
    private Rect startBtnRect;
    private Rect joinBtnRect;
    private Rect cacheRect;

    public void Start()
    {
        startBtnRect = new Rect(
            Screen.width - 250,
            Screen.height / 2 - 35, 200, 50);

        joinBtnRect = new Rect(
            Screen.width - 250,
            Screen.height / 2 + 35, 200, 50);

        cacheRect = new Rect(0, 0, 200, 50);
    }

    void OnGUI()
    {
        if (GUI.Button(startBtnRect, "Start server"))
        {
            StartServer();
        }
        if(GUI.Button(joinBtnRect, "Refresh List"))
        {
            MasterServer.RequestHostList(TypeName);
        }
        if(_hostData != null)
        {
            for(int i = 0; i < _hostData.Length; ++i)
            {
                cacheRect.x = 15;
                cacheRect.y = Screen.height / 2 + (55 * i);

                if(GUI.Button(cacheRect, _hostData[i].gameName))
                {
                    JoinServer(_hostData[i]);
                }
            }
        }
    }

    private void StartServer()
    {
        if(!Network.isClient && !Network.isServer)
        {
            Network.InitializeServer(4, 2500, !Network.HavePublicAddress());
            MasterServer.RegisterHost(TypeName, gameName);

        }
        
        
        Application.LoadLevel("FirstGame");
    }

    private void JoinServer(HostData gameToJoint)
    {
        GameToJoin = gameToJoint;
        Application.LoadLevel("FirstGame");

    }

    void OnMasterServerEvent(MasterServerEvent sEvent)
    {
        if(sEvent == MasterServerEvent.HostListReceived)
        {
            _hostData = MasterServer.PollHostList();
        }
    }

   
	
}
