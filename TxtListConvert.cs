class TxtListConvert
{
public List<string> ConvertTxtFileToList(string txtFileName)
{
    string[] _listArray = File.ReadAllLines(txtFileName);
    List<string> newList = new List<string>();

        for (int i = 0; i < _listArray.Length; i++){
            newList.Add(_listArray[i]);
        }
    return newList;
}

public void SaveListAsTxtFile(List<string> saveList, string txtFileName)
{   
    for (int i = 0; i < saveList.Count; i++){
        File.AppendAllText(txtFileName, string.Format("{0}{1}", saveList[i], Environment.NewLine));
    }
}


}
