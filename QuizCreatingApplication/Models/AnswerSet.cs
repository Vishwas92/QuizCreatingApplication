using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizCreatingApplication.Models
{
    public interface IAnswerSet
    {
    }

    public class AnswerSet : IAnswerSet
    {
        public string optionCode;
        public string placeholder;

        public AnswerSet(string _optioncode, string _placeholder)
        {
            optionCode = _optioncode;
            placeholder = _placeholder;
        }
    }

}
