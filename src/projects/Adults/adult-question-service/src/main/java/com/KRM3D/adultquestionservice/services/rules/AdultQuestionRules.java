package com.KRM3D.adultquestionservice.services.rules;

import com.KRM3D.adultquestionservice.entities.AdultQuestion;
import com.KRM3D.adultquestionservice.repositories.AdultQuestionRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.autoconfigure.AutoConfiguration;
import org.springframework.stereotype.Service;

@Service
public class AdultQuestionRules {
    private AdultQuestionRepository adultQuestionRepository;
    @Autowired
    public AdultQuestionRules(AdultQuestionRepository adultQuestionRepository) {
        this.adultQuestionRepository = adultQuestionRepository;
    }
    public  void DoToUpper(AdultQuestion adultQuestion){
        adultQuestion.setQuestionName(adultQuestion.getQuestionName().toUpperCase());
    }
    public  void DoTrim(AdultQuestion adultQuestion){
        adultQuestion.setQuestionName(adultQuestion.getQuestionName().trim());
    }

}
