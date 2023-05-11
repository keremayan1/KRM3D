package com.KRM3D.adultquestiontitleservice.services;

import com.KRM3D.adultquestiontitleservice.services.dto.CreatedAdultQuestionTitleDto;
import com.KRM3D.adultquestiontitleservice.services.dto.DeletedAdultQuestionTitleDto;
import com.KRM3D.adultquestiontitleservice.services.dto.UpdatedAdultQuestionTitleDto;

public interface AdultQuestionTitleService {
    CreatedAdultQuestionTitleDto add(CreatedAdultQuestionTitleDto adultQuestionTitle);
    UpdatedAdultQuestionTitleDto update(UpdatedAdultQuestionTitleDto adultQuestionTitle);
    DeletedAdultQuestionTitleDto delete(String id);
}
