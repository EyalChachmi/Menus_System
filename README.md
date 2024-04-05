instead of manually writing code to display and manage menus, developers can simply utilize the MainMenu class. 
This class enables easy construction of menu hierarchies tailored to the specific needs of the application.

With an instance of the MainMenu class at hand, applications can efficiently build and manage their menus.
The MainMenu class facilitates the creation of menu items and submenus, providing flexibility in menu design.

Users can navigate through menu levels, select items, and perform actions within the application seamlessly. 
Input validation ensures a smooth user experience, with appropriate messages displayed for invalid input.

The implementation involved working with delegates, interfaces, and recursion, ensuring robust functionality. 
With this task completed, we've laid the groundwork for efficient menu management in console applications, enhancing user interaction and overall application usability.

At each stage:
The current level of the menu will be displayed to the user.
The user will be prompted to choose one of the items.
The user's choice will be input.
Input validation will be performed, and an appropriate message will be displayed in case of invalid input.
Navigation to the submenu / execution of the selected action will be performed:
a. Choosing an item containing sub-items will clear the screen and display the relevant sub-items (i.e., the next level in the menu, i.e., returning to step 1).
b. Choosing an item that does not contain sub-items (i.e., a choice that should result in some action in the system)
will clear the screen and invoke the function in the system that provides the user interface supporting this functionality of the system. 
