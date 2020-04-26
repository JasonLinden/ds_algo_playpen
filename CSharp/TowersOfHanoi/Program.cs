using System;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Tower(3, 'A', 'B', 'C');
        }

        // We need to move n disks from A to C via B
        // But we need to reduce the problem to 1 disk and move from there.
        // As soon as the smallest disk is moved from A to B. we meed to move the second smallest to C and the smallest back on top (C).
        // That free's up the 3rd disk, which we move. Once we move n - 1 we need to rebuid the tree to allow us to move the final disk (n)

        static void Tower(int disks, char from, char via, char to)
        {
            // base case
            if (disks == 1)
                Console.WriteLine($"Move disk 1 from {from} to {to}");
            else
            {
                // Initial move
                Tower(disks - 1, from, to, via);
                Console.WriteLine($"Move disk {disks} from {from} to {to}");

                // Rebuild tree
                Tower(disks - 1, via, from, to);
            }            
        }
    }
}
