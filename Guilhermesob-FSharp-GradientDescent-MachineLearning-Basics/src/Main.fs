let costFunction (x: float[]) (y: float[]) =
    let m = float x.Length
    let sum = x |> Array.zip y |> Array.sumBy (fun (x, y) -> (x - y) ** 2.0)
    sum / (2.0 * m)