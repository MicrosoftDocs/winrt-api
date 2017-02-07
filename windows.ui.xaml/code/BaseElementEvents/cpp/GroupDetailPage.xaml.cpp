//
// GroupDetailPage.xaml.cpp
// Implementation of the GroupDetailPage class
//

#include "pch.h"
#include "GroupDetailPage.xaml.h"
#include "ItemDetailPage.xaml.h"
#include "DataModel\SampleDataSource.h"

using namespace BaseElementEvents;

using namespace Platform;
using namespace Windows::Foundation;
using namespace Windows::Foundation::Collections;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Controls::Primitives;
using namespace Windows::UI::Xaml::Data;
using namespace Windows::UI::Xaml::Input;
using namespace Windows::UI::Xaml::Interop;
using namespace Windows::UI::Xaml::Media;
using namespace Windows::UI::Xaml::Navigation;

// The Group Detail Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234229

GroupDetailPage::GroupDetailPage()
{
	InitializeComponent();
}

/// <summary>
/// Populates the page with content passed during navigation.  Any saved state is also
/// provided when recreating a page from a prior session.
/// </summary>
/// <param name="navigationParameter">The parameter value passed to
/// <see cref="Frame::Navigate(Type, Object)"/> when this page was initially requested.
/// </param>
/// <param name="pageState">A map of state preserved by this page during an earlier
/// session.  This will be null the first time a page is visited.</param>
void GroupDetailPage::LoadState(Object^ navigationParameter, IMap<String^, Object^>^ pageState)
{
	// TODO: Create an appropriate data model for your problem domain to replace the sample data
	auto group = Data::SampleDataSource::GetGroup(safe_cast<String^>(navigationParameter));
	DefaultViewModel->Insert("Group", group);
	DefaultViewModel->Insert("Items", group->Items);
}

/// <summary>
/// Invoked when an item is clicked.
/// </summary>
/// <param name="sender">The GridView (or ListView when the application is snapped)
/// displaying the item clicked.</param>
/// <param name="e">Event data that describes the item clicked.</param>
void GroupDetailPage::ItemView_ItemClick(Object^ sender, ItemClickEventArgs^ e)
{
	(void) sender;	// Unused parameter

	// Navigate to the appropriate destination page, configuring the new page
	// by passing required information as a navigation parameter
	auto itemId = safe_cast<Data::SampleDataItem^>(e->ClickedItem)->UniqueId;
	Frame->Navigate(TypeName(ItemDetailPage::typeid), itemId);
}
