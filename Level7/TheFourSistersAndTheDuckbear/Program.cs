int eggs = Convert.ToInt32(Console.ReadLine());

int duckeggs = eggs % 4;
int eggsisters = (eggs - duckeggs) / 4;

Console.WriteLine($"The sisters get {eggsisters} egg/eggs while the duckbear gets {duckeggs} egg/eggs");