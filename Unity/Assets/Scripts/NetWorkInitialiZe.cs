using UnityEngine;
using System.Collections;
using System;

public class NewBehaviourScript : MonoBehaviour
{
    private string serverName = "", port = "", maxPlayers = "0";
    private Rect windowRect = new Rect(0, 0, 400, 400);

    public void OnGUI()
    {
        windowRect = GUI.Window(0, windowRect, windowFunc, "Servers");

        GUILayout.Label("Server Name");
        serverName = GUILayout.TextField(serverName);
        GUILayout.Label("Port");
        port = GUILayout.TextField(port);
        GUILayout.Label("Max players");
        maxPlayers = GUILayout.TextField(maxPlayers);

        if (GUILayout.Button("Create Server"))
        {
            try
            {
                Network.InitializeSecurity();
                Network.InitializeServer(int.Parse(maxPlayers), int.Parse(port), Network.HavePublicAddress());
                MasterServer.RegisterHost("Testing Purpose123", serverName);
            }
            catch (Exception)
            {
                print("Please enter integers for port and players");
            }
            finally
            {

            }


        }

    }

    private void windowFunc(int id)
    {
        if (GUILayout.Button("Refresh"))
        {
            MasterServer.RequestHostList("Testing Purpose123");
        }

        GUILayout.BeginHorizontal();

        GUILayout.Box("Server Name");


        GUILayout.EndHorizontal();

        if (MasterServer.PollHostList().Length != 0)
        {
            HostData[] data = MasterServer.PollHostList();
            foreach (HostData c in data)
            {
                GUILayout.BeginHorizontal();
                GUILayout.Box(c.gameName);

                if (GUILayout.Button("Connect"))
                {
                    Network.Connect(c);
                }
                GUILayout.EndHorizontal();
            }
        }
    }

}
