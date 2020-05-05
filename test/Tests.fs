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

    printfn "All tests passed!"
    0 // return an integer exit code
