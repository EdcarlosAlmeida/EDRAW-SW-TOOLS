using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDRAW_SwTools{

  class ExplorerPath{

    const string sourcePath = @"C:\Users\Projeto01\Desktop\EDRAW SwTools\EDRAW-SW-TOOLS\WinPath";        
    const string targetPath = @"P:\TESTES EDDY\EDDY\";
    const string currentPath = "Pattern";
    const string makePath = "221-0000-TESTE FILE EXPLORER";

    static void Main(){            
      
      if (Directory.Exists(targetPath+"\\"+makePath)){
          Console.WriteLine("Directory exist");
      }else{

        var oldPath = sourcePath+"\\"+currentPath;
        var newPath = sourcePath+"\\"+makePath;

        Directory.Move(oldPath,newPath);

        //make Folder
        foreach (var path in Directory.GetDirectories(sourcePath, "*",SearchOption.AllDirectories)){
            Directory.CreateDirectory(path.Replace(sourcePath,targetPath));
        }
        // Copy file teste
        foreach (var iFile in Directory.GetFiles(sourcePath,"*",SearchOption.AllDirectories)){
            File.Copy(iFile , iFile.Replace(sourcePath,targetPath),true);
        }
        Directory.Move(newPath,oldPath);
      }  
    }
  }
}