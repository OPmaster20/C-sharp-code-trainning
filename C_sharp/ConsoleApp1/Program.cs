using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace HelloWorld
{

public class Program
{
    public static void Main()
    {
        TraverseDirectory(@"C:\");
    }

    public static void TraverseDirectory(string targetDirectory)
    {

        Console.WriteLine(targetDirectory);

        string[] fileEntries = Array.Empty<string>();
        string[] subdirectoryEntries = Array.Empty<string>();

        try
        {
            fileEntries = Directory.GetFiles(targetDirectory);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (PathTooLongException e)
        {
            Console.WriteLine(e.Message);
        }

        foreach (string fileName in fileEntries)
        {
            Console.WriteLine(fileName);
        }

        try
        {
            subdirectoryEntries = Directory.GetDirectories(targetDirectory);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (PathTooLongException e)
        {
            Console.WriteLine(e.Message);
        }

        foreach (string subdirectory in subdirectoryEntries)
        {
            TraverseDirectory(subdirectory);
        }
    }
}



}