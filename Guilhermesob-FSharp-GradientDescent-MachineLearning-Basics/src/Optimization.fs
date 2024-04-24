let gradientDescent (x: float[]) (y: float[]) (learningRate: float) (iterations: int) =
    let m = float x.Length
    let alpha = learningRate
    let theta = Array.zeroCreate<float> x.Length

    for _ in 1 .. iterations do
        let gradient = x |> Array.mapi (fun i xi -> (xi - y.[i]) * xi) |> Array.average
        theta <- theta |> Array.map (fun t -> t - alpha * gradient)

    theta
