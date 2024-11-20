using System;
using System.Collections.Generic;

namespace duplicateID
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collectionA = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            List<int> collectionS = new List<int> { 5, 15, 3, 19, 35, 50, -1, 0 };

            DuplicateIdentifier<int> identifier = new DuplicateIdentifier<int>(collectionA, collectionS);
            identifier.IdentifyDuplicates();
        }
    }
}