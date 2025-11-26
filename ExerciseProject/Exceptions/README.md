# Exceptions

## 1. Identify the exception

You have been on a trip recently to South America and have taken a lot of pictures from your trip.
But when you get home your drive cant hold your old files and the new ones therefor you buy a new one with more spaces. But something undexcpeted 
happende when you tried to send over all the files.

a) Identify which exception is caused by the current implementation without running the code.

b) Handle and fix the error with a try catch.

```
string[] oldDrive = { "oldfile1", "oldfile2", "oldfile3" };
string[] newFiles = { "newFile1", "newFile2", "newFile3", "newFile4" };
string[] newDrive = new string[oldDrive.Length + newFiles.Length];

for (int i = 0; i < newDrive.Length; i++)
{
   newDrive[i] = oldDrive[i];
  
}
int newIndex = oldDrive.Length;
for (int i = 0; i < newDrive.Length; i++)
{
   newDrive[newIndex] = newFiles[i];
   newIndex++;
}
```
    
   
 