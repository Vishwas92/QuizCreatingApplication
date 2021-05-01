using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizCreatingApplication.Models
{
    public interface IResponses 
    {

    }
    public class Responses: IResponses
    {
        private readonly string userId;
        private readonly string quizzId;
        private List<(Questions, string)> responses;

        public Responses(string _userId, string _quizzId, List<(Questions, string)> _responses)
        {
            userId = _userId;
            quizzId = _quizzId;
            responses = _responses;
        }

        public string UserId
        {
            get
            {
                return userId;
            }
        }

        public string QuizzId 
        {
            get
            {
                return quizzId;
            }
        }

        public List<(Questions, string)> Responses
        {
            get
            {
                return responses;
            }
        }

    }
}
