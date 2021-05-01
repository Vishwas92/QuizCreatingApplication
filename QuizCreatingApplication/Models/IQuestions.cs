using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizCreatingApplication.Models
{
    public interface IQuestions
    {
    }

    public class Questions : IQuestions
    {
        private readonly string questionId;
        private readonly string description;
        private readonly string ans;
        private readonly AnswerSet answerSet;

        [MongoDB.Bson.Serialization.Attributes.BsonConstructor]
        public Questions(string _questionId, string _description, string _ans, AnswerSet _answerSet)
        {
            questionId = _questionId;
            description = _description;
            ans = _ans;
            answerSet = _answerSet;
        }

        [MongoDB.Bson.Serialization.Attributes.BsonId]
        [MongoDB.Bson.Serialization.Attributes.BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string QuestionId { 
            get
            {
                return questionId;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
        }
        public string Answer
        {
            get
            {
                return ans;
            }
        }
        public AnswerSet AnswerSet
        {
            get
            {
                return answerSet;
            }
        }

    }

}
