package com.KRM3D.adultquestionservice.services;

import com.KRM3D.adultquestionservice.entities.AdultQuestion;
import com.KRM3D.adultquestionservice.services.dtos.CreatedAdultQuestionDto;
import com.KRM3D.adultquestionservice.services.dtos.DeletedAdultQuestionDto;
import com.KRM3D.adultquestionservice.services.dtos.UpdatedAdultQuestionDto;

import java.util.List;

public interface AdultQuestionService {
    CreatedAdultQuestionDto add (CreatedAdultQuestionDto adultQuestion);
    UpdatedAdultQuestionDto update(UpdatedAdultQuestionDto adultQuestion);
    DeletedAdultQuestionDto delete(String id);
    List<AdultQuestion> getAll();
}
