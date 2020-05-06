namespace FSharp.ListEx

open System.Collections.Generic

[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
[<RequireQualifiedAccess>]
module Map =
    let ofDictionary xs =
        xs |> Seq.map (|KeyValue|) |> Map.ofSeq

    let toIDictionary xs =
        Map.toSeq xs |> dict

    let toDictionary (xs: Map<_,_>) =
        Dictionary xs

