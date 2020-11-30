﻿using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TagCloud
{
    public class WordsReader : IWordsReader
    {
        private readonly string path;

        public WordsReader(string path) =>
            this.path = path;

        public List<string> Get()
        {
            using (var fileStream = new StreamReader(path))
            {
                return fileStream.ReadToEnd().Split('\n').ToList();
            }
        }
    }
}