# FSharp.ListEx

F# List extensions for converting between F# and C# lists. It's really not that difficult but enough friction to make you search
[Stack Overflow](https://stackoverflow.com/questions/43271222/converting-between-c-sharp-list-and-f-list).

## How to use

```fs
open FSharp.ListEx

let fsList = [1; 2; 3]

// Convert F# List to C# List
let csList = List.toResizeArray fsList
let csList = List.toCSharpList fsList // Alias for List.toResizeArray

 // Convert C# List to F# List
fsList = csList.ToFSharpList () // Extension method
fsList = List.ofResizeArray csList // List module
fsList = List.ofCSharpList csList // Alias for List.ofResizeArray

// Convert IEnumerable to F# List (can be used from C#)
let xs = csList :> IEnumerable<_>
fsList = xs.ToFSharpList () // Extension method
```
