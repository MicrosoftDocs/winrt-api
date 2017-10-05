---
-api-id: M:Windows.Phone.Notification.Management.AccessoryManager.GetNextTriggerDetails
-api-type: winrt method
---

<!-- Method syntax
public Windows.Phone.Notification.Management.IAccessoryNotificationTriggerDetails GetNextTriggerDetails()
-->

# Windows.Phone.Notification.Management.AccessoryManager.GetNextTriggerDetails

## -description
Gets the next trigger details containing the information on the trigger, including notification type, display name, and time created.



## -returns
Contains information about the trigger.

## -remarks
The AccessoryManager will wake up the BackgroundTask when it encounters a notification that the accessory registered to see. The BackgroundTask is provided a IBackgroundTaskInstance which has a TriggerDetails property that contains the INotificationTriggerDetails. Note that the phone’s AccessoryManager only delivers the data; it doesn’t control how things are rendered on the accessory. That is all up to the accessory developer.

Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

## -examples
Determine the actual type of the notification. It is not necessary to support all types but the sample below assumes the accessory is interested in everything.

```
MyBackgroundTask.cs

       public async void Run(IBackgroundTaskInstance taskInstance)
        {
            BackgroundTaskDeferral deferral = taskInstance.GetDeferral();
            INotificationTriggerDetails notificationTriggerDetails = 
             AccessoryManager.NextTriggerDetails();
            while (notificationTriggerDetails != null) 
// get rid of while loop in case you would like to process one notificaiton at a time. 
//  You have to use ProcessingTriggerDetailsCompleted to indicate that you are done with this instance of the trigger
            {
                switch (notificationTriggerDetails.NotificationType)
                {
                    case NotificationType.PhoneCall:
                        IPhoneNotificationTriggerDetails phoneCallTriggerDetails = notificationTriggerDetails as IPhoneNotificationTriggerDetails;
                        string callMsg = "Got Phone Notification for ";
                        switch (phoneCallTriggerDetails.PhoneNotificationType)
                        {
                            case PhoneNotificationType.NewCall:
                            case PhoneNotificationType.CallChanged:
                                callMsg +=  
                            phoneCallTriggerDetails.PhoneNotificationType.ToString();
                                callMsg += " having direction " + 
                            phoneCallTriggerDetails.CallDetails.CallDirection.ToString();
                                callMsg += " from " + 
                            phoneCallTriggerDetails.CallDetails.PhoneNumber + "(" + 
                            phoneCallTriggerDetails.CallDetails.ContactName + ") ";
                                callMsg += "Media type " + 
                            phoneCallTriggerDetails.CallDetails.CallMediaType + "," + 
                            phoneCallTriggerDetails.CallDetails.CallTransport;
                                callMsg += " with State " + 
                            phoneCallTriggerDetails.CallDetails.State.ToString();
                                callMsg += " and Call id " + 
                            phoneCallTriggerDetails.CallDetails.CallId;
                                Debug.WriteLine(callMsg);

//Based on input from the device use the following methods to take action on the call
//Accept Call
                                //AccessoryManager.AcceptPhoneCall(phoneCall.CallDetails.CallId);

//Reject With SMS
//IReadOnlyList<ITextResponse> listResponses = phoneCall.CallDetails.PresetTextResponses;
//string response = listResponses[0].Content;
                                
// AccessoryManager.RejectPhoneCall(phoneCall.CallDetails.CallId, listResponses[0].Id);
// Rejct Call
// AccessoryManager.RejectPhoneCall(phoneCall.CallDetails.CallId);
                                break;

                            case PhoneNotificationType.PhoneCallAudioEndpointChanged:
                            case PhoneNotificationType.PhoneMuteChanged:
                                callMsg += phoneCallTriggerDetails.PhoneLineChangedId;
                                callMsg += 
                            phoneCallTriggerDetails.PhoneNotificationType.ToString();
                                Debug.WriteLine(callMsg);

                                break;
                        }
                        break;
                    case NotificationType.Toast:
                        IToastNotificationTriggerDetails toast = 
                         notificationTriggerDetails as IToastNotificationTriggerDetails;
                        Debug.WriteLine("Got toast from :" + toast.AppDisplayName + " AppId: " + toast.AppId + " Header: " + toast.Text1 + " Body: " + toast.Text2 + " IsGhost:" + toast.SuppressPopup + " at: " + toast.TimeCreated);
                        break;
                    case NotificationType.Alarm:
                        IAlarmNotificationTriggerDetails alarmTriggerDetails = notificationTriggerDetails as IAlarmNotificationTriggerDetails;
                        Debug.WriteLine("Got Alarm :" + alarmTriggerDetails.AppDisplayName + " AppId: " + alarmTriggerDetails.AppId + " Title: " + alarmTriggerDetails.Title + " IsActive: " + alarmTriggerDetails.IsActive + " TimeStamp:" + alarmTriggerDetails.Timestamp);
                        break;
                    case NotificationType.AppUninstalled:
                        INotificationTriggerDetails appUninstallTriggerDetails = notificationTriggerDetails as INotificationTriggerDetails;
                        Debug.WriteLine("Got Application Uninstall Trigger for App: " + appUninstallTriggerDetails.AppDisplayName + " AppId: " + appUninstallTriggerDetails.AppId + " at" + appUninstallTriggerDetails.TimeCreated);
                        break;
                    case NotificationType.Email:
                    //get the Email data from trigger details
                    case NotificationType.Sms:
                        //get the SMS details
                        break;
                    default:
                        Debug.WriteLine("Not supported notification type");
                        break;
                }
                //TODO: Make connection and send the data to the accessory

                //Mark the trigger details as completed processing
                 
AccessoryManager.ProcessingTriggerDetailsCompleted(notificationTriggerDetails);
                
                notificationTriggerDetails = 
                 AccessoryManager.NextTriggerDetails();
            }
            deferral.Complete();
        }
    }

```



## -see-also

## -capabilities
accessoryManager
