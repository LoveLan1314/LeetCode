using System.Runtime.CompilerServices;
using LeetCode._2025;

[assembly: InternalsVisibleTo("LeetCode.Test")]
namespace LeetCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 测试上传
            var solution = new MinWindowSolution();
            solution.MinWindow("ADOBECODEBANC", "ABC");
        }

    }
}
