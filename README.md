# FSharp.ListEx

F# List extensions for converting between F# and C# lists. It's really not that difficult but enough friction to make you search
[Stack Overflow](https://stackoverflow.com/questions/43271222/converting-between-c-sharp-list-and-f-list).

## How to use

```fs
open FSharp.ListEx

let fsList = [1; 2; 3]

// Convert F# List to C# List. This is the same as: `ResizeArray xs`
let csList = List.toResizeArray fsList
let csList = List.toCSharpList fsList // Alias for List.toResizeArray

// Convert C# List to F# List. This is the same as: `List.ofSeq xs`
fsList = List.ofResizeArray csList    // List module
fsList = List.ofCSharpList csList     // Alias for List.ofResizeArray

// Convert C# List to F# List. This is the same as: `Seq.toList xs`
fsList = csList.ToFSharpList ()       // Extension method

// Convert IEnumerable to F# List (can be used from C#). This is the same as: `ListModule.OfSeq(xs);`
let xs = csList :> IEnumerable<_>
fsList = xs.ToFSharpList ()           // Extension method
```
