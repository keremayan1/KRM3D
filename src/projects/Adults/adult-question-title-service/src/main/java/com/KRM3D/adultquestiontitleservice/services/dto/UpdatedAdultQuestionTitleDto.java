package com.KRM3D.adultquestiontitleservice.services.dto;

import lombok.Data;
import org.springframework.data.annotation.Id;

@Data
public class UpdatedAdultQuestionTitleDto {
    @Id
    private String get_id;
    private String questionTitleName;
}
