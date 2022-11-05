# Blazor dynamically linked drop down to list box

This is the solution to a unique use case:

Our marketing department wants to be able to send out email promotions to users.  That is simple enough.
Additionally, they want to be able to select the recipients by some or all the following:

  1.	All
  2.	Name
  3.	City
  4.	Zip Code

In addition, they want to be able to select all matching users of a city or zip code or just the Point of Contact (POC) for the account.

Last requirement is that if Name is selected with POC no other users can be selected and vise versa.  If the POC is not selected, the user can add names.


by [CodingwithDavid](http://twitter.com/CodingwithDavid)



## Getting Started

1. Clone this repository

   ```Command Line
   git clone https://github.com/CodingWithDavid/DynamicLinkedDropdown
   cd DynamicLinkedDropdown
   ```

1.	Open in Visual Studio or Visual Code
a.	With Visual Code you will need to install the C# extensions
2.	Press F5

## What's in the App

1. The final solution to the use case stated above.  
2. Event handling of the changing of the drop down
3. Event handling of selection items in the list
4. Showing and hiding the items based on a flag
5. Using simple HTML elements as a drop down and list box


## Problems or Suggestions

[Open an issue here]( https://github.com/CodingWithDavid/DynamicLinkedDropdown/issues)

## Thank You


## Resources

- [VS Code](https://code.visualstudio.com)
- [Visual Studio]( https://visualstudio.microsoft.com/)



