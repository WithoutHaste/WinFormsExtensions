# [WithoutHaste.Windows.GUI](TableOfContents.WithoutHaste.Windows.GUI.md).IHistoryAction

**Interface**  

An action that can be managed by a [History](WithoutHaste.Windows.GUI.History.md) object.  

# Methods

## Do()

**abstract void**  

Action to run on "redo".  

## Undo()

**abstract void**  

Action to run on "undo".  

# Implemented By

[WithoutHaste.Windows.GUI.HistoryActionGroup](WithoutHaste.Windows.GUI.HistoryActionGroup.md)  
An [IHistoryAction](WithoutHaste.Windows.GUI.IHistoryAction.md) that groups actions that must be undone/redone as a set.  

