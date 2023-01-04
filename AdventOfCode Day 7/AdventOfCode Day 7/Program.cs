using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Folder folderStructure = new Folder();
            folderStructure.name = "/";

            Folder currentFolder = folderStructure;

            string[] command = Console.ReadLine().Split();
            while (command[1] != "klaar")
            {
                while (command[0] != "$")
                {
                    if (command[0] == "dir")
                    {
                        Folder f = new Folder();
                        f.name = command[1];
                        f.parent = currentFolder;
                        f.enityList = new List<Entity>();
                        currentFolder.enityList.Add(f);
                    }
                    else
                    {
                        File f = new File();
                        f.fileSize = int.Parse(command[0]);
                        f.name = command[1];
                        f.parent = currentFolder;
                        currentFolder.enityList.Add(f);
                        Folder parent = f.parent;
                        while(parent != null)
                        {
                            parent.folderSize += f.fileSize;
                            parent = parent.parent;
                        }
                    }
                    command = Console.ReadLine().Split();
                }
                if (command[1] == "cd")
                {
                    if (command[2] == "..")
                    {
                        currentFolder = currentFolder.parent;
                    }
                    else if (command[2] != "/")
                    {
                        foreach (Entity f in currentFolder.enityList)
                        {
                            if (f.GetType() == typeof(Folder))
                            {
                                if (f.name == command[2])
                                    currentFolder = (Folder)f;

                            }
                        }
                    }
                }
                else if (command[1] == "klaar")
                    break;
                command = Console.ReadLine().Split();
            }

            int spaceLeft = 70000000 - folderStructure.folderSize;
            int spaceNeeded = 30000000;
            List<(int, string)> deletes = new List<(int, string)> ();

            Queue<Folder> queue = new Queue<Folder>();
            queue.Enqueue(folderStructure);
            while (queue.Count != 0)
            {
                Folder f = queue.Dequeue();
                if (spaceLeft + f.folderSize >= spaceNeeded)
                {
                    deletes.Add((f.folderSize, f.name));
                }

                foreach (Entity e in f.enityList)
                {
                    if (e.GetType() == typeof(Folder))
                    {
                        queue.Enqueue((Folder)e);
                    }
                }
            }

            (int, string) kleinste = (spaceNeeded, "hoi");
            foreach ((int, string) e in deletes)
            {
                if (e.Item1 <= kleinste.Item1)
                    kleinste = e;
            }

            Console.WriteLine(kleinste.Item1);
        }
    }

    class Folder : Entity
    {
        public List<Entity> enityList = new List<Entity>();
        public int folderSize = 0;
    }
    class File : Entity
    {
        public int fileSize = 0;
        public string fileType;
    }
    class Entity
    {
        public string name;
        public Folder parent;
    }
}