module addStarAlgorithm = 
	let name = "whatever" //could be anything
	let rec addDelim (strArg : string) = 
		//:pinchers: 
		if strArg.Length = 1 then strArg
		else (string strArg.[0]) + "*" + addDelim (string strArg.[1..])
	addDelim name |> printfn "%s"
