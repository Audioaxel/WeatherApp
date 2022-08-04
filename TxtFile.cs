class TxtFile
{

public bool CreateTxtFile(string txtFileName)
{
    bool noTxtFound = !File.Exists(txtFileName);
            
    if (noTxtFound){
        File.Create(txtFileName);
    }
    return noTxtFound;
    // Hier bestimmt besser mit excep!?!?!
}


}