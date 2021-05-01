using QuizCreatingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace QuizCreatingApplication.Controllers
{
    public class QuizzCreatorController: ApiController
    {
        private readonly IQuizz _quizz;
        private readonly IQuestions _questions;
        private readonly IAnswerSet _answerSet;
        private readonly IResponses _responses;
        public QuizzCreatorController(IQuizz quizz, IQuestions questions, IAnswerSet answerSet, IResponses responses)
        {
            _quizz = quizz;
            _questions = questions;
            _answerSet = answerSet;
            _responses = responses;
        }

        [HttpPost]
        public Quizz CreateQuiz(Quizz quizz)
        {

        }
    }
}
