namespace LeetCode.SAOA
{
    internal sealed class InterpretSolution
    {
        public string Interpret(string command)
        {
            return command.Replace("()", "o").Replace("(al)", "al");
        }
    }
}
