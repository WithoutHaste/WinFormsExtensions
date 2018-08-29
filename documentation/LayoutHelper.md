# LayoutHelper

Helper for placing and sizing controls in a Form relative to each other.

Uses method chaining for a fluent writing style. Location and sizing methods can be chained in any order. `Apply` must be the last command.

Add the control to its parent after using `LayoutHelper`.

Syntax example:  
`LayoutHelper.Below(toolStrip).MatchLeft(otherControl).Right(form).Height(25).Apply(control);`

## Location/Size relative to parent control

Place control edge at the inner edge of the parent:  
`Top(parent)` `Top(parent, margin)`  
`Bottom(parent)` `Bottom(parent, margin)`  
`Left(parent)` `Left(parent, margin)`  
`Right(parent)` `Right(parent, margin)`  
`Fill(parent)` `Fill(parent, margin)`  

Float control edge towards an inner edge of the parent, until it runs into a previously placed control:  
`FloatTop(parent)` `FloatTop(parent, margin)`  
`FloatBottom(parent)` `FloatBottom(parent, margin)`  
`FloatLeft(parent)` `FloatLeft(parent, margin)`  
`FloatRight(parent)` `FloatRight(parent, margin)`  

## Location/Size relative to sibling control

Place control edge at the same location as a sibling control:  
`MatchTop(sibling)` `MatchTop(sibling, margin)`  
`MatchBottom(sibling)` `MatchBottom(sibling, margin)`  
`MatchLeft(sibling)` `MatchLeft(sibling, margin)`  
`MatchRight(sibling)` `MatchRight(sibling, margin)`  

Place control edge directly next to a sibling control:  
`Below(sibling)` `Below(sibling, margin)`  
`Above(sibling)` `Above(sibling, margin)`  
`RightOf(sibling)` `RightOf(sibling, margin)`  
`LeftOf(sibling)` `LeftOf(sibling, margin)`  

## Absolute size

Set size:  
`Width(width)`  
`Height(height)`  

Set size and center control in parent:  
`CenterWidth(parent, width)`  
`CenterHeight(parent, height)`  