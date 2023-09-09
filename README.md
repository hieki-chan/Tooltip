# UNITY TOOLTIP!!!
> namespace Tools.UI

## Overview
This tooltip is a custom Unity component designed to provide informative and interactive tooltips for user interfaces. It enhances the user experience by displaying additional information when the user hovers over specific elements.

## Key Features
- Interactive tooltips that appear when the user hovers over UI elements.
- Customizable styles, including font size, background color, and text color.
- Supports rich text formatting, allowing for bold, italic, and different colored text within tooltips.
- Adjustable position and alignment options for tooltips to ensure optimal visibility.
- Easy to use.

## How to Use
1. Import namespace
```c#
using Tools.UI;
```
2. Attach the `Tooltip` script to the UI GameObject, use `TooltipTrigger` to trigger the tooltip by `TriggerType`, and customize the appearance of the tooltip by adjusting its properties in the Unity Inspector, such as font size, colors, and alignment.

3. Show Tooltip by code.
 ```C#
//Singleton call
ToolTip.current.Show(yourText);
//Static call
ToolTip.Show(yourText);
//Note: You should call only if the instance is already.
 ```

4. Finally, run and test in your project.

## License
Please read the LICENSE file.
