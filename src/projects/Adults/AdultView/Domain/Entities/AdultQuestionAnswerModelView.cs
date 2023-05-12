﻿using Core.Persistance.Repositories.EntityFramework;

namespace Domain.Entities
{
    public class AdultQuestionAnswerModelView : Entity
    {
        public string _id { get; set; }
        public string QuestionId { get; set; }
        public string QuestionAnswer { get; set; }
        public AdultQuestionAnswerModelView()
        {

        }

        public AdultQuestionAnswerModelView(string id, string questionId, string questionAnswer)
        {
            _id = id;
            QuestionId = questionId;
            QuestionAnswer = questionAnswer;
        }
    }
}

