using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class TreeStorage<T> : ITreeStorage<T> where T : IComparable<T>
    {

        public Tree<T> Load(Stream stream)
        {
            Helpers.Check(stream, nameof(stream));
            using (var streamReader = new StreamReader(stream))
            {
                return JsonConvert.DeserializeObject<Tree<T>>(streamReader.ReadToEnd());
            }
        }

        public void Save(Stream stream, Tree<T> tree)
        {
            Helpers.Check(stream, nameof(stream));
            Helpers.Check(tree, nameof(tree));
            using (var streamWriter = new StreamWriter(stream))
            {
                streamWriter.Write(JsonConvert.SerializeObject(tree));
            }
        }
    }
}
