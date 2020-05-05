# FSharp.ListEx

F# List extensions for converting between F# and C# lists. It's really not that difficult but enough friction to make you search
[Stack Overflow](https://stackoverflow.com/questions/43271222/converting-between-c-sharp-list-and-f-list).

## How to use

```fs
open FSharp.ListEx

let fsList = [1; 2; 3]

// Convert F# List to C# List.
let csList = ResizeArray fsList           // Without FSharp.ListEx
let csList = List.toResizeArray fsList    // F# List module (FSharp.ListEx)
let csList = List.toCSharpList fsList     // Alias for List.toResizeArray (FSharp.ListEx)

// Convert C# List to F# List.
let fsList = List.ofSeq xs                // Without FSharp.ListEx
let fsList = List.ofResizeArray csList    // F# List module (FSharp.ListEx)
let fsList = List.ofCSharpList csList     // Alias for List.ofResizeArray (FSharp.ListEx)

// Convert C# List to F# List.
let fsList = Seq.toList csList            // Without FSharp.ListEx
let fsList = csList.ToFSharpList ()       // List (C#) extension method (FSharp.ListEx)

// Convert IEnumerable to F# List (can be used from C#).
let fsList = ListModule.OfSeq(xs)         // Without FSharp.ListEx

let xs = csList :> IEnumerable<_>
let fsList = xs.ToFSharpList ()           // IEnumerable extension method (FSharp.ListEx)
```
