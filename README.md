# UNITY TOOLTIP!!!
> namespace UnityE.UI

## Overview
This tooltip is a custom Unity component designed to provide informative and interactive tooltips for user interfaces. It enhances the user experience by displaying additional information when the user hovers over specific elements.

## How to Use
1. Import namespace
```c#
using UnityE.UI;
```
2. Attach the `Tooltip` script to the UI GameObject, and customize the appearance of the tooltip.

3. Show/Hide Tooltip.
 ```C#
//Show tooltip
ToolTip.Show(yourText);               //Static call
ToolTip.current.SetTooltip(yourText); //Singleton call

//Hide tooltip
Tooltip.Hide();                       //Stattic call
Tooltip.current.HideTooltip();        //Singleton call
//Note: You should call only if the instance is already.
 ```
4. TooltipTriggers: ScreenSpace and WorldSpace.
   
   `TooltipTriggerBase`: base class to trigger the Tooltip.
   
   `TooltipTrigger`: used to trigger the tooltip in world space.
   
   `TooltipTriggerUI`: used to trigger the tooltip by `TriggerType` in screen space (UI).
6. Finally, run and test in your project.

## License
Please read the LICENSE file.
