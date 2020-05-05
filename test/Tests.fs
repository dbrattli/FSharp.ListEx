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
    assert (fsList = csList.ToList ())
    assert (fsList = List.ofResizeArray csList)
    assert (fsList = List.ofCSharpList csList)

    // Act
    let csList = List.toCSharpList fsList

    // Assert
    assert (fsList = csList.ToFSharpList ())
    assert (fsList = csList.ToList ())
    assert (fsList = List.ofResizeArray csList)
    assert (fsList = List.ofCSharpList csList)

    0 // return an integer exit code
