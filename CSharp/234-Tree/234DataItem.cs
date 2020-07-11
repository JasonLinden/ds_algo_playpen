using System;

namespace _234_Tree
{
    // Objects of the DataItem class represent the data items stored in nodes.In a real-world
    // program each object would contain an entire personnel or inventory record, but
    // here there’s only one piece of data, of type long, associated with each DataItem object.

    public class _234DataItem
    {
        public long dData;

        public _234DataItem(long data)
        {
            dData = data;
        }

        public void DisplayItem()
        {
            Console.Write($"/{dData}");
        }
    }
}
