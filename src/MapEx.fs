namespace FSharp.ListEx

open System.Collections.Generic

[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
[<RequireQualifiedAccess>]
module Map =
    /// Convert C# Dictionary to F# Map. This is the same as: `xs |> Seq.map (|KeyValue|) |> Map.ofSeq`
    let ofDictionary xs =
        xs |> Seq.map (|KeyValue|) |> Map.ofSeq

    /// Convert F# Map to C# IDictionary. This is the same as: `Map.toSeq xs |> dict`
    let inline toIDictionary xs =
        Map.toSeq xs |> dict

    /// Convert F# Map to C# Dictionary. This is the same as: `Dictionary xs`
    let inline toDictionary (xs: Map<_,_>) =
        Dictionary xs

