using Submodules.Second.Contracts;
using System;

namespace Submodules.Second.Logic
{
    public class SecondLogic : ISecondLogic
    {
        public string ExecuteAndGetPunctuation(SecondContract data)
        {
            Console.Write(data.SecondPunctuationParam);
            return data.SecondPunctuationParam;
        }
    }
}