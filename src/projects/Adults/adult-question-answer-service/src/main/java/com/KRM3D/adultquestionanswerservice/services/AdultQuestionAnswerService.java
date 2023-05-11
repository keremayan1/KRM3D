package com.KRM3D.adultquestionanswerservice.services;

import com.KRM3D.adultquestionanswerservice.entities.AdultQuestionAnswer;
import com.KRM3D.adultquestionanswerservice.services.dtos.CreatedAdultQuestionAnswerDto;
import com.KRM3D.adultquestionanswerservice.services.dtos.DeletedAdultQuestionAnswerDto;
import com.KRM3D.adultquestionanswerservice.services.dtos.UpdatedAdultQuestionAnswerDto;

import java.util.List;

public interface AdultQuestionAnswerService {
    List<CreatedAdultQuestionAnswerDto> addAll(List<CreatedAdultQuestionAnswerDto> createdAdultQuestionAnswer);
    UpdatedAdultQuestionAnswerDto update(UpdatedAdultQuestionAnswerDto updatedAdultQuestionAnswerDto);
    DeletedAdultQuestionAnswerDto delete(String id);
    List<AdultQuestionAnswer> getAll();
}
