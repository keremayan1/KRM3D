package com.krm3d.question.application.features;

import com.krm3d.question.application.features.dtos.CreatedQuestionDto;
import com.krm3d.question.application.features.dtos.DeletedQuestionDto;
import com.krm3d.question.application.features.dtos.UpdatedQuestionDto;

public interface QuestionCommandService {
    CreatedQuestionDto add(CreatedQuestionDto createdQuestionDto);
    DeletedQuestionDto delete(String id);
    UpdatedQuestionDto update(UpdatedQuestionDto updatedQuestionDto);
}
