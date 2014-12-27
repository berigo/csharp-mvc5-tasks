This project act as container for TimesPicker control. It is not complete project, but part of it. It is prepared in github: 
https://github.com/berigo/csharp-mvc5-tasks
The TimesPicker control is html control for selecting items which are assigned for specific date and time. 

Acceptance conditions:

1) TimesPicker control looks like it is specified in mockup (https://github.com/berigo/csharp-mvc5-tasks/blob/master/WebApp/WebApp/Areas/Task001/Content/Images/Task001-timespicker.png)
2) List of items for timespicker are loaded from controller on changing date
3) Selected/deselected item on timespicker (with checkbox) appears/disappears on selected items list.
4) Item removed from selected items list deselects appropriate item on timespicker (unchecks checkbox)
5) Past dates are disabled and cannot be selected
6) Submit action must send selected dates and times controller action "ConfirmTimes"
7) TimePicker, selected items list and submit button are made as separate controls and are implemented as razor views (could be partial) or html template with placeholders for data. Creating controls with js is not acceptable. 
8) Control works on IE9 or higher and latest firefox, chrome, safari browsers versions
9) Scripts and styles used in the project must remain as it is. If implementation requires to change version it must be confirmed by me first.