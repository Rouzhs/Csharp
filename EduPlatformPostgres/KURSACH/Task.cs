namespace KURSACH
{
    internal class Task
    {
        public string Creator, Problem, Input, Output, Decision;
        public Task() { }   
        public Task(string creator, string problem, string input, 
            string output, string decision)
        { 
            Creator = creator; 
            Problem = problem;
            Input = input;
            Output = output;
            Decision = decision;
        }
    }
}
