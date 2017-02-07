//
// SampleDataSource.cpp
// Implementation of the SampleDataSource, SampleDataGroup, SampleDataItem, and SampleDataCommon classes
//

#include "pch.h"
#include "DataModel\SampleDataSource.h"

using namespace BaseElementEvents::Data;

using namespace Platform;
using namespace Platform::Collections;
using namespace Windows::ApplicationModel::Resources::Core;
using namespace Windows::Foundation;
using namespace Windows::Foundation::Collections;
using namespace Windows::UI::Xaml::Data;
using namespace Windows::UI::Xaml::Interop;
using namespace Windows::UI::Xaml::Media;
using namespace Windows::UI::Xaml::Media::Imaging;

//
// SampleDataCommon
//

SampleDataCommon::SampleDataCommon(String^ uniqueId, String^ title, String^ subtitle, String^ imagePath, String^ description)
{
	_uniqueId = uniqueId;
	_title = title;
	_subtitle = subtitle;
	_description = description;
	_imagePath = imagePath;
	_image = nullptr;
}

String^ SampleDataCommon::UniqueId::get()
{
	return _uniqueId;
}

void SampleDataCommon::UniqueId::set(String^ value)
{
	if (_uniqueId != value)
	{
		_uniqueId = value;
		OnPropertyChanged("UniqueId");
	}
}

String^ SampleDataCommon::Title::get()
{
	return _title;
}

void SampleDataCommon::Title::set(String^ value)
{
	if (_title != value)
	{
		_title = value;
		OnPropertyChanged("Title");
	}
}

String^ SampleDataCommon::Subtitle::get()
{
	return _subtitle;
}

void SampleDataCommon::Subtitle::set(String^ value)
{
	if (_subtitle != value)
	{
		_subtitle = value;
		OnPropertyChanged("Subtitle");
	}
}

String^ SampleDataCommon::Description::get()
{
	return _description;
}

void SampleDataCommon::Description::set(String^ value)
{
	if (_description != value)
	{
		_description = value;
		OnPropertyChanged("Description");
	}
}

ImageSource^ SampleDataCommon::Image::get()
{
	static Uri^ _baseUri = ref new Uri("ms-appx:///");
	
	if (_image == nullptr && _imagePath != nullptr)
	{
		_image = ref new BitmapImage(_baseUri->CombineUri(_imagePath));
	}
	return _image;
}

void SampleDataCommon::Image::set(ImageSource^ value)
{
	if (_image != value)
	{
		_image = value;
		_imagePath = nullptr;
		OnPropertyChanged("Image");
		PropertySet set;
	}
}

void SampleDataCommon::SetImage(String^ path)
{
	_image = nullptr;
	_imagePath = path;
	OnPropertyChanged("Image");
}

//
// SampleDataItem
//

SampleDataItem::SampleDataItem(String^ uniqueId, String^ title, String^ subtitle, String^ imagePath, String^ description,
							   String^ content, SampleDataGroup^ group)
							   : SampleDataCommon(uniqueId, title, subtitle, imagePath, description)
{
	_content = content;
	_group = group;
}

String^ SampleDataItem::Content::get()
{
	return _content;
}

void SampleDataItem::Content::set(String^ value)
{
	if (_content != value)
	{
		_content = value;
		OnPropertyChanged("Content");
	}
}

SampleDataGroup^ SampleDataItem::Group::get()
{
	return _group.Resolve<SampleDataGroup>();
}

void SampleDataItem::Group::set(SampleDataGroup^ value)
{
	if (Group != value)
	{
		_group = value;
		OnPropertyChanged("Group");
	}
}

//
// SampleDataGroup
//

SampleDataGroup::SampleDataGroup(String^ uniqueId, String^ title, String^ subtitle, String^ imagePath, String^ description)
	: SampleDataCommon(uniqueId, title, subtitle, imagePath, description)
{
	_items = ref new Vector<SampleDataItem^>();
}

IObservableVector<SampleDataItem^>^ SampleDataGroup::Items::get()
{
	return _items;
}

IVector<SampleDataItem^>^ SampleDataGroup::TopItems::get()
{
	// Provides a subset of the full items collection to bind to from a GroupedItemsPage
	// for two reasons: GridView will not virtualize large items collections, and it
	// improves the user experience when browsing through groups with large numbers of
	// items.
	//
	// A maximum of 12 items are displayed because it results in filled grid columns
	// whether there are 1, 2, 3, 4, or 6 rows displayed
	int topItemCount = _items->Size;
	if (topItemCount > 12) topItemCount = 12;
	auto topItems = ref new Vector<SampleDataItem^>();
	for (int index = 0; index < topItemCount; index++)
	{
		topItems->Append(_items->GetAt(index));
	}
	return topItems;
}

//
// SampleDataSource
//

SampleDataSource::SampleDataSource()
{
	_allGroups = ref new Vector<SampleDataGroup^>();

	String^ LONG_LOREM_IPSUM = "Curabitur class aliquam vestibulum nam curae maecenas sed integer cras phasellus suspendisse quisque donec dis praesent accumsan bibendum pellentesque condimentum adipiscing etiam consequat vivamus dictumst aliquam duis convallis scelerisque est parturient ullamcorper aliquet fusce suspendisse nunc hac eleifend amet blandit facilisi condimentum commodo scelerisque faucibus aenean ullamcorper ante mauris dignissim consectetuer nullam lorem vestibulum habitant conubia elementum pellentesque morbi facilisis arcu sollicitudin diam cubilia aptent vestibulum auctor eget dapibus pellentesque inceptos leo egestas interdum nulla consectetuer suspendisse adipiscing pellentesque proin lobortis sollicitudin augue elit mus congue fermentum parturient fringilla euismod feugiat";
	String^ ITEM_CONTENT = "Item Content: " + LONG_LOREM_IPSUM + "\n\n" + LONG_LOREM_IPSUM + "\n\n" + LONG_LOREM_IPSUM + "\n\n" + LONG_LOREM_IPSUM + "\n\n" + LONG_LOREM_IPSUM + "\n\n" + LONG_LOREM_IPSUM + "\n\n" + LONG_LOREM_IPSUM;

	auto group1 = ref new SampleDataGroup("Group-1",
		"Group Title: 1",
		"Group Subtitle: 1",
		"Assets/DarkGray.png",
		"Group Description: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus tempor scelerisque lorem in vehicula. Aliquam tincidunt, lacus ut sagittis tristique, turpis massa volutpat augue, eu rutrum ligula ante a ante");
	group1->Items->Append(ref new SampleDataItem("Group-1-Item-1",
		"Item Title: 1",
		"Item Subtitle: 1",
		"Assets/LightGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group1));
	group1->Items->Append(ref new SampleDataItem("Group-1-Item-2",
		"Item Title: 2",
		"Item Subtitle: 2",
		"Assets/DarkGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group1));
	group1->Items->Append(ref new SampleDataItem("Group-1-Item-3",
		"Item Title: 3",
		"Item Subtitle: 3",
		"Assets/MediumGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group1));
	group1->Items->Append(ref new SampleDataItem("Group-1-Item-4",
		"Item Title: 4",
		"Item Subtitle: 4",
		"Assets/DarkGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group1));
	group1->Items->Append(ref new SampleDataItem("Group-1-Item-5",
		"Item Title: 5",
		"Item Subtitle: 5",
		"Assets/MediumGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group1));
	_allGroups->Append(group1);

	auto group2 = ref new SampleDataGroup("Group-2",
		"Group Title: 2",
		"Group Subtitle: 2",
		"Assets/LightGray.png",
		"Group Description: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus tempor scelerisque lorem in vehicula. Aliquam tincidunt, lacus ut sagittis tristique, turpis massa volutpat augue, eu rutrum ligula ante a ante");
	group2->Items->Append(ref new SampleDataItem("Group-2-Item-1",
		"Item Title: 1",
		"Item Subtitle: 1",
		"Assets/DarkGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group2));
	group2->Items->Append(ref new SampleDataItem("Group-2-Item-2",
		"Item Title: 2",
		"Item Subtitle: 2",
		"Assets/MediumGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group2));
	group2->Items->Append(ref new SampleDataItem("Group-2-Item-3",
		"Item Title: 3",
		"Item Subtitle: 3",
		"Assets/LightGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group2));
	_allGroups->Append(group2);

	auto group3 = ref new SampleDataGroup("Group-3",
		"Group Title: 3",
		"Group Subtitle: 3",
		"Assets/MediumGray.png",
		"Group Description: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus tempor scelerisque lorem in vehicula. Aliquam tincidunt, lacus ut sagittis tristique, turpis massa volutpat augue, eu rutrum ligula ante a ante");
	group3->Items->Append(ref new SampleDataItem("Group-3-Item-1",
		"Item Title: 1",
		"Item Subtitle: 1",
		"Assets/MediumGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group3));
	group3->Items->Append(ref new SampleDataItem("Group-3-Item-2",
		"Item Title: 2",
		"Item Subtitle: 2",
		"Assets/LightGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group3));
	group3->Items->Append(ref new SampleDataItem("Group-3-Item-3",
		"Item Title: 3",
		"Item Subtitle: 3",
		"Assets/DarkGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group3));
	group3->Items->Append(ref new SampleDataItem("Group-3-Item-4",
		"Item Title: 4",
		"Item Subtitle: 4",
		"Assets/LightGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group3));
	group3->Items->Append(ref new SampleDataItem("Group-3-Item-5",
		"Item Title: 5",
		"Item Subtitle: 5",
		"Assets/MediumGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group3));
	group3->Items->Append(ref new SampleDataItem("Group-3-Item-6",
		"Item Title: 6",
		"Item Subtitle: 6",
		"Assets/DarkGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group3));
	group3->Items->Append(ref new SampleDataItem("Group-3-Item-7",
		"Item Title: 7",
		"Item Subtitle: 7",
		"Assets/MediumGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group3));
	_allGroups->Append(group3);

	auto group4 = ref new SampleDataGroup("Group-4",
		"Group Title: 4",
		"Group Subtitle: 4",
		"Assets/LightGray.png",
		"Group Description: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus tempor scelerisque lorem in vehicula. Aliquam tincidunt, lacus ut sagittis tristique, turpis massa volutpat augue, eu rutrum ligula ante a ante");
	group4->Items->Append(ref new SampleDataItem("Group-4-Item-1",
		"Item Title: 1",
		"Item Subtitle: 1",
		"Assets/DarkGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group4));
	group4->Items->Append(ref new SampleDataItem("Group-4-Item-2",
		"Item Title: 2",
		"Item Subtitle: 2",
		"Assets/LightGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group4));
	group4->Items->Append(ref new SampleDataItem("Group-4-Item-3",
		"Item Title: 3",
		"Item Subtitle: 3",
		"Assets/DarkGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group4));
	group4->Items->Append(ref new SampleDataItem("Group-4-Item-4",
		"Item Title: 4",
		"Item Subtitle: 4",
		"Assets/LightGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group4));
	group4->Items->Append(ref new SampleDataItem("Group-4-Item-5",
		"Item Title: 5",
		"Item Subtitle: 5",
		"Assets/MediumGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group4));
	group4->Items->Append(ref new SampleDataItem("Group-4-Item-6",
		"Item Title: 6",
		"Item Subtitle: 6",
		"Assets/LightGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group4));
	_allGroups->Append(group4);

	auto group5 = ref new SampleDataGroup("Group-5",
		"Group Title: 5",
		"Group Subtitle: 5",
		"Assets/MediumGray.png",
		"Group Description: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus tempor scelerisque lorem in vehicula. Aliquam tincidunt, lacus ut sagittis tristique, turpis massa volutpat augue, eu rutrum ligula ante a ante");
	group5->Items->Append(ref new SampleDataItem("Group-5-Item-1",
		"Item Title: 1",
		"Item Subtitle: 1",
		"Assets/LightGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group5));
	group5->Items->Append(ref new SampleDataItem("Group-5-Item-2",
		"Item Title: 2",
		"Item Subtitle: 2",
		"Assets/DarkGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group5));
	group5->Items->Append(ref new SampleDataItem("Group-5-Item-3",
		"Item Title: 3",
		"Item Subtitle: 3",
		"Assets/LightGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group5));
	group5->Items->Append(ref new SampleDataItem("Group-5-Item-4",
		"Item Title: 4",
		"Item Subtitle: 4",
		"Assets/MediumGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group5));
	_allGroups->Append(group5);

	auto group6 = ref new SampleDataGroup("Group-6",
		"Group Title: 6",
		"Group Subtitle: 6",
		"Assets/DarkGray.png",
		"Group Description: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus tempor scelerisque lorem in vehicula. Aliquam tincidunt, lacus ut sagittis tristique, turpis massa volutpat augue, eu rutrum ligula ante a ante");
	group6->Items->Append(ref new SampleDataItem("Group-6-Item-1",
		"Item Title: 1",
		"Item Subtitle: 1",
		"Assets/LightGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group6));
	group6->Items->Append(ref new SampleDataItem("Group-6-Item-2",
		"Item Title: 2",
		"Item Subtitle: 2",
		"Assets/DarkGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group6));
	group6->Items->Append(ref new SampleDataItem("Group-6-Item-3",
		"Item Title: 3",
		"Item Subtitle: 3",
		"Assets/MediumGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group6));
	group6->Items->Append(ref new SampleDataItem("Group-6-Item-4",
		"Item Title: 4",
		"Item Subtitle: 4",
		"Assets/DarkGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group6));
	group6->Items->Append(ref new SampleDataItem("Group-6-Item-5",
		"Item Title: 5",
		"Item Subtitle: 5",
		"Assets/LightGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group6));
	group6->Items->Append(ref new SampleDataItem("Group-6-Item-6",
		"Item Title: 6",
		"Item Subtitle: 6",
		"Assets/MediumGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group6));
	group6->Items->Append(ref new SampleDataItem("Group-6-Item-7",
		"Item Title: 7",
		"Item Subtitle: 7",
		"Assets/DarkGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group6));
	group6->Items->Append(ref new SampleDataItem("Group-6-Item-8",
		"Item Title: 8",
		"Item Subtitle: 8",
		"Assets/LightGray.png",
		"Item Description: Pellentesque porta, mauris quis interdum vehicula, urna sapien ultrices velit, nec venenatis dui odio in augue. Cras posuere, enim a cursus convallis, neque turpis malesuada erat, ut adipiscing neque tortor ac erat.",
		ITEM_CONTENT,
		group6));
	_allGroups->Append(group6);
}

IObservableVector<SampleDataGroup^>^ SampleDataSource::AllGroups::get()
{
	return _allGroups;
}

static SampleDataSource^ _sampleDataSource = ref new SampleDataSource();

IIterable<SampleDataGroup^>^ SampleDataSource::GetGroups(String^ uniqueId)
{
	String^ AllGroupsId = "AllGroups";
	if (!AllGroupsId->Equals(uniqueId)) throw ref new InvalidArgumentException("Only 'AllGroups' is supported as a collection of groups");

	return _sampleDataSource->AllGroups;
}

SampleDataGroup^ SampleDataSource::GetGroup(String^ uniqueId)
{
	// Simple linear search is acceptable for small data sets
	for each (auto group in _sampleDataSource->AllGroups)
	{
		if (group->UniqueId->Equals(uniqueId)) return group;
	}
	return nullptr;
}

SampleDataItem^ SampleDataSource::GetItem(String^ uniqueId)
{
	// Simple linear search is acceptable for small data sets
	for each (auto group in _sampleDataSource->AllGroups)
	{
		for each (auto item in group->Items)
		{
			if (item->UniqueId->Equals(uniqueId)) return item;
		}
	}
	return nullptr;
}
