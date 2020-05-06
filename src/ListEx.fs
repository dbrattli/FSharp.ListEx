namespace FSharp.ListEx

open System

[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
[<RequireQualifiedAccess>]
module List =
    /// Convert F# List to C# List. This is the same as: `ResizeArray xs`
    let inline toResizeArray (xs: List<_>) =
        ResizeArray xs

    /// Alias for List.toResizeArray. This is the same as: `ResizeArray xs`
    let toCSharpList = toResizeArray

    /// Convert C# List to F# List. This is the same as: `List.ofSeq xs`
    let inline ofResizeArray xs =
        List.ofSeq xs

    /// Convert IEnumerable to F# List. This is the same as: `List.ofSeq xs`
    let inline ofEnumerable xs = List.ofSeq xs

    [<Obsolete("This function is deprecated. Use List.ofEnumerable instead")>]
    let ofCSharpList xs = ofResizeArray xs

    /// Hides the identity of the List.
    let inline asEnumerable (xs: List<'T>) = Seq.ofList xs

[<AutoOpen>]
module ListExtensions =
    /// Convert C# List to F# List. This is the same as: `Seq.toList xs`
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
    /// Convert IEnumerable to F# List. This is the same as: `ListModule.OfSeq(xs);`
    /// </summary>
    /// <param name="xs">IEnumerable to convert to F# List</param>
    /// <typeparam name="'T">Type of enumerable item.</typeparam>
    /// <returns>F# List</returns>
    static member inline ToFSharpList(xs: IEnumerable<'T>) = List.ofSeq xs
#endif