# PositionType

Ways of defining a position relative to another item.  

# Constants

## 0: None

## 1: InAbsolute

Position is based on ReferenceControl.ClientSize edges.  

## 2: InFloat

Works Like HTML float. Position is based on Controls already in ReferenceControl.  

**Example A:**  
Float left means place this to the right of the left-most control in the reference.  

## 3: Match

Exactly match the position of the reference.  

**Example A:**  
MatchLeft means use same Left location as the reference control.  

## 4: NextTo

Place this control next to the reference.  

