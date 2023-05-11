package com.KRM3D.adultquestionanswerservice.services.rules;

import com.KRM3D.adultquestionanswerservice.entities.AdultQuestionAnswer;
import com.KRM3D.adultquestionanswerservice.repositories.AdultQuestionAnswerRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class AdultQuestionAnswerRules {
    private AdultQuestionAnswerRepository adultQuestionAnswerService;
    @Autowired
    public AdultQuestionAnswerRules(AdultQuestionAnswerRepository adultQuestionAnswerService) {
        this.adultQuestionAnswerService = adultQuestionAnswerService;
    }



    public  void DoToUpper(AdultQuestionAnswer adultQuestionAnswer){
        adultQuestionAnswer.setQuestionAnswer(adultQuestionAnswer.getQuestionAnswer().toUpperCase());
    }
    public  void DoToTrim(AdultQuestionAnswer adultQuestionAnswer){
        adultQuestionAnswer.setQuestionAnswer(adultQuestionAnswer.getQuestionAnswer().trim());
    }
}
