using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class NumUniqueEmailsSolution
    {
        public int NumUniqueEmails(string[] emails)
        {
            var emailSet = new HashSet<string>();
            foreach (string email in emails)
            {
                int i = email.IndexOf('@');
                string local = email.Substring(0, i).Split("+")[0]; // 去掉本地名第一个加号之后的部分
                local = local.Replace(".", ""); // 去掉本地名中所有的句点
                emailSet.Add(local + email.Substring(i));
            }
            return emailSet.Count;
        }
    }
}
