﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForFundamental.FileIO;

internal class FolderHandler
{
    public static void CreateFolder(string newFolderName, string rootPath = "")
    {
        var folderPath = $"{rootPath}\\{newFolderName}";
        var folderExist = Directory.Exists(folderPath);
     
        if(!folderExist)
            Directory.CreateDirectory(folderPath);
        
      
    }
    


}

