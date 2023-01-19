// See https://aka.ms/new-console-template for more information

using Lib;

//create an instance of the TextBasedNotification class
TextBasedNotification textNotification = new TextBasedNotification();

//create an instance of the AudioNotification class
AudioNotification audioNotification = new AudioNotification();


//send the text notification
textNotification.SendNotification("Notification Received");

//send the audio notification
audioNotification.SendNotification("C:\\audio.wav");


//unregister the callback when it's no longer needed
textNotification.Unregister();

//unregister the callback when it's no longer needed
audioNotification.Unregister();
