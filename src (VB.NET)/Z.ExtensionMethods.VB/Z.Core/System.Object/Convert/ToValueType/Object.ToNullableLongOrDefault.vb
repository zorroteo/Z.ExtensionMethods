
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_411

	''' <summary>
	'''     An object extension method that converts this object to a nullable long or default.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The given data converted to a long?</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToNullableLongOrDefault(this As Object) As System.Nullable(Of Long)
		Try
			If this Is Nothing OrElse this = DBNull.Value Then
				Return Nothing
			End If

			Return Convert.ToInt64(this)
		Catch generatedExceptionName As Exception
			Return 0
		End Try
	End Function

	''' <summary>
	'''     An object extension method that converts this object to a nullable long or default.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="defaultValue">The default value.</param>
	''' <returns>The given data converted to a long?</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToNullableLongOrDefault(this As Object, defaultValue As System.Nullable(Of Long)) As System.Nullable(Of Long)
		Try
			If this Is Nothing OrElse this = DBNull.Value Then
				Return Nothing
			End If

			Return Convert.ToInt64(this)
		Catch generatedExceptionName As Exception
			Return defaultValue
		End Try
	End Function

	''' <summary>
	'''     An object extension method that converts this object to a nullable long or default.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="defaultValueFactory">The default value factory.</param>
	''' <returns>The given data converted to a long?</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToNullableLongOrDefault(this As Object, defaultValueFactory As Func(Of System.Nullable(Of Long))) As System.Nullable(Of Long)
		Try
			If this Is Nothing OrElse this = DBNull.Value Then
				Return Nothing
			End If

			Return Convert.ToInt64(this)
		Catch generatedExceptionName As Exception
			Return defaultValueFactory()
		End Try
	End Function
End Module


