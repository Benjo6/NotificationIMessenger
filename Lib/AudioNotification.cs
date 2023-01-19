using MVVMLight.Messaging;
using System.Media;
using NAudio.Wave;

namespace Lib;

public class AudioNotification
{
    //Constructor
    public AudioNotification()
    {
        //Register the callback function to receive the notification
        Messenger.Default.Register<string>(this,OnNotificationReceived);
    }
    
    //Callback function to be executed when the notification is received
    private void OnNotificationReceived(string message)
    {
        using(var audioFile = new AudioFileReader(message))
        using (var outputDevice=new WaveOutEvent())
        {
            outputDevice.Init(audioFile);
            outputDevice.Play();
        }
    }
    
    //Method to send the notification
    public void SendNotification(string audioFilePath)
    {
        Messenger.Default.Send(audioFilePath);
    }
    
    //Method to unregister the callback function
    public void Unregister()
    {
        Messenger.Default.Unregister<string>(this, OnNotificationReceived);
    }


}