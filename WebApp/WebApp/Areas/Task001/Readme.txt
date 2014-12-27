This project act as container for TimesPicker control. It is not complete project, but part of it.
The TimesPicker control is html control for selecting items which are assigned for specific date and time interval. 
Look to the more detailed control specification: WebApp\Areas\Task001\Content\Images\Task001-timespicker.png

Some more requirements:

1) JS should be used only for clientside actions implementation. It is not recommended to draw html elements with js. 
ASP.NET MVC means Razor usage, so normally controls must be implemented as partial views. Or it could be html templates with placeholders.

2)  List of times items, selected items list and submit button are separate controls and must not be implemented as one control. 