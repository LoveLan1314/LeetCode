﻿using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class CodecSolution2
    {
        private readonly Dictionary<int, string> dataBase = new Dictionary<int, string>();
        private int id;

        public string encode(string longUrl)
        {
            id++;
            if (!dataBase.ContainsKey(id))
            {
                dataBase.Add(id, longUrl);
            }
            else
            {
                dataBase[id] = longUrl;
            }
            return "http://tinyurl.com/" + id;
        }

        public string decode(string shortUrl)
        {
            int p = shortUrl.LastIndexOf('/') + 1;
            int key = int.Parse(shortUrl.Substring(p, shortUrl.Length - p));
            return dataBase[key];
        }
    }
}
