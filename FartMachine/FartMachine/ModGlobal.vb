Module ModGlobal

    Public Function GetExtendedFileProperty(ByVal filePath As String, ByVal propertyName As String) As String
        Dim value As String = String.Empty
        Dim baseFolder As String = IO.Path.GetDirectoryName(filePath)
        Dim fileName As String = IO.Path.GetFileName(filePath)

        'Method to load and execute the Shell object for Windows server 8 environment otherwise you get "Unable to cast COM object of type 'System.__ComObject' to interface type 'Shell32.Shell'"
        Dim shellAppType As Type = Type.GetTypeFromProgID("Shell.Application")
        Dim shell As Object = Activator.CreateInstance(shellAppType)
        Dim shellFolder As Shell32.Folder = DirectCast(shellAppType.InvokeMember("NameSpace", System.Reflection.BindingFlags.InvokeMethod, Nothing, shell, New Object() {baseFolder}), Shell32.Folder)

        'Parsename will find the specific file I'm looking for in the Shell32.Folder object
        Dim folderitem As Shell32.FolderItem = shellFolder.ParseName(fileName)
        If folderitem IsNot Nothing Then
            For i As Integer = 0 To Short.MaxValue - 1
                'Get the property name for property index i
                Dim [property] As String = shellFolder.GetDetailsOf(Nothing, i)

                'Will be empty when all possible properties has been looped through, break out of loop
                If String.IsNullOrEmpty([property]) Then
                    Exit For
                End If

                'Skip to next property if this is not the specified property
                If [property] <> propertyName Then
                    Continue For
                End If

                'Read value of property
                value = shellFolder.GetDetailsOf(folderitem, i)
            Next i
        End If
        'returns string.Empty if no value was found for the specified property
        Return value
    End Function

End Module
