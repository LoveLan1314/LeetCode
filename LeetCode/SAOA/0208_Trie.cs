namespace LeetCode.SAOA
{
    internal sealed class Trie
    {
        private readonly Trie[] _children;
        private bool _isEnd;

        public Trie()
        {
            _children = new Trie[26];
            _isEnd = false;
        }

        public void Insert(string word)
        {
            Trie node = this;
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                int index = c - 'a';
                if (node._children[index] == null)
                {
                    node._children[index] = new Trie();
                }
                node = node._children[index];
            }
            node._isEnd = true;
        }

        public bool Search(string word)
        {
            Trie node = SearchPrefix(word);
            return node != null && node._isEnd;
        }

        public bool StartWith(string prefix)
        {
            return SearchPrefix(prefix) != null;
        }

        private Trie SearchPrefix(string prefix)
        {
            Trie node = this;
            for (int i = 0; i < prefix.Length; i++)
            {
                char c = prefix[i];
                int index = c - 'a';
                if (node._children[index] == null)
                {
                    return null;
                }
                node = node._children[index];
            }
            return node;
        }
    }
}
