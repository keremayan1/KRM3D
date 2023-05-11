package com.KRM3D.adultquestiontitleservice.services.rules;

import com.KRM3D.adultquestiontitleservice.entities.AdultQuestionTitle;
import com.KRM3D.adultquestiontitleservice.repositories.AdultQuestionTitleRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class AdultQuestionTitleRules {
    private AdultQuestionTitleRepository adultQuestionTitleRepository;
    @Autowired
    public AdultQuestionTitleRules(AdultQuestionTitleRepository adultQuestionTitleRepository) {
        this.adultQuestionTitleRepository = adultQuestionTitleRepository;
    }
    public void DoToUpper(AdultQuestionTitle adultQuestionTitle){
        adultQuestionTitle.setQuestionTitleName(adultQuestionTitle.getQuestionTitleName().toUpperCase());
    }
    public  void DoTrim(AdultQuestionTitle adultQuestionTitle){
        adultQuestionTitle.setQuestionTitleName(adultQuestionTitle.getQuestionTitleName().trim());
    }
}
