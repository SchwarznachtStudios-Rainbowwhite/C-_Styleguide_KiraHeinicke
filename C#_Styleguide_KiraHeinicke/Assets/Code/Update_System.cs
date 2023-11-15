using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Update_System : MonoBehaviour

{
    /* public void CheckForUpdates(Game game)
     {
         //Prüfen ob Spiel läuft
         if (game.Status == "Running")
         {
             throw new InvalidOperationException("Cannot update while game is running.");
         }

         // Simulation verschiedener Netzwerkstatus
         //Prüfen ob Internet besteht
         NetworkStatus networkStatus = game.CheckNetworkStatus();
         if (networkStatus == NetworkStatus.Disconnected)
         {
             throw new NoNetworkConnectionException("Please check your internet connection.");
         }
         // wenn verbunden, such nach updates
         else if (networkStatus == NetworkStatus.Connected)
         {
             bool updatesAvailable = game.CheckForGameUpdates();
             //Update anwenden
             if (updatesAvailable)
             {
                 /*game.DownloadGameUpdates();
                 // Überprüfung auf spezielle Ereignisse
                 if (game.HasSpecialEvents())
                 {
                     game.PrepareForSpecialEvents();
                 }

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

     public bool HasSpecialEvents()
     {
         // Simuliert die Überprüfung auf spezielle Ereignisse
         return false;
     }

     public void PrepareForSpecialEvents()
     {
         // Simuliert die Vorbereitung auf spezielle Ereignisse
     }

     public void ApplyUpdates()
     {
         // Simuliert das Anwenden von Updates
     }
    */
}


