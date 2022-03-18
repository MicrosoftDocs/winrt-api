---
-api-id: T:Windows.ApplicationModel.Contacts.Provider.ContactPickerUI
-api-type: winrt class
---

<!-- Class syntax.
public class ContactPickerUI : Windows.ApplicationModel.Contacts.Provider.IContactPickerUI, Windows.ApplicationModel.Contacts.Provider.IContactPickerUI2
-->

# Windows.ApplicationModel.Contacts.Provider.ContactPickerUI

## -description
Allows you to call the contact picker UI so you can select one or more contacts.

## -remarks
To see an example of how to use this class, check out our [code sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/ContactPicker).

## -examples
This example code prepares the page to use ContactPickerUI:

```csharp
        ContactPickerUI contactPickerUI = MainPagePicker.Current.contactPickerUI;
        CoreDispatcher dispatcher = Window.Current.Dispatcher;

        public ContactPickerPage()
        {
            this.InitializeComponent();
            ContactList.ItemsSource = contactSet;
            ContactList.SelectionChanged += ContactList_SelectionChanged;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            contactPickerUI.ContactRemoved += contactPickerUI_ContactRemoved;
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            contactPickerUI.ContactRemoved -= contactPickerUI_ContactRemoved;
        }

        async void contactPickerUI_ContactRemoved(ContactPickerUI sender, ContactRemovedEventArgs args)
        {
            // The event handler may be invoked on a background thread, so use the Dispatcher to run the UI-related code on the UI thread.
            string removedId = args.Id;
            await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                foreach (SampleContact contact in ContactList.SelectedItems)
                {
                    if (contact.Id == removedId)
                    {
                        ContactList.SelectedItems.Remove(contact);
                        OutputText.Text += "\n" + contact.DisplayName + " was removed from the basket";
                        break;
                    }
                }
            });
        }

```

This example code shows how to add a contact to the basket with the [AddContact(Contact)](contactpickerui_addcontact_79336216.md) method.

```csharp
            switch (contactPickerUI.AddContact(contact))
            {
                case AddContactResult.Added:
                    // Notify the user that the contact was added
                    OutputText.Text = contact.DisplayName + " was added to the basket";
                    break;
                case AddContactResult.AlreadyAdded:
                    // Notify the user that the contact is already added
                    OutputText.Text = contact.DisplayName + " is already in the basket";
                    break;
                case AddContactResult.Unavailable:
                default:
                    // Notify the user that the basket is unavailable
                    OutputText.Text = contact.DisplayName + " could not be added to the basket";
                    break;
            }

```

This example code shows how to remove a contact from the basket and respond to its removal.

```csharp
            foreach (SampleContact removed in e.RemovedItems)
            {
                if (contactPickerUI.ContainsContact(removed.Id))
                {
                    contactPickerUI.RemoveContact(removed.Id);
                    OutputText.Text = removed.DisplayName + " was removed from the basket";
                }
            }

```



## -see-also
## -capabilities
contactsSystem
