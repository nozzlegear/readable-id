# ReadableId
Generates a readable unique id in the form of AdjectiveAdjectiveAnimal. Credit goes to Gfycat for both the idea and the list of words.

## Installation

Install with the `dotnet` CLI tool:

```bash
dotnet add package readableid
```

## Usage

In C#:

```cs
public string GetUniqueId() 
{
    bool capitalize = true;
    string uniqueId = ReadableId.Builder.Build(capitalize);

    Console.WriteLine(uniqueId);
    // MeatySeverePachyderm

    return uniqueId;
}
```

In F#:

```fs
let getUniqueId capitalize = ReadableId.Builder.Build capitalize

printfn "%s" (getUniqueId true)
// ThirdMaroonBrocketdeer
```