namespace ConsoleApplication.Algorithms.Fifty
{
    class ImplementStrStr
    {
        public int StrStr(string haystack,string needle){
            //return haystack.IndexOf(needle);
            if(haystack == null || needle == null || needle.Length == 0) return 0;
            if(needle.Length > haystack.Length) return -1;
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                bool flag = true;
                for (int j = 0; j < needle.Length; j++)
                {
                    if(haystack[i+j] != needle[j]){
                        flag = false;
                        break;
                    }
                }
                if(flag) return i;
            }
            return -1;
        }
    }
}