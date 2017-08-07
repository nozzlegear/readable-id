namespace ReadableId

open System

type Builder() = 
    static let capitalizeWord (word: string) = 
        let first = word |> Seq.head |> string
        let rest = word.Substring 1
        
        sprintf "%s%s" (first.ToUpper()) (rest.ToLower())

    /// <summary>
    /// Builds a readable id by combining two adjectives and one animal.
    /// </summary>
    static member Build (?capitalizeWords: bool) =
        let pickWord words = 
            let word = words |> Seq.minBy (fun _ -> Guid.NewGuid())

            match capitalizeWords with
            | Some value -> if value then capitalizeWord word else word
            | None -> word

        let firstWord = pickWord Words.adjectives
        let secondWord = pickWord Words.adjectives
        let thirdWord = pickWord Words.animals

        sprintf "%s%s%s" firstWord secondWord thirdWord