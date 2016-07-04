# ListViewTestApp
A simple Xamarin PCL Project showing how to deal with Mvvm and Listview 

Welcome to my little Test Project =)
I just started learning Xamarin Forms and wanted to share to others what's take me a few hours to bring out when it so simple in the end.
Lazy developers shouldn't spend more than 10 seconds to write this :p

Used Techno: Visual Studio 2015, Xamarin Forms and MvvmLight Project from Laurent Bugnion.

# Usage

I basically followed Laurent Bugnion's tuto on [How to use Xamarin Forms with MvvmLight](http://blog.galasoft.ch/posts/2014/07/using-xamarin-forms-with-mvvmlight/) and adapted it for my own needs.

My ViewModelLocator's implementation is the same as Laurent's implementation.
The changes are for the most part in the ContactViewModel class.

You just create your ViewModel and inherits from ViewModelBase;

```c#
public class ContactViewModel : ViewModelBase
```

Then add an ObservableCollection property to you ViewModel
(Use the propfull shortcut to go faster :p)

```c#
private ObservableCollection<Contact> _contacts;

public ObservableCollection<Contact> Contacts
{
    get { return _contacts; }
    set
    {
        _contacts = value;
        RaisePropertyChanged(() => Contacts);
    }
}
```

Now you have to initialize your ObservableCollection. As for me, I did it in the ViewModel's default constructor.

Finally we need to change the MainPage Xaml to add binding to our viewmodel.
For the C# part, it's exactly the same as in Laurent's Tutorial so I'll just show you the Xaml part.

```xaml
<ListView ItemsSource="{Binding Contacts}">
    <ListView.ItemTemplate>
      <DataTemplate>
        <ViewCell>
          <ViewCell.View>
            <StackLayout Orientation="Vertical">
              <StackLayout Orientation="Horizontal">
                <Label Text="{Binding Firstname}" />
                <Label Text="{Binding Lastname}" />
              </StackLayout>
              <Label Text="{Binding Mail}"/>
            </StackLayout>
          </ViewCell.View>
        </ViewCell>
      </DataTemplate>
    </ListView.ItemTemplate>

  </ListView>
  ```
  
  And here we are : you have a simple ListView with Mvvm behind ^^ Hope this we'll help someone !
  
  Next step for me : 
  + Add Buttons to Add/Remove Items and update ListView instantly.
  + Show a Menu on an ItemLongPressed event
  
  
