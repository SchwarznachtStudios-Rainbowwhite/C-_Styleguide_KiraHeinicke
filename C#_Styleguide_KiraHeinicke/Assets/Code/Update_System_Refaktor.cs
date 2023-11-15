using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Update_System_Refaktor : MonoBehaviour
{
    public void CheckForUpdates(Game game)
    {
        //Prüfen ob Spiel läuft
        if (game.Status == "Running")
        {
            throw new InvalidOperationException("Cannot update while game is running.");
        }

        //Prüfen ob Internet besteht
        NetworkStatus networkStatus = game.CheckNetworkStatus();

        //Internet Rückmeldung an Nutzer
        if (networkStatus == NetworkStatus.Disconnected)
        {
            throw new NoNetworkConnectionException("Please check your internet connection.");
        }

        //Wenn verbunden, such nach updates
        else if (networkStatus == NetworkStatus.Connected)
        {
            //Updatesuche
            bool updatesAvailable = game.CheckForGameUpdates();

            //Update anwenden (oder keines) + Rückmeldung
            if (updatesAvailable)
            {
                game.DownloadGameUpdates();

                game.ApplyUpdates();
                Console.WriteLine("Game updated successfully.");
            }
            else
            {
                Console.WriteLine("No updates available.");
            }
        }
    }
}

enum NetworkStatus
{
    Disconnected,
    Connected
}

class Game
{
    public string Status { get; set; }

    public NetworkStatus CheckNetworkStatus()
    {
        // Simuliert eine Netzwerkstatusprüfung
        return NetworkStatus.Connected;
    }

    public bool CheckForGameUpdates()
    {
        // Simuliert eine Überprüfung auf Spielupdates
        return true;
    }

    public void DownloadGameUpdates()
    {
        // Simuliert das Herunterladen von Updates
    }

    public void ApplyUpdates()
    {
        // Simuliert das Anwenden von Updates
    }
}

