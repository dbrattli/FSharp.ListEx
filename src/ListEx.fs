namespace FSharp.ListEx

[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
[<RequireQualifiedAccess>]
module List =
    /// Convert F# List to C# List
    let inline toResizeArray (xs: List<_>) =
        ResizeArray xs

    /// Alias for List.toResizeArray
    let toCSharpList = toResizeArray

    /// Convert C# List to F# List
    let inline ofResizeArray xs =
        List.ofSeq xs

    /// Alias for List.ofResizeArray
    let ofCSharpList = ofResizeArray

[<AutoOpen>]
module ListExtensions =
    /// Convert C# List to F# List
    type System.Collections.Generic.List<'T> with
        member inline this.ToFSharpList () : List<'T> =
            Seq.toList this

#if !FABLE_COMPILER
open System.Runtime.CompilerServices
open System.Collections.Generic
[<Extension>]
type IEnumerableExtensions =
    [<Extension>]
    /// <summary>
    /// Convert IEnumerable to F# List.
    /// </summary>
    /// <param name="xs">IEnumerable to convert to F# List</param>
    /// <typeparam name="'T">Type of enumerable item.</typeparam>
    /// <returns>F# List</returns>
    static member inline ToFSharpList(xs: IEnumerable<'T>) = List.ofSeq xs
#endif