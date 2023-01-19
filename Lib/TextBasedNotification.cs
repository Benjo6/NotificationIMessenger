using MVVMLight.Messaging;

namespace Lib;

public class TextBasedNotification
{
    //Constructor
    public TextBasedNotification()
    {
        //Register the callback function to receive the notification
        Messenger.Default.Register<string>(this,OnNotificationReceived);
    }
    
    //Callback function to be executed when the notification is received
    private void OnNotificationReceived(string message)
    {
        //Do something with the received message
        Console.WriteLine(message);
    }

    public void SendNotification(string notificationText)
    {
        Messenger.Default.Send(notificationText);
    }

    public void Unregister()
    {
        Messenger.Default.Unregister<string>(this,OnNotificationReceived);
    }
    
    
}