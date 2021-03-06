
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_556

	''' <summary>
	'''     Indicates whether two adjacent  objects at a specified position in a string form a surrogate pair.
	''' </summary>
	''' <param name="s">A string.</param>
	''' <param name="index">The starting position of the pair of characters to evaluate within .</param>
	''' <returns>
	'''     true if the  parameter includes adjacent characters at positions  and  + 1, and the numeric value of the
	'''     character at position  ranges from U+D800 through U+DBFF, and the numeric value of the character at position
	'''     +1 ranges from U+DC00 through U+DFFF; otherwise, false.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsSurrogatePair(s As [String], index As Int32) As [Boolean]
		Return [Char].IsSurrogatePair(s, index)
	End Function
End Module


