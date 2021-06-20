using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class ThroneInheritance
    {
        private readonly Dictionary<string, IList<string>> _edges;
        private readonly ISet<string> _dead;
        private readonly string _king;

        public ThroneInheritance(string kingName)
        {
            _edges = new Dictionary<string, IList<string>>();
            _dead = new HashSet<string>();
            _king = kingName;
        }

        public void Birth(string parentName, string childName)
        {
            if (_edges.TryGetValue(parentName, out IList<string> children))
            {
                children.Add(childName);
                _edges[parentName] = children;
            }
            else
            {
                children = new List<string>
                {
                    childName
                };
                _edges.Add(parentName, children);
            }
        }

        public void Death(string name)
        {
            _dead.Add(name);
        }


        public IList<string> GetInheritanceOrder()
        {
            IList<string> ans = new List<string>();
            Preorder(ans, _king);
            return ans;
        }

        private void Preorder(IList<string> ans, string name)
        {
            if (!_dead.Contains(name))
            {
                ans.Add(name);
            }
            IList<string> children = _edges.TryGetValue(name, out children) ? children : new List<string>();
            foreach (string childName in children)
            {
                Preorder(ans, childName);
            }
        }
    }
}
