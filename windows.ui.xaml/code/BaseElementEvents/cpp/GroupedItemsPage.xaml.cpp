//
// GroupedItemsPage.xaml.cpp
// Implementation of the GroupedItemsPage class
//

#include "pch.h"
#include "DataModel\SampleDataSource.h"
#include "GroupedItemsPage.xaml.h"
#include "GroupDetailPage.xaml.h"
#include "ItemDetailPage.xaml.h"

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

// The Grouped Items Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234231

GroupedItemsPage::GroupedItemsPage()
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
void GroupedItemsPage::LoadState(Object^ navigationParameter, IMap<String^, Object^>^ pageState)
{
	// TODO: Create an appropriate data model for your problem domain to replace the sample data
	auto sampleDataGroups = Data::SampleDataSource::GetGroups(safe_cast<String^>(navigationParameter));
	DefaultViewModel->Insert("Groups", sampleDataGroups);
}

/// <summary>
/// Invoked when a group header is clicked.
/// </summary>
/// <param name="sender">The Button used as a group header for the selected group.</param>
/// <param name="e">Event data that describes how the click was initiated.</param>
void GroupedItemsPage::Header_Click(Object^ sender, RoutedEventArgs^ e)
{
	(void) e;	// Unused parameter

	// Determine what group the Button instance represents
	auto group = safe_cast<FrameworkElement^>(sender)->DataContext;

	// Navigate to the appropriate destination page, configuring the new page
	// by passing required information as a navigation parameter
	Frame->Navigate(TypeName(GroupDetailPage::typeid), safe_cast<Data::SampleDataGroup^>(group)->UniqueId);
}

/// <summary>
/// Invoked when an item within a group is clicked.
/// </summary>
/// <param name="sender">The GridView (or ListView when the application is snapped)
/// displaying the item clicked.</param>
/// <param name="e">Event data that describes the item clicked.</param>
void GroupedItemsPage::ItemView_ItemClick(Object^ sender, ItemClickEventArgs^ e)
{
	(void) sender;	// Unused parameter

	// Navigate to the appropriate destination page, configuring the new page
	// by passing required information as a navigation parameter
	auto itemId = safe_cast<Data::SampleDataItem^>(e->ClickedItem)->UniqueId;
	Frame->Navigate(TypeName(ItemDetailPage::typeid), itemId);
}
