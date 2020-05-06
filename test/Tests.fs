// Learn more about F# at http://fsharp.org

open System.Collections.Generic
open FSharp.ListEx

[<EntryPoint>]
let main argv =
    // Arrange
    let fsList = [1; 2; 3]

    // Act
    let csList = List.toResizeArray fsList // System.Collections.Generic.List

    // Assert
    assert (fsList = csList.ToFSharpList ())
    assert (fsList = (csList :> IEnumerable<_>).ToFSharpList ())
    assert (fsList = List.ofResizeArray csList)
    assert (fsList = List.ofCSharpList csList)

    // Act
    let csList = List.toCSharpList fsList

    // Assert
    assert (fsList = csList.ToFSharpList ())
    assert (fsList = (csList :> IEnumerable<_>).ToFSharpList ())
    assert (fsList = List.ofResizeArray csList)
    assert (fsList = List.ofCSharpList csList)

    // Arrange
    let fsMap = Map [("a", 10); ("b", 20) ]

    // Act
    let csDict = Map.toDictionary fsMap
    let csIDict = Map.toIDictionary fsMap

    // Assert
    assert(fsMap = Map.ofDictionary csDict)
    assert(fsMap = Map.ofDictionary csIDict)

    printfn "All tests passed!"
    0 // return an integer exit code
