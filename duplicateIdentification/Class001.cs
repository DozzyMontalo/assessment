using System;
using System.Collections.Generic;

namespace duplicateID
{
    public class DuplicateIdentifier<T> where T : IEquatable<T>
    {
        private readonly List<T> _collectionA;
        private readonly List<T> _collectionS;

        public DuplicateIdentifier(List<T> collectionA, List<T> collectionS)
        {
            _collectionA = collectionA;
            _collectionS = collectionS;
        }

        public void IdentifyDuplicates()
        {
            var results = new Dictionary<T, bool>();

            var hashSetA = new HashSet<T>(_collectionA);

            foreach (var element in _collectionS)
            {
                results[element] = hashSetA.Contains(element);
            }

            foreach (var pairs in results)
            {
                Console.WriteLine($"{pairs.Key}:{pairs.Value.ToString().ToLower()}");
            }
        }
    }
}