using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizCreatingApplication.Models
{
    public interface IQuizz
    {

    }
    public class Quizz : IQuizz
    {
        private readonly string id;
        private List<Questions> questionSet;
        
        public Quizz(string _id, List<Questions> _questionSet)
        {
            id = _id;
            questionSet = _questionSet;
        }

        public string Id {
            get
            {
                return id;
            }
        }

        public List<Questions> QuestionSet
        {
            get
            {
                return questionSet;
            }
        }
    }
}
